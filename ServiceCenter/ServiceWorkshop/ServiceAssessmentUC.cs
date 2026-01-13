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

namespace ServiceCenter.ServiceWorkshop
{
    public partial class ServiceAssessmentUC : UserControl
    {
        int serviceId;
        public ServiceAssessmentUC(int serviceID)
        {
            InitializeComponent();
            loadSparepart();
            serviceId = serviceID;
        }

        private void dgvSparePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSparePart.Rows[e.RowIndex];
                if (dgvSparePart.Columns[e.ColumnIndex].Name == "btnAction")
                {
                    string query = "UPDATE spareparts SET stock = stock - 1 WHERE sparepart_id = @sid";
                    int i = DBHelper.executeNonQuery(query,
                        new Microsoft.Data.SqlClient.SqlParameter("@sid", Convert.ToInt32(row.Cells["sparepart_id"].Value))
                    );
                    if(i > 0)
                    {
                        loadSparepart();
                    }
                }
            }
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
                        stock AS Stock
                    FROM spareparts 
                    WHERE stock > 0";
            dgvSparePart.DataSource = DBHelper.executeQuery(query);
            addButtonUse();
        }
    }
}
