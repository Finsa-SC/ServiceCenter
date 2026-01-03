namespace ServiceCenter
{
    partial class ProfileUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUC));
            panel1 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            pnlOption = new Panel();
            btnDelete = new Button();
            btnShow = new Button();
            btnUp = new Button();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            btnCopyPhone = new Button();
            btnEditName = new Button();
            txtPhone = new Label();
            txtRole = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            pctProfil = new PictureBox();
            panel1.SuspendLayout();
            pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctProfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 23, 23);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pnlOption);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCopyPhone);
            panel1.Controls.Add(btnEditName);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pctProfil);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 957);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(251, 80, 97);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(251, 80, 97);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(14, 895);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(0, 3, 3, 3);
            btnLogout.Size = new Size(202, 50);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.TopCenter;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += btnLogout_MouseEnter;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(111, 45);
            label2.TabIndex = 7;
            label2.Text = "Profile";
            // 
            // pnlOption
            // 
            pnlOption.BackColor = Color.FromArgb(64, 64, 64);
            pnlOption.Controls.Add(btnDelete);
            pnlOption.Controls.Add(btnShow);
            pnlOption.Controls.Add(btnUp);
            pnlOption.Location = new Point(415, 133);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(198, 158);
            pnlOption.TabIndex = 6;
            pnlOption.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.MediumSlateBlue;
            btnDelete.Location = new Point(3, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 46);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete Image";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.MediumSlateBlue;
            btnShow.Location = new Point(3, 55);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(195, 46);
            btnShow.TabIndex = 0;
            btnShow.Text = "Show Image";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnUp
            // 
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.ForeColor = Color.MediumSlateBlue;
            btnUp.Location = new Point(3, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(195, 46);
            btnUp.TabIndex = 0;
            btnUp.Text = "Upload Image";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(22, 23, 23);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(52, 397);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(484, 32);
            txtUsername.TabIndex = 5;
            txtUsername.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 736);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnCopyPhone
            // 
            btnCopyPhone.BackgroundImage = (Image)resources.GetObject("btnCopyPhone.BackgroundImage");
            btnCopyPhone.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopyPhone.FlatAppearance.BorderSize = 0;
            btnCopyPhone.FlatStyle = FlatStyle.Flat;
            btnCopyPhone.Location = new Point(548, 732);
            btnCopyPhone.Name = "btnCopyPhone";
            btnCopyPhone.Size = new Size(35, 34);
            btnCopyPhone.TabIndex = 3;
            btnCopyPhone.UseVisualStyleBackColor = true;
            btnCopyPhone.Click += btnCopyPhone_Click;
            // 
            // btnEditName
            // 
            btnEditName.BackgroundImage = (Image)resources.GetObject("btnEditName.BackgroundImage");
            btnEditName.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditName.FlatAppearance.BorderSize = 0;
            btnEditName.FlatStyle = FlatStyle.Flat;
            btnEditName.Location = new Point(548, 398);
            btnEditName.Name = "btnEditName";
            btnEditName.Size = new Size(35, 34);
            btnEditName.TabIndex = 3;
            btnEditName.UseVisualStyleBackColor = true;
            btnEditName.Click += btnEditName_Click;
            // 
            // txtPhone
            // 
            txtPhone.AutoSize = true;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(114, 734);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(82, 32);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "Phone";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new Font("Segoe UI", 12F);
            txtRole.Location = new Point(52, 622);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(60, 32);
            txtRole.TabIndex = 2;
            txtRole.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(162, 162, 162);
            label5.Location = new Point(54, 688);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 1;
            label5.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(162, 162, 162);
            label3.Location = new Point(54, 574);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(162, 162, 162);
            label1.Location = new Point(54, 349);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // pctProfil
            // 
            pctProfil.Location = new Point(220, 133);
            pctProfil.Name = "pctProfil";
            pctProfil.Size = new Size(180, 180);
            pctProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfil.TabIndex = 0;
            pctProfil.TabStop = false;
            pctProfil.MouseClick += pctProfil_MouseClick;
            // 
            // ProfileUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProfileUC";
            Size = new Size(1602, 957);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctProfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pctProfil;
        private Button btnEditName;
        private Label txtRole;
        private Label label3;
        private PictureBox pictureBox2;
        private Label txtPhone;
        private Label label5;
        private TextBox txtUsername;
        private Panel pnlOption;
        private Button btnShow;
        private Button btnUp;
        private Button btnDelete;
        private Label label2;
        private Button btnCopyPhone;
        private Button btnLogout;
    }
}
