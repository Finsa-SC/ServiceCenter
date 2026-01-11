using ServiceCenter.core.network;
using ServiceCenter.ServiceWorkshop;
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
    public partial class ServiceWorkshopUC : UserControl
    {
        private ServiceDiagnosisUC serviceDiagnosisUC;
        public ServiceWorkshopUC()
        {
            InitializeComponent();
            serviceDiagnosisUC = new ServiceDiagnosisUC();
            loadActivity(serviceDiagnosisUC);
        }

        private void ServiceWorkshopUC_Load(object sender, EventArgs e)
        {
            var data = serviceDiagnosisUC;
            data.Action += () => { pnlAvailable.Visible = true; };
        }
        private void loadActivity(UserControl uc)
        {
            pnlAvailable.Controls.Clear();
            pnlAvailable.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;
        }
    }
}
