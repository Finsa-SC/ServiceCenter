using ServiceCenter.core.network;
using ServiceCenter.UserNamagement;
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

namespace ServiceCenter
{
    public partial class UserManagementUC : UserControl
    {
        public UserManagementUC()
        {
            InitializeComponent();
            loadUser();
            loadStatus();
            loadRole();
            txtName.KeyPress += loadChange;
            cmbRole.SelectedValueChanged += loadChange;
            cmbStatus.SelectedValueChanged += loadChange;
            dteDate.ValueChanged += loadChange;
            chkDte.CheckedChanged += loadChange;
        }

        private void loadChange(object sender, EventArgs e) => loadUser();


        object dateValue = (object)DBNull.Value;
        private void chkDte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDte.Checked)
            {
                dateValue = dteDate.Value.Date;
                dteDate.Enabled = true;
            }
            else
            {
                dateValue = (object)DBNull.Value;
                dteDate.Enabled = false;
            }
        }

        private void loadUser()
        {
            string query = @"
                    select
                        u.full_name as [Full Name],
                        u.email as Email,
                        u.username as Username,
                        s.status_name as Status,
                        r.role_name as Role,
                        FORMAT(u.created_at, 'MMMM d, yyyy') as [Joined Date],
                        u.last_active as [Last Active]
                    FROM users u
                    JOIN user_status s ON s.status_id = u.status_id
                    JOIN roles r ON r.role_id = u.role_id
                    WHERE 
                        (@name is null or u.full_name like @name) 
                        and (@role is null OR r.role_id = @role) 
                        and (u.status_id = @status or @status is null) 
                        and (@date is null or cast(@date AS Date) = cast(u.created_at AS Date))";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@name", "%" + txtName.Text + "%"),
                new SqlParameter("@role", cmbRole.SelectedValue == null ? (object)DBNull.Value : cmbRole.SelectedValue),
                new SqlParameter("@status", cmbStatus.SelectedValue == null ? (object)DBNull.Value : cmbStatus.SelectedValue),
                new SqlParameter("@date", dteDate.Value == null? (object)DBNull.Value:dateValue)
            );
        }
        private void loadRole()
        {
            string query = "select role_id, role_name from roles";
            var dt = DBHelper.executeQuery(query);
            var dr = dt.NewRow();
            dr["role_id"] = DBNull.Value;
            dr["role_name"] = "All Role";
            dt.Rows.InsertAt(dr, 0);
            cmbRole.DataSource = dt;
            cmbRole.ValueMember = "role_id";
            cmbRole.DisplayMember = "role_name";
        }
        private void loadStatus()
        {
            string query = "select status_id, status_name from user_status";
            var dt = DBHelper.executeQuery(query);
            var dr = dt.NewRow();
            dr["status_id"] = DBNull.Value;
            dr["status_name"] = "All Status";
            dt.Rows.InsertAt(dr, 0);
            cmbStatus.DataSource = dt;
            cmbStatus.ValueMember = "status_id";
            cmbStatus.DisplayMember = "status_name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
            loadUser();
        }

        
    }
}
