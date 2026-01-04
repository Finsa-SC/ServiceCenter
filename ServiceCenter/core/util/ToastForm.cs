using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Timer = System.Windows.Forms.Timer;


namespace ServiceCenter.core.util
{
    public partial class ToastForm : Form
    {
        Timer slideTimer;
        Timer lifeTimer;
        bool showing = true;
        public ToastForm(string title, string message)
        {
            InitializeComponent();

            lblTitle.Text = title;
            lblText.Text = message;

            slideTimer = new Timer();
            slideTimer.Interval = 1;
            slideTimer.Tick += SlideTick;

            lifeTimer = new Timer();
            lifeTimer.Interval = 5000;
            lifeTimer.Tick += LifeTick;

            this.Load += ToastForm_Load;
        }
        private void ToastForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;

            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Left = 160;
            this.Top = screen.Bottom;

            slideTimer.Start();
            lifeTimer.Start();
            this.BringToFront();
        }

        private void SlideTick(object sender, EventArgs e)
        {
            int speed = 7;
            var screen = Screen.PrimaryScreen.WorkingArea;

            if (showing)
            {
                if (this.Top > screen.Bottom - this.Height - 70)
                    this.Top -= speed;
                else
                    slideTimer.Stop();
            }
            else
            {
                if (this.Top < screen.Bottom) 
                    this.Top += speed;
                else
                    this.Close();
            }
        }
        private void LifeTick(object sender, EventArgs e)
        {
            showing = false;
            slideTimer.Start();
            lifeTimer.Stop();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
