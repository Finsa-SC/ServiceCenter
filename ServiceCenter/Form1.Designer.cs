namespace ServiceCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            navInfo = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtUsername = new Label();
            label2 = new Label();
            txtRole = new Label();
            txtTime = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            navPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUserManagement = new Button();
            btnAssignment = new Button();
            pctProfile = new PictureBox();
            pnlActivity = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            navInfo.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            navPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctProfile).BeginInit();
            SuspendLayout();
            // 
            // navInfo
            // 
            navInfo.BackColor = Color.FromArgb(29, 31, 31);
            navInfo.Controls.Add(flowLayoutPanel2);
            navInfo.Controls.Add(txtTime);
            navInfo.Dock = DockStyle.Bottom;
            navInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navInfo.ForeColor = Color.White;
            navInfo.Location = new Point(0, 1005);
            navInfo.Name = "navInfo";
            navInfo.Size = new Size(1802, 45);
            navInfo.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(txtUsername);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(txtRole);
            flowLayoutPanel2.Location = new Point(83, 11);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(300, 34);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(3, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(96, 25);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 0);
            label2.Name = "label2";
            label2.Size = new Size(17, 25);
            label2.TabIndex = 1;
            label2.Text = "|";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Location = new Point(128, 0);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(49, 25);
            txtRole.TabIndex = 0;
            txtRole.Text = "Role";
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Location = new Point(1490, 11);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(53, 25);
            txtTime.TabIndex = 0;
            txtTime.Text = "Time";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 31);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1802, 48);
            panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1758, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 39);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 0;
            label1.Text = "Fairy Service Center";
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(29, 31, 31);
            navPanel.Controls.Add(flowLayoutPanel1);
            navPanel.Controls.Add(pctProfile);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(0, 48);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(83, 957);
            navPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(29, 31, 31);
            flowLayoutPanel1.Controls.Add(btnUserManagement);
            flowLayoutPanel1.Controls.Add(btnAssignment);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(83, 855);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(29, 31, 31);
            btnUserManagement.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnUserManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Image = (Image)resources.GetObject("btnUserManagement.Image");
            btnUserManagement.Location = new Point(6, 3);
            btnUserManagement.Margin = new Padding(6, 3, 3, 3);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(72, 72);
            btnUserManagement.TabIndex = 0;
            btnUserManagement.Tag = "1";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click_1;
            // 
            // btnAssignment
            // 
            btnAssignment.BackColor = Color.FromArgb(29, 31, 31);
            btnAssignment.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnAssignment.FlatAppearance.BorderSize = 0;
            btnAssignment.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnAssignment.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAssignment.FlatStyle = FlatStyle.Flat;
            btnAssignment.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignment.ForeColor = Color.White;
            btnAssignment.Location = new Point(6, 81);
            btnAssignment.Margin = new Padding(6, 3, 3, 3);
            btnAssignment.Name = "btnAssignment";
            btnAssignment.Size = new Size(72, 72);
            btnAssignment.TabIndex = 0;
            btnAssignment.Tag = "1";
            btnAssignment.Text = "Users Management";
            btnAssignment.UseVisualStyleBackColor = false;
            // 
            // pctProfile
            // 
            pctProfile.Location = new Point(17, 890);
            pctProfile.Name = "pctProfile";
            pctProfile.Size = new Size(50, 50);
            pctProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfile.TabIndex = 0;
            pctProfile.TabStop = false;
            pctProfile.MouseClick += pctProfile_MouseClick;
            // 
            // pnlActivity
            // 
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new Point(83, 48);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1719, 957);
            pnlActivity.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 1050);
            Controls.Add(pnlActivity);
            Controls.Add(navPanel);
            Controls.Add(panel1);
            Controls.Add(navInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            navInfo.ResumeLayout(false);
            navInfo.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            navPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel navInfo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel navPanel;
        private Button btnClose;
        private Panel pnlActivity;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label txtUsername;
        private Label txtRole;
        private Label label2;
        private Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnUserManagement;
        private Button btnAssignment;
        private PictureBox pctProfile;
    }
}
