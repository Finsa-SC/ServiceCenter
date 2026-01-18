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
    public partial class LoadingForm : Form
    {
        Random random = new Random();
        public LoadingForm()
        {
            InitializeComponent();
            tmrProgress.Start();
            tmrLdngAnimation.Start();
            tmrDetail.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlProgress.Width >= panel1.Width)
            {
                pnlProgress.Width = panel1.Width;
                ldngImage.Left = panel1.Width + 35;
                tmrDetail.Stop();
                lblDetail.Text = "Starting Up Application";
                tmrWaiting.Start();
                tmrProgress.Stop();
            }
            else
            {
                bool isProgressUp = random.Next(0, 15) == 1;
                if (isProgressUp)
                {
                    bool highIncrement = random.Next(0, 25) == 1;
                    int increment = random.Next(1, 10);
                    if (highIncrement) increment = random.Next(100, 500);
                    pnlProgress.Width += increment;
                    ldngImage.Left = pnlProgress.Width + 35;

                    int percent = (int)((double)pnlProgress.Width / panel1.Width * 100);
                    if(percent > 100) percent = 100;
                    lblPercent.Text = percent.ToString();
                }
            }
        }

        int animationSpeed = 1;
        private void tmrLdngAnimation_Tick(object sender, EventArgs e)
        {
            if (ldngImage.Top < 830)
            {
                tmrLdngAnimation.Stop();
                tmrAnimationDown.Start();
            }
            else
            {
                ldngImage.Top -= animationSpeed;
            }
        }
        private void tmrAnimationDown_Tick(object sender, EventArgs e)
        {
            if (ldngImage.Top > 850)
            {
                tmrAnimationDown.Stop();
                tmrLdngAnimation.Start();
            }
            else
            {
                ldngImage.Top += animationSpeed;
            }
        }

        List<string> detailList = new List<string>()
        {
            "Connecting to database",
            "Fetching sparepart inventory",
            "Synchronizing supplier data",
            "Loading high-definition assets",
            "Optimizing rendering engine",
            "Initializing user interface",
            "Securing encrypted connection",
            "Updating local cache",
            "Retrieving service history",
            "Compiling shaders",
            "Loading mechanic profiles",
            "Indexing transaction logs",
            "Checking network latency",
            "Preparing workstation"
        };

        int index;
        private void tmrDetail_Tick(object sender, EventArgs e)
        {
            bool isProgressUp = random.Next(0, 15) == 1;
            if (isProgressUp)
            {
                index = (index + 1) % detailList.Count;
                if (index > detailList.Count) index = 0;
                lblDetail.Text = detailList[index] + "...";
            }
        }

        private void tmrWaiting_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
