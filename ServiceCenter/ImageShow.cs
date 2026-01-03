using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class ImageShow : Form
    {
        private ProfileUC form = new ProfileUC();
        public ImageShow()
        {
            InitializeComponent();

            form.loadImage(pctProfile, UserSession.photo);
        }


    }
}
