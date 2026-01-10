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
using ServiceCenter.core.util;

namespace ServiceCenter.ServiceProcess
{
    public partial class FreeTechnicianForm : Form
    {
        int serviceID;
        public FreeTechnicianForm(int service)
        {
            InitializeComponent();
            loadData();
            addButton();
            serviceID = service;
        }

        private void loadData()
        {
            string query = @"
                    SELECT 
                        t.technician_id,
                        u.username AS Technician,
                        t.skill_level AS [Skill Level]
                    FROM technicians t
                    JOIN users u ON u.user_id = t.user_id
                    WHERE NOT EXISTS (SELECT 1 FROM service_assignments WHERE technician_id = t.technician_id AND finished_date IS NULL)
";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton()
        {
            if (dataGridView1.Columns.Contains("btnAction")) return;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "employ";
            btn.HeaderText = "Action";
            btn.Name = "btnAction";
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 10;

            dataGridView1.Columns.Add(btn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    if (!UIHelper.ConfirmationDialog("Assign Order", "Are you sure to apply this order?")) return;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int techID = Convert.ToInt32(row.Cells["technician_id"].Value);
                    string query = @"
BEGIN TRANSACTION;
BEGIN 
INSERT INTO 
    service_assignments (service_order_id, technician_id, assigned_date) 
VALUES (@s, @t, GETDATE())
BEGIN
    UPDATE
    service_order SET status_id = 2 WHERE service_order_id = @s
END
";
                    int i = DBHelper.executeNonQuery(query,
                        new SqlParameter("@s", serviceID),
                        new SqlParameter("@t", techID)
                    );
                    if (i > 0)
                    {
                        UIHelper.toast("Success", "Success Assign Order");
                        this.Close();
                    }
                }
            }
        }

        private void FreeTechnicianForm_Load(object sender, EventArgs e)
        {
            if(dataGridView1.Columns.Contains("technician_id")) dataGridView1.Columns["technician_id"].Visible = false;
        }
    }
}
