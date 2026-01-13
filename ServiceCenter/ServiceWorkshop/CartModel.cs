using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.ServiceWorkshop
{
    internal class CartModel
    {
        public string sparepartCode {  get; set; }
        public string sparepartName {  get; set; }
        public int stock {  get; set; }
        public string unit{  get; set; }
    }
}
