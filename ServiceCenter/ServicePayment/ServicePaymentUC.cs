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

namespace ServiceCenter
{
    public partial class ServicePaymentUC : UserControl
    {
        public ServicePaymentUC()
        {
            InitializeComponent();
            loadData();
            cmbMethod.SelectedIndex = 0;
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
                        o.total_cost AS [Total Cost],
                        u.username AS [Assigned By]
                    FROM service_orders o
                    JOIN customers c ON o.customer_id = c.customer_id
                    JOIN vehicles v ON o.vehicle_id = v.vehicle_id
                    JOIN service_status s ON s.status_id = o.status_id
                    JOIN users u ON o.assigned_by = u.user_id
                    WHERE o.status_id = 3";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTotal.Text = row.Cells["Total Cost"].Value.ToString();
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaid.Text)) return;
            decimal total = Convert.ToDecimal(txtTotal.Text);
            decimal paid = Convert.ToDecimal(txtPaid.Text);
            if (paid > total)
            {
                string change = (total - paid).ToString().Replace("-", "");
                txtChange.Text = change.ToString();
            }
            else txtChange.Clear();

        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txtPaid.Text) < Convert.ToDecimal(txtTotal.Text))
            {
                UIHelper.toast("Not Enaugh Money", "Paid is less than Total Cost");
                return;
            }
        }
    }
}

