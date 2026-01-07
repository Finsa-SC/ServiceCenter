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

namespace ServiceCenter.ServiceOrder
{
    public partial class ServiceOrdersUC : UserControl
    {
        public ServiceOrdersUC()
        {
            InitializeComponent();
            loadUC(new AddOrderUC());
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
            loadUC(new AddCustomerUC(txtCustomerSearch.Text));
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            loadUC(new AddVehicleUC());
        }

        private void addButtonUse(DataGridView dgv)
        {
            if (dgv.Columns.Contains("btnUse")) return;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "USE";
            img.Name = "btnUse";
            img.Image = Properties.Resources.icons8_choose_58;
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv.Columns.Add(img);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            img.Width = 50;
        }
        private void loadCustomer()
        {
            string query = "SELECT customer_id, full_name AS [Full Name], phone AS Phone, email AS Email FROM customers WHERE full_name LIKE @c";
            dgvCustomer.DataSource = DBHelper.executeQuery(query, new SqlParameter("@c", "%" + txtCustomerSearch.Text + "%"));
            if (dgvCustomer.Columns.Contains("customer_id")) dgvCustomer.Columns["customer_id"].Visible = false;
            addButtonUse(dgvCustomer);
        }
        private void loadVehicle(int cid)
        {
            string query = "SELECT vehicle_id, brand AS Brand, model AS Model, plate_number AS [Plate Number] FROM vehicles WHERE model LIKE @m AND customer_id = @c";
            dgvVehicle.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@m", "%" + txtVehicleSearch.Text + "%"),
                new SqlParameter("@c", cid)
            );
            if (dgvVehicle.Columns.Contains("vehicle_id")) dgvVehicle.Columns["vehicle_id"].Visible = false;
            addButtonUse(dgvVehicle);
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
            loadCustomer();
        }

        private void tmrVehicleDelay_Tick(object sender, EventArgs e)
        {
            tmrVehicleDelay.Stop();
            loadVehicle(customerID);
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
                }
            }
        }

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCustomer.Columns[e.ColumnIndex].Name == "btnUse")
                {
                    DataGridViewRow row = dgvVehicle.Rows[e.RowIndex];
                    txtVehicleSearch.Text = row.Cells["Model"].ToString();
                    vehicleID = Convert.ToInt32(row.Cells["vehicle_id"].Value);
                    dgvVehicle.DataSource = null;
                }
            }
        }
    }
}
