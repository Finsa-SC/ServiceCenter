using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.ServiceWorkshop
{
    internal class ServiceSession
    {
        public static int serviceId {  get; set; }
        public static int serviceOrderId {  get; set; }
        public static int serviceAssignId {  get; set; }

        public static void clearOrderSession()
        {
            serviceId = 0;
            serviceOrderId = 0;
            serviceAssignId = 0;
        }
    }
}
