using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.ServiceWorkshop
{
    public partial class ServiceAssessmentUC : UserControl
    {
        int serviceId;
        public ServiceAssessmentUC(int serviceID)
        {
            InitializeComponent();
            serviceId = serviceID;
            MessageBox.Show(serviceId.ToString());
        }

        private void dgvSparePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
