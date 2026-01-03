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
        public UserForm()
        {
            InitializeComponent();
            loadRole();
            loadStatus();
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
            if (ValidationHelper.isNullInput(this)) return ;
            string query = "insert into users(full_name, email, username, password, role_id, phone, status_id, photo_profile, is_active) values(@f, @e, @u, @p, @r, @phn, @s, @img, 1)";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@f",txtFullName.Text.Trim()),
                new SqlParameter("@e",txtEmail.Text.Trim()),
                new SqlParameter("@u",txtUsername.Text.Trim()),
                new SqlParameter("@p",txtPhone.Text.Trim()),
                new SqlParameter("@r", cmbRole.SelectedIndex < 0 ? cmbRole.SelectedValue : 1),
                new SqlParameter("@phn", txtPhone.Text.Trim()),
                new SqlParameter("@s", cmbStatus.SelectedIndex < 0 ? cmbStatus.SelectedValue : 1),
                new SqlParameter("@img", image)
            );
            this.Close();
        }
    }
}
