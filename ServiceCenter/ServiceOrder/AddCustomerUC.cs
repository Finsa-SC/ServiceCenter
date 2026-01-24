using ServiceCenter.core.network;
using ServiceCenter.core.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ServiceCenter.ServiceOrder
{
    public partial class AddCustomerUC : UserControl
    {
        public event Action customerAdded;
        public AddCustomerUC(string customer)
        {
            InitializeComponent();
            txtName.Text = customer;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyDigit(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.isNullInput(this, out string message))
            {
                UIHelper.toast("Invalid Input", message);
                return;
            }
            if (ValidationHelper.checkEmail(txtEmail.Text)) return;
            if (ValidationHelper.checkPhone(txtNumber.Text)) return;
            string code = CodeGenerator.codeGenerator("CST", "SELECT MAX(customer_code) FROM customers");
            string query = "INSERT INTO customers (customer_code, full_name, phone, email, address, created_at) VALUES (@c, @f, @p, @e, @a, GETDATE())";
            int i = DBHelper.executeNonQuery(query,
                new SqlParameter("@c", code),
                new SqlParameter("@f", txtName.Text.Trim()),
                new SqlParameter("@p", txtNumber.Text.Trim()),
                new SqlParameter("@e", txtEmail.Text.Trim()),
                new SqlParameter("@a", txtAddress.Text.Trim())
            );
            if (i > 0) 
            {
                UIHelper.toast("Success", "Success Adding Customer");
                customerAdded?.Invoke();
            }
        }
    }
}
