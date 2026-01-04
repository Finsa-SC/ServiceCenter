using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.core.util
{
    internal class ValidationHelper
    {
        public static bool isNullInput(Control parent)
        {
            if(parent != null)
            {
                foreach(Control ctrl in parent.Controls)
                {
                    if(ctrl is TextBox txt)
                    {
                        if (txt.Tag?.ToString().Contains("nullable") == true) continue;
                        if (string.IsNullOrWhiteSpace(txt.Text)) 
                        { 
                            UIHelper.toast("Invalid Input", "Please Fill All of Input");
                            return true; 
                        }
                    }
                    if(ctrl is PictureBox pct)
                    {
                        if (pct.Tag?.ToString().Contains("nullable") == true) continue;
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
