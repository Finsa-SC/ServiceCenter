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
        private DialogMode mode;
        private enum DialogMode
        {
            CreateUser,
            UpdateUser
        }
        public UserForm(int userId = 0)
        {
            InitializeComponent();
            loadRole();
            loadStatus();
            if(userId != 0)
            {
                userid = userId;
                mode = DialogMode.UpdateUser;
            }
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            if (mode == DialogMode.UpdateUser)
            {
                txtPassword.Visible = false;
                txtCPassword.Visible = false;
                lblCPassword.Visible = false;
                lblPassword.Visible = false;
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

        string? stringImage;
        private void btnImport_Click(object sender, EventArgs e)
        {
            var (result, image) = ImageHelper.uploadImage();
            if(result == DialogResult.OK)
            {
                stringImage = image;
                ImageHelper.loadImage(pctProfile, image);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.isNullInput(this)) return;
            if (ValidationHelper.checkEmail(txtEmail.Text)) return;
            if(checkEmail()) { UIHelper.toast("Exists Items", "Email Address Already Taken"); return; }

            if (mode == DialogMode.CreateUser)
            {
                createUser();
            }
            else if(mode == DialogMode.UpdateUser)
            {
                if(UIHelper.ConfirmationDialog("Confirm Update", "Are You Sure To Update Old Data To New Data?"))
                {
                    updateUser(userid);
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private void createUser()
        {
            if (ValidationHelper.checkEmail(txtEmail.Text)) return; 
            if (txtPassword.Text.Trim() != txtCPassword.Text.Trim()) { UIHelper.toast("Security Report", "password is not the same, please pay attention to your password"); return; }
            if (txtPassword.TextLength < 8) { UIHelper.toast("Security Report", "Your password is too weak to be called a password, please try a stronger password."); return; }
            if (ValidationHelper.checkPhone(txtPhone.Text)) return;

            string query = "insert into users(full_name, email, username, password, role_id, phone, status_id, photo_profile, is_active) values(@f, @e, @u, @p, @r, @phn, @s, @img, 1)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@f", txtFullName.Text.Trim()),
                new SqlParameter("@e", txtEmail.Text.Trim()),
                new SqlParameter("@u", txtUsername.Text.Trim()),
                new SqlParameter("@p", PasswordHelper.Hash(txtPassword.Text.Trim())),
                new SqlParameter("@r", cmbRole.SelectedValue),
                new SqlParameter("@phn", txtPhone.Text.Trim()),
                new SqlParameter("@s", cmbStatus.SelectedValue),
                new SqlParameter("@img", !string.IsNullOrWhiteSpace(stringImage) ? stringImage : DBNull.Value)
            );
            if (i > 0) { 
                this.Close();
                UIHelper.toast("Success Insert", "Success Insert User Into User List ");
            }
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

        private void updateUser(int userId)
        {
            string query = "update users set full_name = @f, email = @e, username = @u, phone = @p, role_id = @r, status_id = @s where user_id = @id";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@f", txtFullName.Text.Trim()),
                new SqlParameter("@e", txtEmail.Text.Trim()),
                new SqlParameter("@u", txtUsername.Text.Trim()),
                new SqlParameter("@p", txtPhone.Text.Trim()),
                new SqlParameter("@r", cmbRole.SelectedValue),
                new SqlParameter("@s", cmbStatus.SelectedValue),
                new SqlParameter("@id", userid)
            );
            if (i > 0)
            {
                this.Close();
                UIHelper.toast("Success Updating", "Success Updateing ");
            }
        }
        private bool checkEmail()
        {
            string query = "select count(*) from users where email = @e and user_id != @id";
            int i = DBHelper.executeReader(query, dr =>
                Convert.ToInt32(dr[0]),
                new SqlParameter("@e", txtEmail.Text),
                new SqlParameter("@id", userid != 0? userid:0)
            ).FirstOrDefault();
            if (i > 0) return true; 
            return false;
        }
    }
}
