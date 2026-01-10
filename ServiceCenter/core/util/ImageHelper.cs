using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.core.util
{
    internal class ImageHelper
    {
        public static void loadImage(PictureBox pct, string? img)
        {
            pct.Image?.Dispose();
            if(string.IsNullOrWhiteSpace(img) || !File.Exists(img)) pct.Image = Properties.Resources.icons8_user_100;

            try
            {
                using(Image image = Image.FromFile(img))
                {
                    pct.Image = new Bitmap(image);
                }
            }
            catch(Exception ex) 
            {
                UIHelper.toast("Failed Load", "Failed while load your Image");
                pct.Image = Properties.Resources.icons8_user_100;
            }
        }

        public static (DialogResult, string?) uploadImage()
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files | *.png;*.img;*.jpeg;*.jpg;";
                return (ofd.ShowDialog(),  ofd.FileName);
            }
        }
    }
}
