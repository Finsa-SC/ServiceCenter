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

namespace ServiceCenter.StockManagement
{
    public partial class StockManagementUC : UserControl
    {
        public static StockManagementUC instance;
        public SparepartManagementUC sparepartManagementUC;
        public SupplierManagementUC supplierManagementUC;
        public StockInUC stockInUC;
        public StockManagementUC()
        {
            InitializeComponent();
            instance = this;
            supplierManagementUC = new SupplierManagementUC();
            sparepartManagementUC = new SparepartManagementUC();
            stockInUC = new StockInUC();

            loadActivity(stockInUC);
        }

        private void loadActivity(UserControl uc)
        {
            pnlActivity.Controls.Clear();
            pnlActivity.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            loadActivity(supplierManagementUC);
        }

        private void btnSparepart_Click(object sender, EventArgs e)
        {
            loadActivity(sparepartManagementUC);
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            loadActivity(stockInUC);
        }
    }
}
