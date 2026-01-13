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
    public partial class ServiceAssessmentUC : UserControl
    {
        int serviceId;
        BindingList<CartModel> cart = new BindingList<CartModel>();
        public ServiceAssessmentUC(int serviceID)
        {
            InitializeComponent();
            loadSparepart();
            dgvCart.DataSource = cart;
            serviceId = serviceID;
        }


        private void dgvSparePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSparePart.Rows[e.RowIndex];
                string code = row.Cells["Sparepart Code"].Value.ToString();
                string name = row.Cells["Sparepart"].Value.ToString();
                string unit = row.Cells["Unit"].Value.ToString();
                if (dgvSparePart.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    string query = "UPDATE spareparts SET stock = stock - 1 WHERE sparepart_id = @sid";
                    int i = DBHelper.executeNonQuery(query,
                        new SqlParameter("@sid", Convert.ToInt32(row.Cells["sparepart_id"].Value))
                    );
                    if (i > 0)
                    {
                        var itemExist = cart
                            .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);
                        if (itemExist != null)
                        {
                            itemExist.stock += 1;
                            dgvCart.Refresh();
                            loadSparepart();
                            return;
                        }
                        cart.Add(new CartModel { sparepartCode = code, sparepartName = name, stock = 1, unit = unit });
                        dgvCart.Refresh();
                        loadSparepart();
                    }
                    addButtonReturn();
                }
            }
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && dgvCart.Columns[e.ColumnIndex].Name == "btnAction")
            {
                DataGridViewRow row = dgvCart.Rows[e.RowIndex];
                string code = row.Cells["sparepartCode"].Value.ToString();
                string name = row.Cells["sparepartName"].Value.ToString();
                string unit = row.Cells["unit"].Value.ToString();
                var item = cart
                    .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);
                if (item.stock <= 1)
                {
                    cart.Remove(item);
                }
                item.stock -= 1;
                dgvCart.Refresh();
            }
        }

        private void addButtonReturn()
        {
            if (dgvCart.Columns.Contains("btnAction")) return;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnAction";
            btn.HeaderText = "Action";
            btn.Text = "Return";
            btn.UseColumnTextForButtonValue = true;

            dgvCart.Columns.Add(btn);
        }
        private void addButtonUse()
        {
            if (!dgvSparePart.Columns.Contains("btnAction"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Use";
                btn.HeaderText = "Action";
                btn.Name = "btnAction";
                btn.UseColumnTextForButtonValue = true;
                dgvSparePart.Columns.Add(btn);
            }
        }
        private void loadSparepart()
        {
            string query = @"
                    SELECT 
                        sparepart_id,
                        sparepart_code AS [Sparepart Code], 
                        sparepart_name AS [Sparepart],
                        stock AS Stock,
                        unit AS Unit
                    FROM spareparts 
                    WHERE stock > 0";
            dgvSparePart.DataSource = DBHelper.executeQuery(query);
            addButtonUse();
        }

    }
}
