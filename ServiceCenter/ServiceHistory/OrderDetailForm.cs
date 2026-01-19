using ServiceCenter.core.network;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.ServiceHistory
{
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm(int serviceId)
        {
            InitializeComponent();
            loadSparepart(serviceId);
        }

        private void loadSparepart(int service_id)
        {
            string query = @"
                    SELECT 
                        s.sparepart_code AS Code,
                        s.sparepart_name AS Name,
                        u.quantity AS Quantity,
                        u.price AS Price
                    FROM spareparts s
                    JOIN sparepart_usage u ON u.sparepart_id = s.sparepart_id
                    WHERE u.service_order_id = @sid";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sid", service_id)
            );
        }
        private void loadService()
        {
            string query = @"
SELECT 

";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
