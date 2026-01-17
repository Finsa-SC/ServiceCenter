using ServiceCenter.core.network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class ServicePaymentUC : UserControl
    {
        public ServicePaymentUC()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = @"
                    SELECT
                        o.service_code AS [Service Code],
                        c.full_name AS [Customer Name],
                        v.model AS Model,
                        s.status_name AS Status,
                        o.actual_finish_date AS [Finished At],
                        o.total_cost,
                        u.username AS [Assigned By]
                    FROM service_orders o
                    JOIN customers c ON o.customer_id = c.customer_id
                    JOIN vehicles v ON o.vehicle_id = v.vehicle_id
                    JOIN service_status s ON s.status_id = o.status_id
                    JOIN users u ON o.assigned_by = u.user_id
                    WHERE o.status_id = 3";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }
    }
}
