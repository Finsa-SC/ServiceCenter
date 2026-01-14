using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.ServiceWorkshop
{
    internal class CartModel
    {
        public int spareId { get; set; }
        [DisplayName("Sparepart Code")]
        public string sparepartCode {  get; set; }
        [DisplayName("Sparepart Name")]
        public string sparepartName { get; set; }
        [DisplayName("Quantity")]
        public int qty {  get; set; }
        [DisplayName("Unit")]
        public string unit { get; set; }
        [Browsable(false)]
        public decimal unitPrice { get; set; }
        [DisplayName("Price")]
        public decimal price => unitPrice * qty;
    }
}
