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

namespace ServiceCenter.ServiceOrder
{
    public partial class ServiceOrdersUC : UserControl
    {
        public ServiceOrdersUC()
        {
            InitializeComponent();
            btnAddVehicle.Enabled = false;
        }
        private int customerID = 0;
        private int vehicleID = 0;

        private void loadUC(UserControl uc)
        {
            pnlAct.Controls.Clear();
            pnlAct.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var AddCustomer = new AddCustomerUC(txtCustomerSearch.Text);
            AddCustomer.customerAdded += () =>
            {
                loadCustomer();
                pnlAct.Controls.Clear();
            };
            loadUC(AddCustomer);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var AddVehicle = new AddVehicleUC(txtVehicleSearch.Text, customerID);
            AddVehicle.vehicleAdded += () =>
            {
                loadVehicle(customerID);
                pnlAct.Controls.Clear();
            };
            loadUC(AddVehicle);
        }

        private void addButtonUse(DataGridView dgv)
        {
            if (dgv.Columns.Contains("btnUse")) dgv.Columns.Remove("btnUse");
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "USE";
            img.Name = "btnUse";
            img.Image = Properties.Resources.icons8_choose_58;
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv.Columns.Add(img);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            img.Width = 50;
        }
        public void loadCustomer()
        {
            string query = "SELECT customer_id, full_name AS [Full Name], phone AS Phone, email AS Email FROM customers WHERE full_name LIKE @c";
            dgvCustomer.DataSource = DBHelper.executeQuery(query, new SqlParameter("@c", "%" + txtCustomerSearch.Text + "%"));
            if (dgvCustomer.Columns.Contains("customer_id")) dgvCustomer.Columns["customer_id"].Visible = false;
            addButtonUse(dgvCustomer);
        }
        public void loadVehicle(int cid)
        {
            string query = "SELECT vehicle_id, brand AS Brand, model AS Model, plate_number AS [Plate Number] FROM vehicles WHERE model LIKE @m AND customer_id = @c";
            dgvVehicle.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@m", "%" + txtVehicleSearch.Text + "%"),
                new SqlParameter("@c", cid)
            );
            addButtonUse(dgvVehicle);
            if (dgvVehicle.Columns.Contains("vehicle_id")) dgvVehicle.Columns["vehicle_id"].Visible = false;

            dgvVehicle.ClearSelection();
        }


        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            tmrCustomerDelay.Stop();
            tmrCustomerDelay.Start();
        }

        private void txtVehicleSearch_TextChanged(object sender, EventArgs e)
        {
            tmrVehicleDelay.Stop();
            tmrVehicleDelay.Start();
        }
        private void tmrCustomerDelay_Tick(object sender, EventArgs e)
        {
            tmrCustomerDelay.Stop();
            if (!string.IsNullOrWhiteSpace(txtCustomerSearch.Text)) loadCustomer();

        }

        private void tmrVehicleDelay_Tick(object sender, EventArgs e)
        {
            tmrVehicleDelay.Stop();
            if (!string.IsNullOrWhiteSpace(txtVehicleSearch.Text)) loadVehicle(customerID);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                if (dgvCustomer.Columns[e.ColumnIndex].Name == "btnUse")
                {
                    txtCustomerSearch.Text = row.Cells["Full Name"].Value.ToString();
                    customerID = Convert.ToInt32(row.Cells["customer_id"].Value);
                    txtCustomerSearch.Enabled = false;
                    dgvCustomer.DataSource = null;
                    loadVehicle(customerID);
                    txtVehicleSearch.Enabled = true;
                    btnAddVehicle.Enabled = true;
                }
            }
        }

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvVehicle.Columns[e.ColumnIndex].Name == "btnUse")
                {
                    DataGridViewRow row = dgvVehicle.Rows[e.RowIndex];
                    txtVehicleSearch.Text = row.Cells["Model"].Value.ToString();
                    vehicleID = Convert.ToInt32(row.Cells["vehicle_id"].Value);
                    dgvVehicle.DataSource = null;
                }
            }
        }

        private void clear()
        {
            txtCustomerSearch.Clear();
            txtCustomerSearch.Enabled = true;
            txtVehicleSearch.Enabled = false;
            txtVehicleSearch.Clear();
            txtIssue.Text = null;
            dteEstimate.Value = DateTime.Now;
            dgvCustomer.DataSource = null;
            dgvVehicle.DataSource = null;
            btnAddVehicle.Enabled = false;
            dteEstimate.Value = DateTime.Now;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string code = CodeGenerator.codeGenerator("SV", "SELECT MAX(service_code) FROM service_orders");
            if (string.IsNullOrWhiteSpace(txtIssue.Text)) { UIHelper.toast("Emty Input", "Issue Could'nt be Emty"); return; }
            string query = "INSERT INTO service_orders (service_code, customer_id, vehicle_id, status_id, received_by, complaint, entry_date, estimated_finish_date) " +
                "VALUES (@co, @c, @v, 1, @r, @cm, GETDATE(), @e)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@co", code),
                new SqlParameter("@c", customerID),
                new SqlParameter("@v", vehicleID),
                new SqlParameter("@r", UserSession.userId),
                new SqlParameter("@cm", txtIssue.Text),
                new SqlParameter("@e", dteEstimate.Value)
            );
            if (i > 0) UIHelper.toast("Success", "Success Received Vehicles, Waiting for Process");
            clear();
            pnlAct.Controls.Clear();
        }
    }
}
