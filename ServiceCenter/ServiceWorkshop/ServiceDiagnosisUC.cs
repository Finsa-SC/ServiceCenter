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

namespace ServiceCenter.ServiceWorkshop
{
    public partial class ServiceDiagnosisUC : UserControl
    {
        public ServiceDiagnosisUC()
        {
            InitializeComponent();

            ServiceWorkshopUC.serviceWorkshopUC.setCost += () => txtSubTotal.Text = setSubtotal().ToString();
        }
        private void ServiceDiagnosisUC_Load(object sender, EventArgs e)
        {
            loadData();
            addCategorySearch();
            addButton();
            loadServiceMethod();
            txtSubTotal.Text = setSubtotal().ToString();
        }

        private void loadData()
        {
            string query = @"
                    DECLARE @sid INT;
                    DECLARE @said INT;
                    DECLARE @cid INT;
                    SELECT @sid = service_order_id, @said = assignment_id FROM service_assignments WHERE technician_id = @tid AND finished_date IS NULL;
                    SELECT @cid = customer_id FROM service_orders WHERE service_order_id = @sid;

                    SELECT 
                        @said AS assignId,
                        s.service_order_id,
                        s.service_code,
                        v.plate_number AS [Plate Number], 
                        v.brand AS Brand,
                        v.model AS Model,
                        v.year AS Year,
                        v.engine_number AS [Engine Number],
                        v.frame_number AS [Frame Number],
                        s.complaint
                    FROM service_orders s 
                    JOIN vehicles v ON s.vehicle_id = v.vehicle_id
                    WHERE s.customer_id = @cid";
            var data = DBHelper.executeReader(query, dr =>
            {
                ServiceSession.serviceOrderId = Convert.ToInt32(dr["service_order_id"]);
                ServiceSession.serviceAssignId = Convert.ToInt32(dr["assignId"]);
                txtCode.Text = dr["service_code"].ToString();
                txtPlate.Text = dr["Plate Number"].ToString();
                txtBrand.Text = dr["Brand"].ToString();
                txtModel.Text = dr["Model"].ToString();
                txtYear.Text = dr["Year"].ToString();
                txtEngine.Text = dr["Engine Number"].ToString();
                txtFrame.Text = dr["Frame Number"].ToString();
                txtComplaint.Text = dr["complaint"].ToString();
                return true;
            },
            new SqlParameter("@tid", UserSession.technicianId)
            );
        }

        private void loadServiceMethod()
        {
            string query = @"
                    SELECT 
                        s.service_id,
                        s.service_name AS Service,
                        c.category_name AS Category
                    FROM services s
                    LEFT JOIN service_categories c ON c.category_id = s.category_id
                    WHERE (@sn IS NULL OR s.service_name LIKE @sn)
                        AND (@cid IS NULL OR c.category_id = @cid)";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sn", "%" + txtSearch.Text + "%"),
                new SqlParameter("@cid", cmbCategory.SelectedValue == null ? DBNull.Value : cmbCategory.SelectedValue)
            );
            if (dataGridView1.Columns.Contains("service_id")) dataGridView1.Columns["service_id"].Visible = false;
        }
        private void addButton()
        {
            if (!dataGridView1.Columns.Contains("btn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btn";
                btn.Text = "Use";
                btn.HeaderText = "Action";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
        }

        public event Action clickMethod;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btn")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    ServiceSession.serviceId = Convert.ToInt32(row.Cells["service_id"].Value);
                    clickMethod?.Invoke();
                }
            }
        }

        private void addCategorySearch()
        {
            string query = "SELECT category_id, category_name FROM service_categories";
            var dt = DBHelper.executeQuery(query);
            var dr = dt.NewRow();
            dr["category_id"] = DBNull.Value;
            dr["category_name"] = "All Category";
            dt.Rows.InsertAt(dr, 0);
            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "category_id";
            cmbCategory.DisplayMember = "category_name";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }
        private void tmrSearchDelay_Tick(object sender, EventArgs e)
        {
            loadServiceMethod();
            tmrSearchDelay.Stop();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadServiceMethod();
        }

        public event Action finishOrder;
        private void btnFinish_Click(object sender, EventArgs e)
        {
            string query = @"
                    BEGIN TRANSACTION;
                    BEGIN TRY
                        UPDATE service_orders SET actual_finish_date = GETDATE(), total_cost = @p, status_id = 3 WHERE service_order_id = @sid
                        UPDATE service_assignments SET finished_date = GETDATE() WHERE assignment_id = @id
                        COMMIT TRANSACTION
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                    END CATCH";

            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@p", Convert.ToDecimal(txtSubTotal.Text)),
                new SqlParameter("@sid", ServiceSession.serviceOrderId),
                new SqlParameter("@id", ServiceSession.serviceAssignId)
            );
            if (i > 0)
            {
                finishOrder?.Invoke();
            }
        }

        public decimal setSubtotal()
        {
            string query = "SELECT SUM(price) FROM service_order_details WHERE service_order_id = @id";
            object result = DBHelper.executeScalar(query,
                new SqlParameter("@id", ServiceSession.serviceOrderId)
            );

            decimal total;
            decimal.TryParse(result?.ToString(), out total);
            return total;
        }
    }
}
