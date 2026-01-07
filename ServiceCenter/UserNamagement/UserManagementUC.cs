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
using ServiceCenter.core.util;

namespace ServiceCenter
{
    public partial class UserManagementUC : UserControl
    {
        bool isLoaded = false;
        public UserManagementUC()
        {
            InitializeComponent();
            initSearchMethod();
        }
        private void UserManagementUC_Load(object sender, EventArgs e)
        {
            loadUser();
            loadStatus();
            loadRole();
            addEditButton();
            addDeleteButton();
            isLoaded = true;

            dataGridView1.RowTemplate.Height = 50;
        }

        private void initSearchMethod()
        {
            cmbRole.SelectedValueChanged += loadChange;
            cmbStatus.SelectedValueChanged += loadChange;
            dteDate.ValueChanged += loadChange;
            chkDte.CheckedChanged += loadChange;
        }

        private void loadChange(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            loadUser();
        }


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
                    SELECT
                        u.user_id,
                        u.full_name as [Full Name],
                        u.email as Email,
                        u.username as Username,
                        s.status_name as Status,
                        r.role_name as Role,
                        FORMAT(u.created_at, 'MMMM d, yyyy') as [Joined Date],
                        CASE
                            WHEN DATEDIFF(MINUTE, u.last_active, GETDATE()) < 1
                                THEN 'Just Now'
                            WHEN DATEDIFF(MINUTE, u.last_active, GETDATE()) < 60
                                THEN CAST(DATEDIFF(MINUTE, u.last_active, GETDATE()) AS VARCHAR(20)) + ' minutes ago'
                            WHEN DATEDIFF(HOUR, u.last_active, GETDATE()) < 24
                                THEN CAST(DATEDIFF(HOUR, u.last_active, GETDATE()) AS VARCHAR(20))+ ' hours ago'
                            WHEN DATEDIFF(DAY, u.last_active, GETDATE()) < 30
                                THEN CAST(DATEDIFF(DAY, u.last_active, GETDATE()) AS VARCHAR(20)) + ' days ago'
                            WHEN DATEDIFF(WEEK, u.last_active, GETDATE()) < 7
                                THEN CAST(DATEDIFF(WEEK, u.last_active, GETDATE()) AS VARCHAR(20)) + ' weeks ago'
                            WHEN DATEDIFF(MONTH, u.last_active, GETDATE()) < 12
                                THEN CAST(DATEDIFF(MONTH, u.last_active, GETDATE()) AS VARCHAR(20)) + ' months ago'
                            ELSE 
                                CAST(DATEDIFF(YEAR, u.last_active, GETDATE()) AS VARCHAR(20))+ ' years ago'
                        END AS [Last Active]
                    FROM users u
                    JOIN user_status s ON s.status_id = u.status_id
                    JOIN roles r ON r.role_id = u.role_id
                    WHERE 
                        (@name IS NULL OR u.full_name LIKE @name) 
                        AND (@role IS NULL OR r.role_id = @role) 
                        AND (u.status_id = @status or @status IS NULL) 
                        AND (@date IS NULL OR CAST(@date AS DATE) = CAST(u.created_at AS DATE))";
            dataGridView1.DataSource = DBHelper.executeQuery(query,
                new SqlParameter("@name", "%" + txtName.Text + "%"),
                new SqlParameter("@role", cmbRole.SelectedValue == null ? (object)DBNull.Value : cmbRole.SelectedValue),
                new SqlParameter("@status", cmbStatus.SelectedValue == null ? (object)DBNull.Value : cmbStatus.SelectedValue),
                new SqlParameter("@date", dteDate.Value == null ? (object)DBNull.Value : dateValue)
            );
            if (dataGridView1.Columns.Contains("user_id")) dataGridView1.Columns["user_id"].Visible = false;
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

        private void addEditButton()
        {
            if (dataGridView1.Columns.Contains("btnEdit")) return;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "btnEdit";
            img.HeaderText = "";
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img.Image = Properties.Resources.icons8_pencil_64;
            img.Width = 50;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataGridView1.Columns.Add(img);
        }
        private void addDeleteButton()
        {
            if (dataGridView1.Columns.Contains("btnDelete")) return;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "btnDelete";
            img.HeaderText = "";
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img.Image = Properties.Resources.icons8_trash_24;
            img.Width = 50;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataGridView1.Columns.Add(img);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int userid = Convert.ToInt32(row.Cells["user_id"].Value);
                string username = row.Cells["Username"].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
                    {
                        UserForm form = new UserForm(userid);
                        form.ShowDialog();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    if (UIHelper.ConfirmationDialog("Confirm Delete", $"Are Your Sure to Delete {username} From User List? This might prevent {username} from accessing this application."))
                    {
                        int i = DBHelper.executeNonQuery("delete from users where user_id = @id",
                            new SqlParameter("@id", userid)
                        );
                        if (i > 0)
                        {
                            UIHelper.toast("Success Deleting", $"{username} Has Been Deleted From User List");
                        }
                    }
                }
                loadUser();
            }
        }

        private void tmrSearchDelay_Tick(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            loadUser();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            tmrSearchDelay.Stop();
            tmrSearchDelay.Start();
        }
    }
}
