using Microsoft.Data.SqlClient;
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

namespace ServiceCenter
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = "https://finsa-sc.github.io/Finsa-Portofolio/";

                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select user_id, username, role_id, full_name, phone, photo_profile from users where username = @username and password = @password and is_active = 1";
            SqlParameter[] parameters =
            {
                //new SqlParameter("@username", txtUsername.Text.Trim()),
                //new SqlParameter("@password", txtPassword.Text.Trim())
                new SqlParameter("@username", "agus"),
                new SqlParameter("@password", "Agus080200")
            };
            var result = DBHelper.executeReader(query, dr =>
            {
                UserSession.setSession(
                    Convert.ToInt32(dr["user_id"]),
                    dr["username"].ToString(),
                    Convert.ToInt32(dr["role_id"]),
                    dr["full_name"].ToString(),
                    dr["phone"].ToString(),
                    dr["photo_profile"].ToString()
                );
                return true;
            },
                parameters
            );

            if (UserSession.isLogged())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Email or Password Wrong!!", "Un-Authorization", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
