using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.ServiceProcess
{
    public partial class FreeTechnicianForm : Form
    {
        public FreeTechnicianForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string query = @"
SELECT 
u.username AS Technician,

FROM users u";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
