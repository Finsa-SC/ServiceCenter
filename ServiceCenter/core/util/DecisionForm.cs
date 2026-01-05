using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.core.util
{
    public partial class DecisionForm : Form
    {
        public DecisionForm(string title, string message)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;

            btnOk.MouseEnter += btnCancel_MouseLeave;
        }

        private static bool isOk;
        private void btnOk_Click(object sender, EventArgs e)
        {
            isOk = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOk = false;
            this.Close();
        }
        public bool choiceResult()
        {
            return isOk;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(168, 49, 34);
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.BringToFront();
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 2;
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(49, 142, 204);
            btnOk.FlatAppearance.BorderSize = 3;
            btnOk.BringToFront();
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.FlatAppearance.BorderColor = Color.Silver;
            btnOk.FlatAppearance.BorderSize = 2;
        }
    }
}
