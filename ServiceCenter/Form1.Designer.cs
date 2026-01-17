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
            pnlTitle = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            navPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUserManagement = new Button();
            btnServiceOrder = new Button();
            btnServiceProcess = new Button();
            btnServiceWorkshop = new Button();
            btnServicePayment = new Button();
            pctProfile = new PictureBox();
            pnlProfile = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            tmrProfileSlide = new System.Windows.Forms.Timer(components);
            pnlActivity = new Panel();
            tmrTitleSlide = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            btnStockManagemtn = new Button();
            navInfo.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnlTitle.SuspendLayout();
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
            flowLayoutPanel2.Location = new Point(83, 9);
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
            txtTime.Location = new Point(1490, 8);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(53, 25);
            txtTime.TabIndex = 0;
            txtTime.Text = "Time";
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(29, 31, 31);
            pnlTitle.Controls.Add(btnClose);
            pnlTitle.Controls.Add(pictureBox1);
            pnlTitle.Controls.Add(label1);
            pnlTitle.ForeColor = Color.White;
            pnlTitle.Location = new Point(83, -44);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1719, 56);
            pnlTitle.TabIndex = 2;
            pnlTitle.MouseEnter += pnlTitle_MouseEnter;
            pnlTitle.MouseLeave += pnlTitle_MouseLeave;
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
            btnClose.Location = new Point(1670, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 39);
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
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(83, 1005);
            navPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(29, 31, 31);
            flowLayoutPanel1.Controls.Add(btnUserManagement);
            flowLayoutPanel1.Controls.Add(btnServiceOrder);
            flowLayoutPanel1.Controls.Add(btnServiceProcess);
            flowLayoutPanel1.Controls.Add(btnServiceWorkshop);
            flowLayoutPanel1.Controls.Add(btnServicePayment);
            flowLayoutPanel1.Controls.Add(btnStockManagemtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(83, 943);
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
            btnUserManagement.Tag = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click_1;
            // 
            // btnServiceOrder
            // 
            btnServiceOrder.BackColor = Color.FromArgb(29, 31, 31);
            btnServiceOrder.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnServiceOrder.FlatAppearance.BorderSize = 0;
            btnServiceOrder.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnServiceOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnServiceOrder.FlatStyle = FlatStyle.Flat;
            btnServiceOrder.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceOrder.ForeColor = Color.White;
            btnServiceOrder.Image = (Image)resources.GetObject("btnServiceOrder.Image");
            btnServiceOrder.Location = new Point(6, 81);
            btnServiceOrder.Margin = new Padding(6, 3, 3, 3);
            btnServiceOrder.Name = "btnServiceOrder";
            btnServiceOrder.Size = new Size(72, 72);
            btnServiceOrder.TabIndex = 0;
            btnServiceOrder.Tag = "Service Order";
            btnServiceOrder.UseVisualStyleBackColor = false;
            btnServiceOrder.Click += btnServiceOrder_Click;
            // 
            // btnServiceProcess
            // 
            btnServiceProcess.BackColor = Color.FromArgb(29, 31, 31);
            btnServiceProcess.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnServiceProcess.FlatAppearance.BorderSize = 0;
            btnServiceProcess.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnServiceProcess.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnServiceProcess.FlatStyle = FlatStyle.Flat;
            btnServiceProcess.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceProcess.ForeColor = Color.White;
            btnServiceProcess.Image = Properties.Resources.icons8_gear_50_1_;
            btnServiceProcess.Location = new Point(6, 159);
            btnServiceProcess.Margin = new Padding(6, 3, 3, 3);
            btnServiceProcess.Name = "btnServiceProcess";
            btnServiceProcess.Size = new Size(72, 72);
            btnServiceProcess.TabIndex = 0;
            btnServiceProcess.Tag = "Service Process";
            btnServiceProcess.UseVisualStyleBackColor = false;
            btnServiceProcess.Click += btnServiceProcess_Click;
            // 
            // btnServiceWorkshop
            // 
            btnServiceWorkshop.BackColor = Color.FromArgb(29, 31, 31);
            btnServiceWorkshop.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnServiceWorkshop.FlatAppearance.BorderSize = 0;
            btnServiceWorkshop.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnServiceWorkshop.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnServiceWorkshop.FlatStyle = FlatStyle.Flat;
            btnServiceWorkshop.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceWorkshop.ForeColor = Color.White;
            btnServiceWorkshop.Image = Properties.Resources.icons8_car_48;
            btnServiceWorkshop.Location = new Point(6, 237);
            btnServiceWorkshop.Margin = new Padding(6, 3, 3, 3);
            btnServiceWorkshop.Name = "btnServiceWorkshop";
            btnServiceWorkshop.Size = new Size(72, 72);
            btnServiceWorkshop.TabIndex = 0;
            btnServiceWorkshop.Tag = "Service Workshop";
            btnServiceWorkshop.UseVisualStyleBackColor = false;
            btnServiceWorkshop.Click += btnRepair_Click;
            // 
            // btnServicePayment
            // 
            btnServicePayment.BackColor = Color.FromArgb(29, 31, 31);
            btnServicePayment.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnServicePayment.FlatAppearance.BorderSize = 0;
            btnServicePayment.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnServicePayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnServicePayment.FlatStyle = FlatStyle.Flat;
            btnServicePayment.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicePayment.ForeColor = Color.White;
            btnServicePayment.Image = Properties.Resources.icons8_payment_48;
            btnServicePayment.Location = new Point(6, 315);
            btnServicePayment.Margin = new Padding(6, 3, 3, 3);
            btnServicePayment.Name = "btnServicePayment";
            btnServicePayment.Size = new Size(72, 72);
            btnServicePayment.TabIndex = 0;
            btnServicePayment.Tag = "Service Payment";
            btnServicePayment.UseVisualStyleBackColor = false;
            btnServicePayment.Click += btnServicePayment_Click;
            // 
            // pctProfile
            // 
            pctProfile.ErrorImage = Properties.Resources.icons8_user_100;
            pctProfile.Image = Properties.Resources.icons8_user_100;
            pctProfile.Location = new Point(16, 949);
            pctProfile.Name = "pctProfile";
            pctProfile.Size = new Size(50, 50);
            pctProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfile.TabIndex = 0;
            pctProfile.TabStop = false;
            pctProfile.Tag = "My Profile";
            pctProfile.MouseClick += pctProfile_MouseClick;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Black;
            pnlProfile.Location = new Point(-635, 7);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(635, 998);
            pnlProfile.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // tmrProfileSlide
            // 
            tmrProfileSlide.Interval = 1;
            tmrProfileSlide.Tick += tmrProfileSlide_Tick;
            // 
            // pnlActivity
            // 
            pnlActivity.Location = new Point(83, 12);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1719, 993);
            pnlActivity.TabIndex = 6;
            // 
            // tmrTitleSlide
            // 
            tmrTitleSlide.Interval = 1;
            tmrTitleSlide.Tick += tmrTitleSlide_Tick;
            // 
            // btnStockManagemtn
            // 
            btnStockManagemtn.BackColor = Color.FromArgb(29, 31, 31);
            btnStockManagemtn.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnStockManagemtn.FlatAppearance.BorderSize = 0;
            btnStockManagemtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnStockManagemtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnStockManagemtn.FlatStyle = FlatStyle.Flat;
            btnStockManagemtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockManagemtn.ForeColor = Color.White;
            btnStockManagemtn.Image = Properties.Resources.icons8_stock_48;
            btnStockManagemtn.Location = new Point(6, 393);
            btnStockManagemtn.Margin = new Padding(6, 3, 3, 3);
            btnStockManagemtn.Name = "btnStockManagemtn";
            btnStockManagemtn.Size = new Size(72, 72);
            btnStockManagemtn.TabIndex = 0;
            btnStockManagemtn.Tag = "Stock Management";
            btnStockManagemtn.UseVisualStyleBackColor = false;
            btnStockManagemtn.Click += btnStockManagemtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 1050);
            Controls.Add(pnlTitle);
            Controls.Add(navPanel);
            Controls.Add(pnlProfile);
            Controls.Add(navInfo);
            Controls.Add(pnlActivity);
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
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            navPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel navInfo;
        private Panel pnlTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel navPanel;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label txtUsername;
        private Label txtRole;
        private Label label2;
        private Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnUserManagement;
        private Button btnServiceOrder;
        private PictureBox pctProfile;
        private Panel pnlProfile;
        private System.Windows.Forms.Timer tmrProfileSlide;
        private Panel pnlActivity;
        private System.Windows.Forms.Timer tmrTitleSlide;
        private ToolTip toolTip1;
        private Button btnServiceProcess;
        private Button btnServiceWorkshop;
        private Button btnServicePayment;
        private Button btnStockManagemtn;
    }
}
