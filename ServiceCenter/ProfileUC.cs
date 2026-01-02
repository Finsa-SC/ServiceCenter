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

namespace ServiceCenter
{
    public partial class ProfileUC : UserControl
    {
        public ProfileUC()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            txtUsername.Text = UserSession.userName;
            txtPhone.Text = UserSession.phone;
            pctProfil.Image = UserSession.photo != null ? Image.FromFile(UserSession.photo) : null;
            txtRole.Text = UserSession.roleString;
        }


        bool edit = true;
        private void btnEditName_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                txtUsername.Enabled=true;
                txtUsername.Focus();
                btnEditName.BackgroundImage = Image.FromFile("C:\\Users\\siala\\Source\\Repos\\ServiceCenter\\ServiceCenter\\assets\\icons8-check-50.png");
            }
            else
            {
                string query = "update users set username = @username where user_id = @UserId";
                int db = DBHelper.executeNonQuery(query,
                    new SqlParameter("@UserId", UserSession.userId),
                    new SqlParameter("@username", UserSession.userName)
                );
                if (db > 0)
                {
                    loadData();
                    Form1 form = new Form1();
                    form.loadBottomNav();
                    txtUsername.Enabled = false;
                    btnEditName.BackgroundImage = Image.FromFile("C:\\Users\\siala\\Source\\Repos\\ServiceCenter\\ServiceCenter\\assets\\icons8-pencil-24.png");
                }
            }
            edit = !edit;
        }
    }


}
