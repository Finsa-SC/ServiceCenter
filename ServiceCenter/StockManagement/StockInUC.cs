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

namespace ServiceCenter.StockManagement
{
    public partial class StockInUC : UserControl
    {
        public StockInUC()
        {
            InitializeComponent();
        }
        private void StockInUC_Load(object sender, EventArgs e)
        {
            loadData();
            addButton();
        }

        private void loadData()
        {
            string query = @"
                    SELECT 
                        s.sparepart_id,
                        s.sparepart_code AS Code,
                        s.sparepart_name AS Name,
                        s.stock AS Stock,
                        s.minimum_stock AS Minimum,
                        u.unit_name AS Unit
                    FROM spareparts s
                    LEFT JOIN sparepart_unit u ON u.unit_id = s.unit_id
                    WHERE (@sn IS NULL OR s.sparepart_name LIKE @sn)
                        AND (@s = 0 OR s.stock <= @s)";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@sn", "%" + txtSSparepart.Text + "%"),
                new SqlParameter("@s", nmcSMaksimum.Value)
            );
            if (dataGridView1.Columns.Contains("sparepart_id")) dataGridView1.Columns["sparepart_id"].Visible = false;
        }
        private void addButton()
        {
            if (dataGridView1.Columns.Contains("btnAction")) return;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = Properties.Resources.icons_stock_48;
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img.HeaderText = "Add Stock";
            img.Name = "btnAction";

            dataGridView1.Columns.Add(img);
            img.Width = 100;
        }

        private void txtSSparepart_TextChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }

        private void nmcSMaksimum_ValueChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }

        private void tmrSearchDelay_Tick(object sender, EventArgs e)
        {
            loadData();
            tmrSearchDelay.Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int spareId = Convert.ToInt32(row.Cells["sparepart_id"].Value);
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    StockInForm form = new StockInForm(spareId);
                    form.ShowDialog();
                    loadData();
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                int minStock = Convert.ToInt32(row.Cells["Minimum"].Value);

                if(stock <= minStock)
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }else if(stock < 100)
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
