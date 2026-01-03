namespace ServiceCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadBottomNav();
            initButton();
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

        private void pctProfile_MouseClick(object sender, MouseEventArgs e)
        {
            loadUC(new ProfileUC());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            isLogged();
            pctProfile.Image = UserSession.photo != null ? Image.FromFile(UserSession.photo) : null;
            ProfileUC form = new ProfileUC();
            form.MakePictureBoxOval(pctProfile);
            loadUC(new UserManagementUC());
        }
    }
}
