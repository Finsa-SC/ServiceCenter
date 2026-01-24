using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using Microsoft.Data.SqlClient;
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
            StockManagementUC.instance.supplierManagementUC.updateData += () => { loadSupplier(); loadData(); };
        }
        private void SparepartManagementUC_Load(object sender, EventArgs e)
        {
            loadcmbSearch(cmbUnit, false);
            loadcmbSearch(cmbSUnit, true);
            cmbUnit.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            cmbSUnit.SelectedIndex = 0;
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
                        u.unit_name AS Unit,
                        s.minimum_stock AS [Minimum Stock],
                        p.purchase_price AS Purchase,
                        p.selling_price AS Selling,
                        p.effective_date AS [Effective Date]
                    FROM spareparts s
                    JOIN sparepart_price p ON p.sparepart_id = s.sparepart_id
                    JOIN suppliers sp ON sp.supplier_id = p.supplier_id
                    JOIN sparepart_unit u ON u.unit_id = s.unit_id
                    WHERE (@sn IS NULL OR s.sparepart_name LIKE @sn)
                        AND (@su IS NULL OR sp.supplier_name LIKE @su)
                        AND (@u IS NULL OR s.unit_id = @u)";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sn", "%" + txtSSparepart.Text + "%"),
                new SqlParameter("@su", "%" + txtSSupplier.Text + "%"),
                new SqlParameter("@u", cmbSUnit.SelectedValue == null ? DBNull.Value : cmbSUnit.SelectedValue)
            );
            if (dataGridView1.Columns.Contains("sparepart_id")) dataGridView1.Columns["sparepart_id"].Visible = false;
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
            pnlButton.Visible = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        //Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clear();
            txtCode.Text = CodeGenerator.codeGenerator("SP", "SELECT MAX(sparepart_code) FROM spareparts");
            pnlButton.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.isNullInput(this, out string message))
            {
                UIHelper.toast("Invalid Input", message);
                return;
            }
            string query = @"
                    BEGIN TRANSACTION;
                    BEGIN TRY
                        UPDATE spareparts SET sparepart_name = @sn, unit = @su, stock = @ss, minimum_stock = @sm WHERE sparepart_id = @sid;
                        UPDATE sparepart_price SET supplier_id = @pi, purchase_price = @pp, selling_price = @ps, effective_date = @pe WHERE sparepart_id = @sid;
                        COMMIT TRANSACTION;
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                    END CATCH";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@sn", txtSparepart.Text),
                new SqlParameter("@su", cmbUnit.SelectedItem),
                new SqlParameter("@ss", nmcStock.Value),
                new SqlParameter("@sm", nmcMinimum.Value),
                new SqlParameter("@pi", cmbSupplier.SelectedValue),
                new SqlParameter("@pp", Convert.ToDecimal(txtPrice.Text)),
                new SqlParameter("@ps", Convert.ToDecimal(txtSelling.Text)),
                new SqlParameter("@pe", dteEffective.Value),
                new SqlParameter("@sid", sparepartId)
            );

            if (i > 0)
            {
                clear();
                loadData();
                UIHelper.toast("Sucess", "Success Updating Sparepart");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            pnlButton.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdds_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.isNullInput(this, out string message))
                        {
                            UIHelper.toast("Invalid Input", message);
                            return;
                        }
            string query = @"
                    BEGIN TRANSACTION;
                    BEGIN TRY
                        DECLARE @sid INT;
                        INSERT INTO spareparts (sparepart_code, sparepart_name, unit, stock, minimum_stock) VALUES (@sc, @sn, @su, @ss, @sm);
                        SET @sid = SCOPE_IDENTITY();
                        INSERT INTO sparepart_price (sparepart_id, supplier_id, purchase_price, selling_price, effective_date) VALUES (@sid, @pi, @pp, @ps, @pe);
                        COMMIT TRANSACTION;
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                        THROW;
                    END CATCH";

            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@sc", txtCode.Text),
                new SqlParameter("@sn", txtSparepart.Text),
                new SqlParameter("@su", cmbUnit.SelectedItem),
                new SqlParameter("@ss", nmcStock.Value),
                new SqlParameter("@sm", nmcMinimum.Value),
                new SqlParameter("@pi", cmbSupplier.SelectedValue),
                new SqlParameter("@pp", Convert.ToDecimal(txtPrice.Text)),
                new SqlParameter("@ps", Convert.ToDecimal(txtSelling.Text)),
                new SqlParameter("@pe", dteEffective.Value)
            );
            if (i > 0)
            {
                clear();
                loadData();
                UIHelper.toast("Sucess", "Success Adding Sparepart");
            }
        }

        private void txtSSparepart_TextChanged(object sender, EventArgs e)
        {
            tmrSpareDelay.Stop();
            tmrSpareDelay.Start();
        }

        private void txtSSupplier_TextChanged(object sender, EventArgs e)
        {
            tmrSupDelay.Stop();
            tmrSupDelay.Start();
        }

        private void tmrSparepart_Tick(object sender, EventArgs e)
        {
            loadData();
            tmrSpareDelay.Stop();
        }

        private void tmrSupDelay_Tick(object sender, EventArgs e)
        {
            loadData();
            tmrSupDelay.Stop();
        }

        //cmb value
        private void loadcmbSearch(ComboBox box, bool searchMode)
        {
            string query = "SELECT unit_id, unit_name FROM sparepart_unit";
            DataTable dt = DBHelper.executeQuery(query);
            if (searchMode)
            {
                var dr = dt.NewRow();
                dr["unit_id"] = DBNull.Value;
                dr["unit_name"] = "All Unit";
                dt.Rows.InsertAt(dr, 0);
            }
            box.DataSource = dt;
            box.ValueMember = "unit_id";
            box.DisplayMember = "unit_name";
        }
        private void cmbSUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
