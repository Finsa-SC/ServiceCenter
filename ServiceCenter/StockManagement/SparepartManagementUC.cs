using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.StockManagement
{
    public partial class SparepartManagementUC : UserControl
    {
        private int sparepartId = 0;
        public SparepartManagementUC()
        {
            InitializeComponent();
            loadData();
            loadSupplier();
            cmbSupplier.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;

            StockManagementUC.instance.supplierManagementUC.updateData += () => loadSupplier();
        }

        private void loadData()
        {
            string query = @"
                    SELECT 
                        s.sparepart_id, 
                        s.sparepart_code AS Code,
                        s.sparepart_name AS Name,
                        sp.supplier_name AS [Supplier],
                        s.stock AS Stock,
                        s.unit AS Unit,
                        s.minimum_stock AS [Minimum Stock],
                        p.purchase_price AS Purchase,
                        p.selling_price AS Selling,
                        p.effective_date AS [Effective Date]
                    FROM spareparts s
                    JOIN sparepart_price p ON p.sparepart_id = s.sparepart_id
                    JOIN suppliers sp ON sp.supplier_id = p.supplier_id";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
            dataGridView1.Columns["sparepart_id"].Visible = false;
        }
        private void loadSupplier()
        {
            string query = "SELECT supplier_id, supplier_name FROM suppliers";
            cmbSupplier.DataSource = DBHelper.executeQuery(query);
            cmbSupplier.ValueMember = "supplier_id";
            cmbSupplier.DisplayMember = "supplier_name";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                sparepartId = Convert.ToInt32(row.Cells["sparepart_id"].Value);
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtPrice.Text = row.Cells["Purchase"].Value.ToString();
                txtSelling.Text = row.Cells["Selling"].Value.ToString();
                txtSparepart.Text = row.Cells["Name"].Value.ToString();
                cmbSupplier.SelectedIndex = cmbSupplier.FindStringExact(row.Cells["Supplier"].Value.ToString());
                cmbUnit.SelectedIndex = cmbUnit.FindStringExact(row.Cells["Unit"].Value.ToString());
                nmcStock.Value = Convert.ToInt32(row.Cells["Stock"].Value);
                nmcMinimum.Value = Convert.ToInt32(row.Cells["Minimum Stock"].Value);
                dteEffective.Value = Convert.ToDateTime(row.Cells["Effective Date"].Value);
            }
        }
        private void clear()
        {
            txtCode.Clear();
            txtPrice.Clear();
            txtSelling.Clear();
            txtSparepart.Clear();
            cmbSupplier.SelectedIndex = -1;
            nmcMinimum.Value = 0;
            nmcStock.Value = 0;
            dteEffective.Value = DateTime.UtcNow;
            sparepartId = 0;
            cmbUnit.SelectedIndex = -1;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        //Button
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

       
    }
}
