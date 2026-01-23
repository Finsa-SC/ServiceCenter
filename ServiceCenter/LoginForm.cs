using System.Data.SqlClient;
using ServiceCenter.core.network;
using ServiceCenter.core.util;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        int passwordTry = 0;
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
            security();
            string? hashed = null;
            string password = txtPassword.Text.Trim();
            string query = @"
                    SELECT u.user_id, u.username, u.password, u.role_id, u.full_name, u.phone, u.photo_profile, t.technician_id
                    FROM users u 
                    LEFT JOIN technicians t ON u.user_id = t.user_id
                    WHERE u.email = @email AND u.status_id = 1";
            SqlParameter[] parameters =
            {
                new SqlParameter("@email", txtEmail.Text.Trim()),
            };
            var result = DBHelper.executeReader(query, dr =>
            {
                hashed = dr["password"].ToString();
                UserSession.setSession(
                    Convert.ToInt32(dr["user_id"]),
                    dr["username"].ToString(),
                    Convert.ToInt32(dr["role_id"]),
                    dr["full_name"].ToString(),
                    dr["phone"].ToString(),
                    dr["photo_profile"].ToString(),
                    dr["technician_id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["technician_id"])
                );
                return true;
            },
                parameters
            );

            if (!result.Any())
            {
                UIHelper.toast("Un-Authorization", "Email Wrong");
                return;
            }
            if(!PasswordHelper.Verify(password, hashed))
            {
                UIHelper.toast("Un-Authorization", "Password Wrong");
                return;
            }

            if (UserSession.isLogged())
            {
                DBHelper.executeNonQuery("update users set last_active = GETDATE() where user_id = @userid",
                    new SqlParameter("@userid", UserSession.userId));
                this.Close();
            }
        }

        private void security()
        {
            passwordTry += 1;

            if (passwordTry == 3) lblForgotPass.Visible = true;
            if(passwordTry == 5)
            {
                btnLogin.Visible = false;
                UIHelper.toast("Anomaly Detected", "We do not condone negligence of more than 5 times");
            }
        }
    }
}
