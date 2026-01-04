namespace ServiceCenter.UserNamagement
{
    partial class UserForm
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
            txtFullName = new TextBox();
            label1 = new Label();
            pctProfile = new PictureBox();
            btnImport = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbRole = new ComboBox();
            cmbStatus = new ComboBox();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtCPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctProfile).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(29, 31, 31);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(4, 34);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(464, 37);
            txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // pctProfile
            // 
            pctProfile.Image = Properties.Resources.icons8_user_100;
            pctProfile.Location = new Point(60, 103);
            pctProfile.Margin = new Padding(4);
            pctProfile.Name = "pctProfile";
            pctProfile.Size = new Size(341, 341);
            pctProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfile.TabIndex = 2;
            pctProfile.TabStop = false;
            pctProfile.Tag = "nullable";
            // 
            // btnImport
            // 
            btnImport.FlatAppearance.BorderColor = Color.FromArgb(96, 232, 254);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(53, 488);
            btnImport.Margin = new Padding(4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(372, 47);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import Photo";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(29, 31, 31);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(4, 119);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(464, 37);
            txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 85);
            label2.Margin = new Padding(4, 10, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(29, 31, 31);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(4, 204);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(464, 37);
            txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 170);
            label3.Margin = new Padding(4, 10, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(29, 31, 31);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(4, 459);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(464, 37);
            txtPhone.TabIndex = 0;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 425);
            label4.Margin = new Padding(4, 10, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 30);
            label4.TabIndex = 1;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(981, 63);
            label5.Margin = new Padding(4, 10, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 30);
            label5.TabIndex = 1;
            label5.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(29, 31, 31);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.ForeColor = Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(981, 97);
            cmbRole.Margin = new Padding(4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(241, 38);
            cmbRole.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(29, 31, 31);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(981, 183);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(241, 38);
            cmbStatus.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(981, 149);
            label6.Margin = new Padding(4, 10, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 30);
            label6.TabIndex = 1;
            label6.Text = "Status";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(664, 604);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(276, 56);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(946, 604);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(276, 56);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtFullName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtEmail);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtUsername);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtPassword);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtCPassword);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txtPhone);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(454, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 501);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 255);
            label7.Margin = new Padding(4, 10, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 30);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(29, 31, 31);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(4, 289);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'Ὧ';
            txtPassword.Size = new Size(464, 37);
            txtPassword.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 340);
            label8.Margin = new Padding(4, 10, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(192, 30);
            label8.TabIndex = 6;
            label8.Text = "Confirm Password";
            // 
            // txtCPassword
            // 
            txtCPassword.BackColor = Color.FromArgb(29, 31, 31);
            txtCPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCPassword.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCPassword.ForeColor = Color.White;
            txtCPassword.Location = new Point(4, 374);
            txtCPassword.Margin = new Padding(4);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.PasswordChar = 'Ὧ';
            txtCPassword.Size = new Size(464, 37);
            txtCPassword.TabIndex = 5;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 31, 31);
            ClientSize = new Size(1245, 687);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnImport);
            Controls.Add(pctProfile);
            Controls.Add(cmbStatus);
            Controls.Add(label6);
            Controls.Add(cmbRole);
            Controls.Add(label5);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pctProfile).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label label1;
        private PictureBox pctProfile;
        private Button btnImport;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private ComboBox cmbRole;
        private ComboBox cmbStatus;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtCPassword;
    }
}