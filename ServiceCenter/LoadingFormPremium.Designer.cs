namespace ServiceCenter
{
    partial class LoadingFormPremium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingFormPremium));
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblDetail = new Label();
            label1 = new Label();
            lblPercent = new Label();
            ldngImage = new PictureBox();
            tmrProgress = new System.Windows.Forms.Timer(components);
            tmrLdngAnimation = new System.Windows.Forms.Timer(components);
            tmrAnimationDown = new System.Windows.Forms.Timer(components);
            tmrDetail = new System.Windows.Forms.Timer(components);
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            pnlProgress = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ldngImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(78, 936);
            panel2.Name = "panel2";
            panel2.Size = new Size(1650, 1);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(78, 928);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 1);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(855, 950);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblDetail
            // 
            lblDetail.ForeColor = Color.White;
            lblDetail.Location = new Point(656, 983);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(463, 38);
            lblDetail.TabIndex = 12;
            lblDetail.Text = "Loading...";
            lblDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1701, 928);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 16;
            label1.Text = "%";
            // 
            // lblPercent
            // 
            lblPercent.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.ForeColor = Color.White;
            lblPercent.Location = new Point(1649, 906);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(59, 27);
            lblPercent.TabIndex = 13;
            lblPercent.Text = "0";
            lblPercent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ldngImage
            // 
            ldngImage.Image = (Image)resources.GetObject("ldngImage.Image");
            ldngImage.Location = new Point(50, 842);
            ldngImage.Name = "ldngImage";
            ldngImage.Size = new Size(76, 75);
            ldngImage.SizeMode = PictureBoxSizeMode.Zoom;
            ldngImage.TabIndex = 10;
            ldngImage.TabStop = false;
            // 
            // tmrProgress
            // 
            tmrProgress.Interval = 1;
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // tmrLdngAnimation
            // 
            tmrLdngAnimation.Interval = 40;
            tmrLdngAnimation.Tick += tmrLdngAnimation_Tick;
            // 
            // tmrAnimationDown
            // 
            tmrAnimationDown.Interval = 40;
            tmrAnimationDown.Tick += tmrAnimationDown_Tick;
            // 
            // tmrDetail
            // 
            tmrDetail.Interval = 50;
            tmrDetail.Tick += tmrDetail_Tick;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1802, 1033);
            axWindowsMediaPlayer1.TabIndex = 18;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = Color.White;
            pnlProgress.Location = new Point(79, 927);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(0, 10);
            pnlProgress.TabIndex = 19;
            // 
            // LoadingFormPremium
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 29, 52);
            ClientSize = new Size(1802, 1033);
            Controls.Add(pnlProgress);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblDetail);
            Controls.Add(label1);
            Controls.Add(lblPercent);
            Controls.Add(ldngImage);
            Controls.Add(axWindowsMediaPlayer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingFormPremium";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingFormPremium";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ldngImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblDetail;
        private Label label1;
        private Label lblPercent;
        private PictureBox ldngImage;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Timer tmrLdngAnimation;
        private System.Windows.Forms.Timer tmrAnimationDown;
        private System.Windows.Forms.Timer tmrDetail;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel pnlProgress;
    }
}