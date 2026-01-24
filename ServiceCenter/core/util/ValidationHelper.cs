using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.core.util
{
    internal class ValidationHelper
    {
        public static void onlyDigit(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                UIHelper.toast("Invalid Type", "only allows digit input");
                e.Handled = true;
            } 
        }
        public static bool isNullInput(Control parent, out string message)
        {
            message = string.Empty;
            if(parent != null)
            {
                foreach(Control ctrl in parent.Controls)
                {
                    switch (ctrl)
                    {
                        case TextBox txt when string.IsNullOrWhiteSpace(txt.Text):
                            message = "Required text input is missing or emty";
                            return true;
                        case ComboBox cmb when cmb.SelectedIndex < 0:
                            message = "No item has been selected from the required dropdown list";
                            return true;
                        case NumericUpDown nmc when nmc.Value <= 0:
                            message = "Invalid numeric value provide";
                            return true;
                        case PictureBox pct when pct.Image == null:
                            message = "Required image has been not provided";
                            return true;
                    }
                    if (ctrl.HasChildren && isNullInput(ctrl, out message)) return true;
                }
            }
            return false;
        }
        public static bool checkEmail(string email)
        {
            if (!email.Trim().EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                UIHelper.toast("Invalid Email", "Sorry, your email is in incorrect format");
                return true;
            }
            return false;
        }
        public static bool checkPhone(string phone)
        {
            if (!phone.Trim().StartsWith("08") || (phone.Length<10 || phone.Length>14))
            {
                UIHelper.toast("Invalid Phone Number", "Sorry, your phone number is in incorrect format");
                return true;
            }
            return false;
        }
    }
}
