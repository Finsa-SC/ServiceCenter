using Microsoft.Data.SqlClient;
using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace ServiceCenter.ServiceWorkshop
{
    public partial class ServiceAssessmentUC : UserControl
    {
        int serviceId;
        int serviceOrderId;
        BindingList<CartModel> cart = new BindingList<CartModel>();
        List<SparepartModel> sparepart;
        public ServiceAssessmentUC(int serviceID, int serviceOrderID)
        {
            InitializeComponent();
            dgvCart.DataSource = cart;
            serviceId = serviceID;
            serviceOrderId = serviceOrderID;
            loadSparepart();
        }


        private void loadSparepart()
        {
            string query = @"
                    SELECT 
                        s.sparepart_id,
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
                   spareId = Convert.ToInt32(dr["sparepart_id"]),
                   sparepartCode = dr["sparepart_code"].ToString(),
                   sparepartName = dr["sparepart_name"].ToString(),
                   stock = Convert.ToInt32(dr["stock"]),
                   unit = dr["unit"].ToString(),
                   price = Convert.ToDecimal(dr["selling_price"])
               }
               );

            dgvSparePart.DataSource = new BindingList<SparepartModel>(sparepart);
            addButtonUse();
            if (dgvSparePart.Columns.Contains("spareId")) dgvSparePart.Columns["spareId"].Visible = false;
            if (dgvCart.Columns.Contains("spareId")) dgvCart.Columns["spareId"].Visible = false;
        }
        private void dgvSparePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSparePart.Rows[e.RowIndex];
                int spareId = Convert.ToInt32(row.Cells["spareId"].Value);
                string code = row.Cells["sparepartCode"].Value.ToString();
                string name = row.Cells["sparepartName"].Value.ToString();
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                string unit = row.Cells["unit"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                if (dgvSparePart.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    //decrese stock
                    var item = sparepart
                        .FirstOrDefault(u => u.spareId == spareId);

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
                        txtSubtotal.Text = cart.Sum(u => u.price).ToString();

                        return;
                    }
                    cart.Add(new CartModel { spareId = spareId, sparepartCode = code, sparepartName = name, qty = 1, unit = unit, unitPrice = price });

                    txtSubtotal.Text = cart.Sum(u => u.price).ToString();
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
                int spareId = Convert.ToInt32(row.Cells["spareId"].Value);
                //decrese from cart
                var item = cart
                    .FirstOrDefault(u => u.spareId == spareId);
                if (item.qty <= 1)
                {
                    cart.Remove(item);
                    txtSubtotal.Text = cart.Sum(u => u.price).ToString();
                }
                item.qty -= 1;
                txtSubtotal.Text = cart.Sum(u => u.price).ToString();
                dgvCart.Refresh();

                //give back to sparepart 
                var spare = sparepart
                    .FirstOrDefault(u => u.spareId == spareId);
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
            if (chkPrice.Checked)
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

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.isNullInput(this)) return;
            if (!UIHelper.ConfirmationDialog("Finish Vehicle", "Do you sure to finish the vehicle right now?")) return;
            int i = 0;

            using (var conn = new SqlConnection(DBHelper.connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
//                  insert into service order details
                    string qSparepartUsage = "INSERT INTO service_order_details(service_order_id, service_id, price, notes) VALUES(@s, @sid, @p, @n)";
                    using(var cmd = new SqlCommand(qSparepartUsage, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@s", serviceOrderId);
                        cmd.Parameters.AddWithValue("@sid", serviceId);
                        cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtSubtotal.Text));
                        cmd.Parameters.AddWithValue("@n", txtNote.Text.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var item in cart)
                    {
//                      insert each sparepart use into sparepart usage
                        string qsparepart = "INSERT INTO sparepart_usage (service_order_id, sparepart_id, quantity, price) VALUES (@s, @si, @q, @p)";
                        using(var cmd = new SqlCommand(qsparepart, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@s", serviceOrderId);
                            cmd.Parameters.AddWithValue("@si", item.spareId);
                            cmd.Parameters.AddWithValue("@q", item.qty);
                            cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(item.price));
                            cmd.ExecuteNonQuery();
                        }

//                      insert each sparepart use into sparepart usage
                        string qstock = "UPDATE spareparts SET stock = stock - @q WHERE sparepart_id = @sid";
                        using (var cmd = new SqlCommand(qstock, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@sid", item.spareId);
                            cmd.Parameters.AddWithValue("@q", item.qty);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    UIHelper.toast("Failed", "Failed to Finished Vehicle: " + ex.Message);
                    transaction.Rollback();
                }
                finally { conn.Close(); }
            }
            if (i > 0)
            {
                UIHelper.toast("Finished", $"Vehicles Has Been Finished By {UserSession.userName}");
            }
        }
    }
}
