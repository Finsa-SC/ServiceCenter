namespace ServiceCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            isLogged();
            loadBottomNav();

            pctProfile.Image = UserSession.photo != null ? Image.FromFile(UserSession.photo) : null;
        }

        private void isLogged()
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

        private void loadUC(UserControl uc)
        {
            pnlActivity.Controls.Clear();
            pnlActivity.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
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
                txtUsername.Text = UserSession.userName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("yyyy-MMMM-dd HH:mm:ss");
        }

        private void pctProfile_MouseClick(object sender, MouseEventArgs e)
        {
            loadUC(new ProfileUC());
        }
    }
}
