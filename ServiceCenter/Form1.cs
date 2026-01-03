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
            btnAssignment.MouseEnter += Hover_MouseEnter;

            btnUserManagement.MouseLeave += Hover_MouseLeave;
            btnAssignment.MouseLeave += Hover_MouseLeave;
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
            tmrSlide.Start();
            showSpeed = 37;
            hideSpeed = 0;
        }
        int hideSpeed;
        int showSpeed;
        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            if(showProfile)
            {
                if(pnlProfile.Left < 83)
                {
                    pnlProfile.Left += showSpeed;
                    if (showSpeed > 1) { showSpeed -= 1; } else { showSpeed = 2; }
                }
                else
                {
                    pnlProfile.Left = 83;
                    tmrSlide.Stop();
                    showProfile = !showProfile;
                }
            }
            else
            {
                if (pnlProfile.Left >= -pnlProfile.Width)
                {
                    pnlProfile.Left -= hideSpeed;
                    hideSpeed += 1;
                }
                else
                {
                    pnlProfile.Left = -pnlProfile.Width;
                    tmrSlide.Stop();
                    showProfile = !showProfile;
                    pnlProfile.Controls.Clear();
                }
            }
        }
    }
}
