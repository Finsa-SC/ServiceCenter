using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.ServiceOrder
{
    public partial class AddCustomerUC : UserControl
    {
        public AddCustomerUC(string customer)
        {
            InitializeComponent();
            txtName.Text = customer;
        }
    }
}
