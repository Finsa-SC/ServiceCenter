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
    u.username,
    s.total_cost AS Cost,
    s.actual_finish_date AS [Finished At]
FROM service_orders s 
JOIN service_assignments a ON a.service_order_id = s.service_order_id
JOIN vehicles v ON v.vehicle_id = s.vehicle_id
JOIN customers c ON c.customer_id = s.customer_id
JOIN vehicle_brands b ON b.brand_id = s.brand_id
JOIN technicians t ON t.technician_id = a.technician_id
JOIN users u ON u.user_id = t.user_id
WHERE (@cn IS NULL OR c.full_name LIKE @cn)
AND (@b IS NULL OR b.brand_id = @b)
AND (@dt IS NULL OR CAST(s.actual_finish_date AS DATE) = @dt)
";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@cn", "%" + txtSCustomer.Text + "%"),
                new SqlParameter("@b", cmbSBrand.SelectedValue == null ? DBNull.Value : cmbSBrand.SelectedValue),
                new SqlParameter("@dt", dteSDate.Enabled? dteSDate.Value: DBNull.Value)
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

        private void chkDte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDte.Checked) dteSDate.Enabled = true;
            else dteSDate.Enabled = true;
        }
    }
}
