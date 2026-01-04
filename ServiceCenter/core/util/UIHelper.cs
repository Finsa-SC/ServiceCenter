using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.core.util
{
    internal class UIHelper
    {
        public static void toast(string title, string message)
        {
            ToastForm form = new ToastForm(title, message);
            form.BringToFront();
            form.Activate();
            form.Show();
        }
    }
}
