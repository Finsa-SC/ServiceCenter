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

namespace ServiceCenter.ServiceHistory
{
    public partial class ServiceHistoryUC : UserControl
    {
        public ServiceHistoryUC()
        {
            InitializeComponent();
        }
        private void ServiceHistoryUC_Load(object sender, EventArgs e)
        {
            loadActivity(new OrderHistoryUC());
        }

        private void loadActivity(UserControl uc)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            loadActivity(new OrderHistoryUC());
        }

        
    }
}
