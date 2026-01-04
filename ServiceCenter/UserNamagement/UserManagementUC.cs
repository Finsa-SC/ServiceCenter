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

namespace ServiceCenter
{
    public partial class UserManagementUC : UserControl
    {
        public UserManagementUC()
        {
            InitializeComponent();
            loadUser();
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
                        u.created_at as [Joined Date],
                        u.last_active as [Last Active]
                    FROM users u
                    JOIN user_status s ON s.status_id = u.status_id
                    JOIN roles r ON r.role_id = u.role_id";
            dataGridView1.DataSource = DBHelper.executeQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
            loadUser();
        }
    }
}
