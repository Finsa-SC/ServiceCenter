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
    public partial class AddVehicleUC : UserControl
    {
        public AddVehicleUC(string model)
        {
            InitializeComponent();
            txtMode.Text = model;
            loadYear();
        }

        private void loadYear()
        {
            cmbYears.Items.Clear();
            for(int years = DateTime.Now.Year; years >= 1880; years--)
            {
                cmbYears.Items.Add(years);
            }
        }
    }
}
