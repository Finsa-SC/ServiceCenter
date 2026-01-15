using ServiceCenter.core.network;
using ServiceCenter.core.util;
using ServiceCenter.ServiceOrder;
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


            serviceDiagnosisUC.clickMethod += () =>
            {
                var serviceAssess = new ServiceAssessmentUC();
                serviceAssess.finishedClick += () => loadActivity(serviceDiagnosisUC);
                loadActivity(serviceAssess);
            };
            if (checkJob() == 1) { loadActivity(serviceDiagnosisUC); pnlAvailable.Visible = true; }
        }

        private void ServiceWorkshopUC_Load(object sender, EventArgs e)
        {
            serviceDiagnosisUC.finishOrder += () =>
            {
                serviceDiagnosisUC = new ServiceDiagnosisUC();
                loadActivity(serviceDiagnosisUC);
                UIHelper.toast("Finished", $"Vehicles Has Been Finished By {UserSession.userName}");
            };
        }
        private void loadActivity(UserControl uc)
        {
            pnlAvailable.Controls.Clear();
            pnlAvailable.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;
        }

        private int checkJob()
        {
            string query = "SELECT 1 FROM service_assignments WHERE technician_id = @id AND finished_date IS NULL";
            int job = Convert.ToInt32(DBHelper.executeScalar(query, 
                new Microsoft.Data.SqlClient.SqlParameter("@id", UserSession.technicianId)
            ));
            return job;
        }
    }
}
