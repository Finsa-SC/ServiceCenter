namespace ServiceCenter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            developerLink = new LinkLabel();
            btnLogin = new Button();
            lblForgotPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(96, 232, 254);
            label1.Location = new Point(142, 344);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 1;
            label1.Text = "Service Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 30F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 260);
            label2.Name = "label2";
            label2.Size = new Size(197, 105);
            label2.TabIndex = 2;
            label2.Text = "Fairy";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(37, 533);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '◆';
            txtPassword.PlaceholderText = " Password...";
            txtPassword.Size = new Size(393, 42);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "agus080200";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Black;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(37, 455);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email...";
            txtEmail.Size = new Size(393, 42);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "agus@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 745);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "Powered by";
            // 
            // developerLink
            // 
            developerLink.AutoSize = true;
            developerLink.LinkColor = Color.Gray;
            developerLink.Location = new Point(200, 745);
            developerLink.Name = "developerLink";
            developerLink.Size = new Size(166, 25);
            developerLink.TabIndex = 6;
            developerLink.TabStop = true;
            developerLink.Text = "Finsa Kusuma Putra";
            developerLink.VisitedLinkColor = Color.Silver;
            developerLink.LinkClicked += developerLink_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(96, 232, 254);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(309, 604);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Location = new Point(126, 676);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(197, 25);
            lblForgotPass.TabIndex = 8;
            lblForgotPass.Text = "Forgot your password?";
            lblForgotPass.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(461, 837);
            Controls.Add(lblForgotPass);
            Controls.Add(btnLogin);
            Controls.Add(developerLink);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label3;
        private LinkLabel developerLink;
        private Button btnLogin;
        private Label lblForgotPass;
    }
}