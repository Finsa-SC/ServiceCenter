namespace ServiceCenter
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            pnlProgress = new Panel();
            tmrProgress = new System.Windows.Forms.Timer(components);
            ldngImage = new PictureBox();
            tmrLdngAnimation = new System.Windows.Forms.Timer(components);
            tmrAnimationDown = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            lblDetail = new Label();
            tmrDetail = new System.Windows.Forms.Timer(components);
            tmrWaiting = new System.Windows.Forms.Timer(components);
            lblPercent = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ldngImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = Color.White;
            pnlProgress.Location = new Point(76, 941);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(0, 11);
            pnlProgress.TabIndex = 0;
            // 
            // tmrProgress
            // 
            tmrProgress.Interval = 1;
            tmrProgress.Tick += timer1_Tick;
            // 
            // ldngImage
            // 
            ldngImage.Image = (Image)resources.GetObject("ldngImage.Image");
            ldngImage.Location = new Point(48, 850);
            ldngImage.Name = "ldngImage";
            ldngImage.Size = new Size(76, 75);
            ldngImage.SizeMode = PictureBoxSizeMode.Zoom;
            ldngImage.TabIndex = 1;
            ldngImage.TabStop = false;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(853, 958);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblDetail
            // 
            lblDetail.ForeColor = Color.White;
            lblDetail.Location = new Point(654, 991);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(463, 38);
            lblDetail.TabIndex = 3;
            lblDetail.Text = "Loading...";
            lblDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrDetail
            // 
            tmrDetail.Interval = 50;
            tmrDetail.Tick += tmrDetail_Tick;
            // 
            // tmrWaiting
            // 
            tmrWaiting.Interval = 3000;
            tmrWaiting.Tick += tmrWaiting_Tick;
            // 
            // lblPercent
            // 
            lblPercent.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.ForeColor = Color.White;
            lblPercent.Location = new Point(1647, 914);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(59, 27);
            lblPercent.TabIndex = 4;
            lblPercent.Text = "0";
            lblPercent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(76, 941);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(76, 949);
            panel2.Name = "panel2";
            panel2.Size = new Size(1650, 1);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1699, 913);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 6;
            label1.Text = "%";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(649, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(488, 364);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fairy_icon;
            pictureBox3.Location = new Point(832, 351);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(1726, 941);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 9);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 9);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(96, 232, 254);
            label2.Location = new Point(749, 654);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 10;
            label2.Text = "Service Center";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 40F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(758, 550);
            label3.Name = "label3";
            label3.Size = new Size(265, 141);
            label3.TabIndex = 11;
            label3.Text = "Fairy";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 29, 52);
            ClientSize = new Size(1802, 1050);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlProgress);
            Controls.Add(pictureBox1);
            Controls.Add(lblDetail);
            Controls.Add(label1);
            Controls.Add(lblPercent);
            Controls.Add(ldngImage);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)ldngImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlProgress;
        private System.Windows.Forms.Timer tmrProgress;
        private PictureBox ldngImage;
        private System.Windows.Forms.Timer tmrLdngAnimation;
        private System.Windows.Forms.Timer tmrAnimationDown;
        private PictureBox pictureBox1;
        private Label lblDetail;
        private System.Windows.Forms.Timer tmrDetail;
        private System.Windows.Forms.Timer tmrWaiting;
        private Label lblPercent;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
    }
}