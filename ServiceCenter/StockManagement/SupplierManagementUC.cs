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
using Microsoft.Data.SqlClient;

namespace ServiceCenter.StockManagement
{
    public partial class SupplierManagementUC : UserControl
    {
        public SupplierManagementUC()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = @"
                    SELECT 
                        supplier_id, supplier_name AS Supplier, phone, address 
                    FROM suppliers 
                    WHERE (@sn IS NULL OR supplier_name LIKE @sn)
                        OR (@sn IS NULL OR address LIKE @sn)";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sn", "%" + txtSearch.Text + "%")
            );
            dataGridView1.Columns["supplier_id"].Visible = false;
        }

        private int supplierId = 0;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierId = Convert.ToInt32(row.Cells["supplier_id"].Value);
                txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }
        private void clear()
        {
            txtAddress.Clear();
            txtPhone.Clear();
            txtSupplier.Clear();
            supplierId = 0;
        }

        public event Action updateData;
        private void btnAdd_Click(object sender, EventArgs e)
        {if (ValidationHelper.isNullInput(this, out string message))
            {
                UIHelper.toast("Invalid Input", message);
                return;
            }

            if (existData()) { UIHelper.toast("Update Failed", "Exists data in DataBase"); return; }
            if (ValidationHelper.checkPhone(txtPhone.Text)) return;
            string query = "INSERT INTO suppliers (supplier_name, phone, address) VALUES (@n, @p, @a)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@n", txtSupplier.Text),
                new SqlParameter("@p", txtPhone.Text),
                new SqlParameter("@a", txtAddress.Text)
            );
            if (i > 0)
            {
                UIHelper.toast("Sucess", "Success Adding New Supplier");
                loadData();
                clear();
                updateData?.Invoke();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (supplierId <= 0) { UIHelper.toast("no choice yet", "Please Select Supplier First"); return; }
            if (ValidationHelper.isNullInput(this, out string message))
            {
                UIHelper.toast("Invalid Input", message);
                return;
            }
            if (ValidationHelper.checkPhone(txtPhone.Text)) return;
            if (existData()) { UIHelper.toast("Update Failed", "Exists data in DataBase"); return; }

            string query = "UPDATE suppliers SET supplier_name = @n, phone = @p, address = @a WHERE supplier_id = @sid";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@n", txtSupplier.Text),
                new SqlParameter("@p", txtPhone.Text),
                new SqlParameter("@a", txtAddress.Text),
                new SqlParameter("@sid", supplierId)
            );
            if (i > 0)
            {
                UIHelper.toast("Sucess", "Success Updating Supplier");
                loadData();
                clear();
                updateData?.Invoke();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private bool existData()
        {
            string query = "SELECT 1 FROM suppliers WHERE supplier_name = @n OR phone = @p";
            int i = Convert.ToInt32(DBHelper.executeScalar(query,
                new SqlParameter("@n", txtSupplier.Text),
                new SqlParameter("@p", txtPhone.Text)
            ));
            if (i == 1)
            {
                return true;
            }
            return false;
        }

        private void txtSSupplier_TextChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }
        private void tmrSupplier_Tick(object sender, EventArgs e)
        {
            loadData();
            tmrSearchDelay.Stop();
        }
    }
}
