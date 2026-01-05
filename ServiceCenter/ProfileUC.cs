using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class ProfileUC : UserControl
    {
        public ProfileUC()
        {
            InitializeComponent();
            loadData();
            UserSession.loadUserSession();
            MakePictureBoxOval(pctProfil);
        }

        private Form1 form => this.FindForm() as Form1;

        private void loadData()
        {
            UserSession.loadUserSession();
            form?.initImage();
            txtUsername.Text = UserSession.userName;
            txtPhone.Text = UserSession.phone;
            loadImage(pctProfil, UserSession.photo);
            txtRole.Text = UserSession.roleString;
        }


        bool edit = true;
        private void btnEditName_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                txtUsername.Enabled = true;
                txtUsername.Focus();
                btnEditName.BackgroundImage = Image.FromFile("C:\\Users\\siala\\Source\\Repos\\ServiceCenter\\ServiceCenter\\assets\\icons8-check-50.png");
            }
            else
            {
                string query = "update users set username = @username where user_id = @UserId";
                int db = DBHelper.executeNonQuery(query,
                    new SqlParameter("@UserId", UserSession.userId),
                    new SqlParameter("@username", txtUsername.Text)
                );
                if (db > 0)
                {
                    UserSession.updateUsername(txtUsername.Text);
                    loadData();
                    form.loadBottomNav();
                    txtUsername.Enabled = false;
                    btnEditName.BackgroundImage = Image.FromFile("C:\\Users\\siala\\Source\\Repos\\ServiceCenter\\ServiceCenter\\assets\\icons8-pencil-24.png");
                }
            }
            edit = !edit;
        }


        public void MakePictureBoxOval(PictureBox pb)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);
        }

        bool showOp = true;
        private void imageOption()
        {
            if (showOp)
            {
                pnlOption.Visible = true;
            }
            else
            {
                pnlOption.Visible = false;
            }
            showOp = !showOp;
        }
        private void pctProfil_MouseClick(object sender, MouseEventArgs e)
        {
            imageOption();
        }

        public void loadImage(PictureBox box, string image)
        {
            if(string.IsNullOrWhiteSpace(image) || !File.Exists(image))
            {
                box.Image?.Dispose();
                box.Image = Properties.Resources.icons8_user_100;
                return;
            }
            try
            {
                using(Image img = Image.FromFile(image))
                {
                    box.Image?.Dispose();
                    box.Image = new Bitmap(img);
                }
            }catch(Exception ex) { box.Image?.Dispose(); box.Image = Properties.Resources.icons8_user_100;}
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var (dialog, path) = ImageHelper.uploadImage();
            if (dialog == DialogResult.OK)
            {
                if (UIHelper.ConfirmationDialog("Confirmation", "Are You Sure to Change Your Profile Photo?"))
                {
                    string query = "update users set photo_profile = @photo where user_id = @userid";
                    DBHelper.executeNonQuery(query,
                        new SqlParameter("@userid", UserSession.userId),
                        new SqlParameter("@photo", path)
                    );
                    loadData();
                    imageOption();
                    UIHelper.toast("Changes", "successfully Update profile photo");
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UserSession.photo)||!File.Exists(UserSession.photo))
            {
                ImageShow iform = new ImageShow();
                iform.ShowDialog();
                imageOption();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBHelper.executeNonQuery("update users set photo_profile = null where user_id = @userid", new SqlParameter("@userid", UserSession.userId));
            loadData();
            imageOption();
            UIHelper.toast("Deleted", "successfully deleted profile photo");
        }

        private void btnCopyPhone_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPhone.Text);
            UIHelper.toast("Coppied", "Success copied to clipboard");
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 3;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.clear();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            form.loadBottomNav();
            loadData();
        }
    }
}
