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
using Microsoft.Data.SqlClient;

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
DECLARE @totalService INT;
SELECT @totalService = COUNT(*) FROM service_assignments WHERE technician_id = @tid;

DECLARE @totalTime DATETIME;
SELECT @totalTime = DATEDIFF(HOUR, assigned_date, finished_date) FROM service_assignments WHERE finished_date IS NOT NULL AND technician_id = @tid;

DECLARE @totalOrder INT;
SELECT @totalOrder = COUNT(*) FROM service_assignments WHERE finished_date IS NOT NULL AND technician_id = @tid;

SELECT 
u.username AS Technician,
@totalService AS [Number of Service],
@totalTime AS [Working Hours],
@totalOrder AS [Order Complete]
FROM users u
JOIN technicians t ON t.user_id = u.user_id
";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@tid", )
            );
        }
    }
}
