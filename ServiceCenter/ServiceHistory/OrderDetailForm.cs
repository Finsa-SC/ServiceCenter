using ServiceCenter.core.network;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ServiceCenter.ServiceHistory
{
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm(int serviceId)
        {
            InitializeComponent();
            loadSparepart(serviceId);
            loadService(serviceId);
            setProperty(serviceId);
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
        private void loadService(int service_id)
        {
            string query = @"
                    SELECT 
                        c.category_name AS Category,
                        s.service_name AS Service
                    FROM services s
                    JOIN service_categories c ON c.category_id = s.category_id
                    JOIN service_order_details sod ON sod.service_id = s.service_id
                    JOIN service_orders sd ON sd.service_order_id = sod.service_order_id
                    WHERE sd.service_order_id = @sid";
            dataGridView2.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sid", service_id)
            );
        }

        private void setProperty(int service_id)
        {
            string query = @"
                    SELECT 
                        entry_date,
                        actual_finish_date,
                        DATEDIFF(HOUR, entry_date, actual_finish_date) AS time,
                        total_cost,
                        complaint
                    FROM service_orders
                    WHERE service_order_id = @sid"; 
            var i = DBHelper.executeReader(query, dr =>
                {
                    dteEntry.Value = Convert.ToDateTime(dr["entry_date"]);
                    dteFinish.Value = Convert.ToDateTime(dr["actual_finish_date"]);
                    txtProcesing.Text = dr["time"].ToString() + " Hours";
                    txtCost.Text = dr["total_cost"].ToString();
                    txtComplaint.Text = dr["complaint"].ToString();
                    return true;
                },
                new SqlParameter("@sid", service_id)
            );
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
