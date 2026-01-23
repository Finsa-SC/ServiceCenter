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
using System.Data.SqlClient;

namespace ServiceCenter.ServiceHistory
{
    public partial class TechnicianPerformanceUC : UserControl
    {
        public TechnicianPerformanceUC()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = @"
                    SELECT 
                    u.username AS Technician,
                    COUNT (sa.assignment_id) AS [Service Completed],
                    SUM (DATEDIFF(MINUTE, sa.assigned_date, sa.finished_date)) AS [Hour Working],
                    COUNT (sa.finished_date) AS [Order Completed]
                    FROM technicians t 
                    JOIN users u ON u.user_id = t.user_id
                    LEFT JOIN service_assignments sa ON sa.technician_id = t.technician_id
                    GROUP BY u.username";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }
    }
}
