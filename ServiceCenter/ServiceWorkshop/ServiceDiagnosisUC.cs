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

namespace ServiceCenter.ServiceWorkshop
{
    public partial class ServiceDiagnosisUC : UserControl
    {
        public event Action Action;
        public ServiceDiagnosisUC()
        {
            InitializeComponent();
        }
        private void ServiceDiagnosisUC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = @"
                    DECLARE @sid INT;
                    DECLARE @cid INT;
                    SELECT @sid = service_order_id FROM service_assignments WHERE technician_id = @tid AND finished_date IS NULL;
                    SELECT @cid = customer_id FROM service_orders WHERE service_order_id = @sid;

                    SELECT 
                        v.plate_number AS [Plate Number], 
                        v.brand AS Brand,
                        v.model AS Model,
                        v.year AS Year,
                        v.engine_number AS [Engine Number],
                        v.frame_number AS [Frame Number],
                        s.complaint
                    FROM service_orders s 
                    JOIN vehicles v ON s.vehicle_id = v.vehicle_id
                    WHERE s.customer_id = @cid";
            var data = DBHelper.executeReader(query, dr =>
            {

                return 1;
            },
            new Microsoft.Data.SqlClient.SqlParameter("@tid", UserSession.technicianId)
            );
            if (data != null && data.Contains(1))
            {
                Action?.Invoke();
            }
        }

    }
}
