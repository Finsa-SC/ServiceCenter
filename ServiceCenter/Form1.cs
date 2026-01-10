using ServiceCenter.core.util;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initButton();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isLogged();
            loadUC(new UserManagementUC());
            initImage();
            loadBottomNav();
        }

        public void isLogged()
        {
            if (!UserSession.isLogged())
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
            UIHelper.toast("Login Success", $"Welcome Back Again {UserSession.userName}, Great to Meet You!");
            chectUserRole();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        UserControl? currentUc = null;
        private void loadUC(UserControl uc)
        {
            if (currentUc == null || currentUc.GetType() != uc.GetType())
            {
                pnlActivity.Controls.Clear();
                pnlActivity.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                currentUc = uc;
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (UserSession.isLogged())
            {
                loadUC(new UserManagementUC());
            }
        }

        public void loadBottomNav()
        {
            if (UserSession.isLogged())
            {
                timer1.Start();
                txtUsername.Text = UserSession.full_name;
                txtRole.Text = UserSession.roleString;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("yyyy-MMMM-dd    HH:mm:ss");
        }


        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            if (UserSession.isLogged())
            {
                loadUC(new UserManagementUC());
            }
        }


        private void initButton()
        {
            btnUserManagement.MouseEnter += Hover_MouseEnter;
            btnServiceOrder.MouseEnter += Hover_MouseEnter;
            btnServiceProcess.MouseEnter += Hover_MouseEnter;
            btnServiceWorkshop.MouseEnter += Hover_MouseEnter;

            btnUserManagement.MouseLeave += Hover_MouseLeave;
            btnServiceOrder.MouseLeave += Hover_MouseLeave;
            btnServiceProcess.MouseLeave += Hover_MouseLeave;
            btnServiceWorkshop.MouseLeave += Hover_MouseLeave;

            btnUserManagement.MouseHover += Mouse_hover_button;
            btnServiceOrder.MouseHover += Mouse_hover_button;
            btnServiceProcess.MouseHover += Mouse_hover_button;
            btnServiceWorkshop.MouseHover += Mouse_hover_button;
            pctProfile.MouseHover += Mouse_hover_button;
        }
        private void Hover_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 3;
        }
        private void Hover_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        public void initImage()
        {
            ProfileUC form = new ProfileUC();
            form.loadImage(pctProfile, UserSession.photo);
            form.MakePictureBoxOval(pctProfile);
        }

        bool showProfile = true;
        private void pctProfile_MouseClick(object sender, MouseEventArgs e)
        {
            pnlProfile.Controls.Add(new ProfileUC());
            tmrProfileSlide.Start();
            showSpeed = 37;
            hideSpeed = 0;
            pctProfile.Enabled = false;
        }
        int hideSpeed;
        int showSpeed;
        private void tmrProfileSlide_Tick(object sender, EventArgs e)
        {
            if (showProfile)
            {
                if (pnlProfile.Left < 83)
                {
                    pnlProfile.Left += showSpeed;
                    if (showSpeed > 1) { showSpeed -= 1; } else { showSpeed = 2; }
                }
                else
                {
                    pnlProfile.Left = 83;
                    tmrProfileSlide.Stop();
                    showProfile = !showProfile;
                    pctProfile.Enabled = true;
                }
            }
            else
            {
                if (pnlProfile.Left >= -pnlProfile.Width)
                {
                    pnlProfile.Left -= hideSpeed;
                    hideSpeed += 3;
                }
                else
                {
                    pnlProfile.Left = -pnlProfile.Width;
                    tmrProfileSlide.Stop();
                    showProfile = !showProfile;
                    pnlProfile.Controls.Clear();
                    pctProfile.Enabled = true;
                }
            }
        }

        bool wantShow = false;
        private void tmrTitleSlide_Tick(object sender, EventArgs e)
        {
            int speed = 2;
            int hidePos = -pnlTitle.Height + 12;
            if (wantShow)
            {
                if (pnlTitle.Top < 0)
                {
                    pnlTitle.Top += speed;
                }
                else
                {
                    pnlTitle.Top = 0;
                    tmrTitleSlide.Stop();
                }
            }
            else
            {
                if (pnlTitle.Top >= hidePos)
                {
                    pnlTitle.Top -= speed;
                }
                else
                {
                    pnlTitle.Top = hidePos;
                    tmrTitleSlide.Stop();
                }
            }
        }

        private void pnlTitle_MouseEnter(object sender, EventArgs e)
        {
            wantShow = true;
            if (!tmrTitleSlide.Enabled)
            {
                tmrTitleSlide.Start();
            }
        }

        private void pnlTitle_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlTitle.ClientRectangle.Contains(
                pnlTitle.PointToClient(Cursor.Position)))
            {
                wantShow = false;
                if (!tmrTitleSlide.Enabled)
                {
                    tmrTitleSlide.Start();
                }
            }
        }

        private void Mouse_hover_button(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                toolTip1.SetToolTip(btn, btn.Tag.ToString());
            }
            else if (sender is PictureBox pct)
            {
                toolTip1.SetToolTip(pct, pct.Tag.ToString());
            }
        }

        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            loadUC(new ServiceOrder.ServiceOrdersUC());
        }


        public void chectUserRole()
        {
            if (UserSession.roleString == "Developer") return;
            relogButton();
            UserControl? uc = null;
            switch (UserSession.roleId)
            {
                case 1:
                    btnUserManagement.Visible = true;
                    btnServiceOrder.Visible = true;
                    btnServiceProcess.Visible = true;
                    uc = new UserManagementUC();
                    break;
                case 2:
                    btnServiceWorkshop.Visible = true;
                    uc = new ServiceWorkshopUC();
                    break;
                case 4:
                    btnServiceOrder.Visible = true;
                    btnServiceProcess.Visible = true;
                    uc = new ServiceOrder.ServiceOrdersUC();
                    break;
                case 5:
                    btnUserManagement.Visible = false;
                    break;
            }
            loadUC(uc);
        }
        private void relogButton()
        {
            btnUserManagement.Visible = false;
            btnServiceOrder.Visible = false;
            btnServiceProcess.Visible = false;
            btnServiceWorkshop.Visible = false;
        }

        private void btnServiceProcess_Click(object sender, EventArgs e)
        {
            loadUC(new ServiceProcessUC());
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            loadUC(new ServiceWorkshopUC());
        }
    }
}
