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
    public partial class AddVehicleUC : UserControl
    {
        int customerId;
        public event Action vehicleAdded;
        public AddVehicleUC(string model, int cusId)
        {
            InitializeComponent();
            txtMode.Text = model;
            loadYear();
            customerId = cusId;
            loadBrand();
        }

        private void loadYear()
        {
            cmbYears.Items.Clear();
            for (int years = DateTime.Now.Year; years >= 1880; years--)
            {
                cmbYears.Items.Add(years);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO vehicles (customer_id, plate_number, brand_id, model, year, engine_number, frame_number) VALUES (@c, @p, @b, @m, @y, @e, @f)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@c", customerId),
                new SqlParameter("@p", txtPlat.Text.Trim()),
                new SqlParameter("@b", cmbBrand.SelectedValue),
                new SqlParameter("@m", txtMode.Text.Trim()),
                new SqlParameter("@y", cmbYears.SelectedItem),
                new SqlParameter("@e", txtEng.Text.Trim()),
                new SqlParameter("@f", txtFrm.Text.Trim())
            );
            if (i > 0)
            {
                UIHelper.toast("Sucess", "Success Adding Vehicle");
                vehicleAdded?.Invoke();
            }
        }

        private void loadBrand()
        {
            string query = "SELECT brand_id, brand_name FROM vehicle_brand";
            DataTable dt = DBHelper.executeQuery(query);
            var dr = dt.NewRow();
            dr["brand_id"] = DBNull.Value;
            dr["brand_name"] = "All Brand";
            dt.Rows.InsertAt(dr, 0);
            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "brand_name";
            cmbBrand.ValueMember = "brand_id";
        }
    }
}
