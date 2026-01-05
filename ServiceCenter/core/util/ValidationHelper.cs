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
                            UIHelper.toast("Invalid Decision", "Please Select Literally one option");
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
                    if (parent.HasChildren)
                    {
                        if(isNullInput(ctrl)) return true;
                    }
                }
            }
            return false;
        }
    }
}
