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
        List<SparepartModel> sparepart;
        public ServiceAssessmentUC(int serviceID)
        {
            InitializeComponent();
            dgvCart.DataSource = cart;
            serviceId = serviceID;
            loadSparepart();
        }


        private void loadSparepart()
        {
            string query = @"
                    SELECT 
                        s.sparepart_code, 
                        s.sparepart_name, 
                        s.stock, 
                        s.unit,
                        p.selling_price
                    FROM spareparts s
                    JOIN sparepart_price p ON s.sparepart_id = p.sparepart_id";
            sparepart =
               DBHelper.executeReader(query, dr => new SparepartModel
               {
                   sparepartCode = dr["sparepart_code"].ToString(),
                   sparepartName = dr["sparepart_name"].ToString(),
                   stock = Convert.ToInt32(dr["stock"]),
                   unit = dr["unit"].ToString(),
                   price = Convert.ToDecimal(dr["selling_price"])
               }
               );

            dgvSparePart.DataSource = new BindingList<SparepartModel>(sparepart);
            addButtonUse();
        }
        private void dgvSparePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSparePart.Rows[e.RowIndex];
                string code = row.Cells["sparepartCode"].Value.ToString();
                string name = row.Cells["sparepartName"].Value.ToString();
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                string unit = row.Cells["unit"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                if (dgvSparePart.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    //decrese stock
                    var item = sparepart
                        .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);

                    item.stock--;
                    if (item.stock <= 0)
                    {
                        sparepart.Remove(item);
                    }
                    dgvSparePart.Refresh();

                    //add to cart
                    var itemExist = cart
                            .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);
                    if (itemExist != null)
                    {
                        itemExist.qty += 1;
                        dgvCart.Refresh();
                        return;
                    }
                    cart.Add(new CartModel { sparepartCode = code, sparepartName = name, qty = 1, unit = unit, unitPrice = price });
                    dgvCart.Refresh();

                    addButtonReturn();
                }
            }
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "btnAction")
            {
                DataGridViewRow row = dgvCart.Rows[e.RowIndex];
                string code = row.Cells["sparepartCode"].Value.ToString();
                string name = row.Cells["sparepartName"].Value.ToString();
                //decrese from cart
                var item = cart
                    .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);
                if (item.qty <= 1)
                {
                    cart.Remove(item);
                }
                item.qty -= 1;
                dgvCart.Refresh();

                //give back to sparepart 
                var spare = sparepart
                    .FirstOrDefault(u => u.sparepartCode == code && u.sparepartName == name);
                if (spare != null)
                {
                    spare.stock++;
                    dgvSparePart.Refresh();
                }
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

        private void chkPrice_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPrice.Checked)
            {
                if (dgvCart.Columns.Contains("price")) dgvCart.Columns["price"].Visible = false;
                if (dgvSparePart.Columns.Contains("price")) dgvSparePart.Columns["price"].Visible = false;
            }
            else
            {
                
                if (dgvCart.Columns.Contains("Price")) dgvCart.Columns["Price"].Visible = true;
                if (dgvSparePart.Columns.Contains("price")) dgvSparePart.Columns["Price"].Visible = true;
            }
        }
    }
}
