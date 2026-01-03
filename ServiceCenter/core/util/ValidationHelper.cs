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
                        if (string.IsNullOrWhiteSpace(txt.Text)) { MessageBox.Show("Please Fill All of Input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; };
                    }
                    if(ctrl is PictureBox pct)
                    {
                        if (pct.Tag?.ToString().Contains("nullable") == true) continue;
                        if(pct.Image == null) { MessageBox.Show("Please Insert Your Image Actually", "Blank Image", MessageBoxButtons.OK, MessageBoxIcon.Error); return true; }
                        ;
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
