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
        public static bool isNullInput(Control parent)
        {
            if(parent != null)
            {
                foreach(Control ctrl in parent.Controls)
                {
                    if (ctrl.Tag?.ToString().Contains("nullable") == true) continue;
                    if(ctrl is TextBox txt)
                    {
                        if (string.IsNullOrWhiteSpace(txt.Text)) 
                        { 
                            UIHelper.toast("Invalid Input", "Please Fill All of Input");
                            return true; 
                        }
                    }
                    if(ctrl is ComboBox cmb)
                    {
                        if(cmb.SelectedIndex < 0)
                        {
                            UIHelper.toast("Invalid Decision", "Please Select Literally one Chose in Combo Box");
                            return true;
                        }
                    }
                    if(ctrl is PictureBox pct)
                    {
                        if(pct.Image == null) 
                        {
                            UIHelper.toast("Blank Image", "Please Insert Your Image Actually");
                            return true;
                        }
                    }
                    if(ctrl is NumericUpDown nmc)
                    {
                        if(nmc.Value <= 0)
                        {
                            UIHelper.toast("Invalid Value", "Please Set Your Number to Actual Number");
                            return true;
                        }
                    }
                    if (parent.HasChildren)
                    {
                        if(isNullInput(ctrl)) return true;
                    }
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
