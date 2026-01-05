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
using ServiceCenter.core.util;

namespace ServiceCenter.UserNamagement
{
    public partial class UserForm : Form
    {
        private int userid;
        public UserForm(int userId = 0)
        {
            InitializeComponent();
            loadRole();
            loadStatus();
            userid = userId;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            if (userid != 0)
            {
                createUser();
            }
            else
            {
                txtPassword.Visible = false;
                txtCPassword.Visible = false;
                loadUser(userid);
            }
        }

        private void loadRole()
        {
            string query = "select role_id, role_name from roles";
            cmbRole.DataSource = DBHelper.executeQuery(query);
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "role_id";
            cmbRole.SelectedIndex = -1;
        }
        private void loadStatus()
        {
            string query = "select status_id, status_name from user_status";
            cmbStatus.DataSource = DBHelper.executeQuery(query);
            cmbStatus.DisplayMember = "status_name";
            cmbStatus.ValueMember = "status_id";
            cmbStatus.SelectedIndex = -1;
        }

        string? image;
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File | *.png;*.img;*.jpg;*.jpeg;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        pctProfile.Image?.Dispose();
                        pctProfile.Image = new Bitmap(img);
                    }
                    image = ofd.FileName;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private void createUser()
        {
            if (ValidationHelper.isNullInput(this)) return;
            if (!txtEmail.Text.Trim().EndsWith("@gmail.com")) { UIHelper.toast("Invalid Format", "Email format is incorrect"); return; }
            if (txtPassword.Text.Trim() != txtCPassword.Text.Trim()) { UIHelper.toast("Password Doesn't Match", "password is not the same, please pay attention to your password"); return; }
            if (txtPassword.TextLength < 8) { UIHelper.toast("Security Report", "Your password is too weak to be called a password, please try a stronger password."); return; }
            if (!txtPhone.Text.Trim().StartsWith("08")) { UIHelper.toast("Invalid Format", "phone number format is incorrect"); return; }

            string query = "insert into users(full_name, email, username, password, role_id, phone, status_id, photo_profile, is_active) values(@f, @e, @u, @p, @r, @phn, @s, @img, 1)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@f", txtFullName.Text.Trim()),
                new SqlParameter("@e", txtEmail.Text.Trim()),
                new SqlParameter("@u", txtUsername.Text.Trim()),
                new SqlParameter("@p", txtPassword.Text.Trim()),
                new SqlParameter("@r", cmbRole.SelectedValue),
                new SqlParameter("@phn", txtPhone.Text.Trim()),
                new SqlParameter("@s", cmbStatus.SelectedValue),
                new SqlParameter("@img", !string.IsNullOrWhiteSpace(image) ? image : DBNull.Value)
            );
            if (i > 0) { this.Close(); }
        }
        private void loadUser(int userId)
        {
            string query = "select full_name, email, username, phone, photo_profile, role_id, status_id from users where user_id = @id";
            var i = DBHelper.executeReader(query, dr =>
                {
                    txtFullName.Text = dr["full_name"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtUsername.Text = dr["username"].ToString();
                    txtPhone.Text = dr["phone"].ToString();
                    cmbRole.SelectedValue = Convert.ToInt32(dr["role_id"]);
                    cmbStatus.SelectedValue = Convert.ToInt32(dr["status_id"]);
                    string? image = dr["photo_profile"].ToString();
                    if (!string.IsNullOrWhiteSpace(image))
                    {
                        pctProfile.Image = Image.FromFile(image);
                    }

                    return true;
                },
                new SqlParameter("@id", userId)
            );
        }

        
    }
}
