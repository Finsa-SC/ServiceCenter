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
            pictureBox2 = new PictureBox();
            btnEditName = new Button();
            txtPhone = new Label();
            txtRole = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            pctProfil = new PictureBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctProfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 23, 23);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pictureBox2);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 718);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnEditName
            // 
            btnEditName.BackgroundImage = (Image)resources.GetObject("btnEditName.BackgroundImage");
            btnEditName.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditName.FlatAppearance.BorderSize = 0;
            btnEditName.FlatStyle = FlatStyle.Flat;
            btnEditName.Location = new Point(548, 380);
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
            txtPhone.Location = new Point(134, 718);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(82, 32);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "Phone";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new Font("Segoe UI", 12F);
            txtRole.Location = new Point(66, 604);
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
            label5.Location = new Point(85, 670);
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
            label3.Location = new Point(85, 556);
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
            label1.Location = new Point(85, 331);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // pctProfil
            // 
            pctProfil.Image = (Image)resources.GetObject("pctProfil.Image");
            pctProfil.Location = new Point(239, 115);
            pctProfil.Name = "pctProfil";
            pctProfil.Size = new Size(158, 158);
            pctProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfil.TabIndex = 0;
            pctProfil.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(22, 23, 23);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(66, 379);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(476, 32);
            txtUsername.TabIndex = 5;
            txtUsername.Text = "Username";
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
    }
}
