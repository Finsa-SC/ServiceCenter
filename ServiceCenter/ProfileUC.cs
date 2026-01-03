using Microsoft.Data.SqlClient;
using ServiceCenter.core.network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
            MakePictureBoxOval(pctProfil);
        }

        Form1 form = new Form1();

        private void loadData()
        {
            txtUsername.Text = UserSession.userName;
            txtPhone.Text = UserSession.phone;
            loadImage(UserSession.photo);
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

        private void loadImage(string image)
        {
            using(FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read))
            {
                using(Image img = Image.FromStream(fs))
                {
                    pctProfil.Image = new Bitmap(img);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files | *.png;*.img;*.jpeg;*.jpg;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string query = "update users set photo_profile = @photo where user_id = @userid";
                    DBHelper.executeNonQuery(query, 
                        new SqlParameter("@userid", UserSession.userId),
                        new SqlParameter("@photo", ofd.FileName)
                    );
                    UserSession.updatePhoto(ofd.FileName);
                    loadData();
                    imageOption();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (UserSession.photo != null)
            {

            }
        }

        private void btnCopyPhone_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPhone.Text);
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
