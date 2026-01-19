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
    public partial class OrderHistoryUC : UserControl
    {
        public OrderHistoryUC()
        {
            InitializeComponent();
        }
        private void OrderHistoryUC_Load(object sender, EventArgs e)
        {
            loadBrand();
            loadData();
            addButton();
        }
        private void loadData()
        {
            string query = @"
                    SELECT
                        s.service_order_id AS id,
                        s.service_code AS Code,
                        c.full_name AS Customer,
                        b.brand_name AS Brand,
                        v.model AS Vehicle,
                        u.username AS Technician,
                        s.total_cost AS Cost,
                        s.actual_finish_date AS [Finished At]
                    FROM service_orders s 
                    JOIN service_assignments a ON a.service_order_id = s.service_order_id
                    JOIN vehicles v ON v.vehicle_id = s.vehicle_id
                    JOIN customers c ON c.customer_id = s.customer_id
                    JOIN vehicle_brands b ON b.brand_id = v.brand_id
                    JOIN technicians t ON t.technician_id = a.technician_id
                    JOIN users u ON u.user_id = t.user_id
                    WHERE (c.full_name LIKE @cn OR @cn IS NULL)
                    AND (b.brand_id = @b OR @b IS NULL)
                    AND (CAST(s.actual_finish_date AS DATE) = CAST(@dt AS DATE) OR @dt IS NULL)
                    AND s.status_id = 4";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@cn", "%" + txtSCustomer.Text + "%"),
                new SqlParameter("@b", cmbSBrand.SelectedValue == null ? DBNull.Value : cmbSBrand.SelectedValue),
                new SqlParameter("@dt", chkDte.Checked ? dteSDate.Value : DBNull.Value)
            );
        }
        private void loadBrand()
        {
            string query = "SELECT brand_id, brand_name FROM vehicle_brands";
            DataTable dt = DBHelper.executeQuery(query);
            var dr = dt.NewRow();
            dr["brand_id"] = DBNull.Value;
            dr["brand_name"] = "All Brand";
            dt.Rows.InsertAt(dr, 0);
            cmbSBrand.DataSource = dt;
            cmbSBrand.DisplayMember = "brand_name";
            cmbSBrand.ValueMember = "brand_id";
        }
        private void addButton()
        {
            if (dataGridView1.Columns.Contains("btnAction")) return;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnAction";
            btn.HeaderText = "Action";
            btn.Text = "Detail";
            btn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btn);
        }

        private void txtSCustomer_TextChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }

        private void cmbSBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }

        private void dteSDate_ValueChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }
        private void chkDte_CheckedChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }

        private void tmrSearchDelay_Tick(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    int sid = Convert.ToInt32(row.Cells["id"].Value);
                    OrderDetailForm form = new OrderDetailForm(sid);
                    form.ShowDialog();
                    loadData();
                }
            }
        }
    }
}
