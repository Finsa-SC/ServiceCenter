using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ServiceCenter.StockManagement
{
    public partial class StockInForm : Form
    {
        int spareId = 0;
        public StockInForm(int spareId)
        {
            InitializeComponent();
            this.spareId = spareId;
        }

        int stock;
        private void StockInForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT stock FROM spareparts WHERE sparepart_id = @id";
            stock = Convert.ToInt32(DBHelper.executeScalar(query,
                new SqlParameter("@id", spareId)
            ));
            txtStock.Text = stock.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStockIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private void txtStockIn_TextChanged(object sender, EventArgs e)
        {
            int stockIn;
            int.TryParse(txtStockIn.Text, out stockIn);
            int tempStock = stock + stockIn;
            txtStock.Text = tempStock.ToString();
        }
    }
}
