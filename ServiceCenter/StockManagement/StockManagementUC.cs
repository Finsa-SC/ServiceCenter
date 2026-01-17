using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.StockManagement
{
    public partial class StockManagementUC : UserControl
    {
        public StockManagementUC()
        {
            InitializeComponent();
            loadActivity(new SparepartManagementUC());
        }

        private void loadActivity(UserControl uc)
        {
            pnlActivity.Controls.Clear();
            pnlActivity.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
