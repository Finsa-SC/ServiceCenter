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
    public partial class ServiceProcessUC : UserControl
    {
        public ServiceProcessUC()
        {
            InitializeComponent();
            loadData();
            addButton();
        }


        private void addButton()
        {
            if (dataGridView1.Columns.Contains("btnAction")) dataGridView1.Columns.Remove("btnAction");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Process";
            btn.HeaderText = "Action";
            btn.Name = "btnAction";
            btn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btn);
        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        s.service_code AS Code, 
                        c.full_name AS [Customer Name],
                        v.model AS Model,
                        u.username AS [Received by],
                        s.complaint AS Complaint,
                        FORMAT(s.entry_date, 'MMMM dd, yyyy') AS Entry
                    FROM service_orders s
                    JOIN customers c ON c.customer_id = s.customer_id
                    JOIN vehicles v ON v.vehicle_id = s.vehicle_id
                    LEFT JOIN users u ON u.user_id = s.received_by";

            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }

        private void ServiceProcessUC_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("Complaint")) dataGridView1.Columns["Complaint"].Width = 300;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAction")
            {

            }
        }
    }
}
