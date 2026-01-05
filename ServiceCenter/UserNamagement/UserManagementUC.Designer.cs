namespace ServiceCenter
{
    partial class UserManagementUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementUC));
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            btnAdd = new Button();
            cmbRole = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            cmbStatus = new ComboBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dteDate = new DateTimePicker();
            chkDte = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 248, 254);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(46, 65, 88);
            dataGridViewCellStyle2.Padding = new Padding(0, 6, 0, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(46, 65, 88);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(37, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1634, 859);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(113, 31);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "   Search...";
            txtName.Size = new Size(419, 39);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 67, 88);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1440, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 44);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.System;
            cmbRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(619, 30);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(158, 40);
            cmbRole.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(576, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.System;
            cmbStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(899, 30);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(158, 40);
            cmbStatus.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Window;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(856, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Window;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1107, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // dteDate
            // 
            dteDate.CustomFormat = "MMMMd, yyyy";
            dteDate.Enabled = false;
            dteDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dteDate.Format = DateTimePickerFormat.Custom;
            dteDate.Location = new Point(1145, 30);
            dteDate.MaxDate = new DateTime(2026, 1, 4, 0, 0, 0, 0);
            dteDate.Name = "dteDate";
            dteDate.Size = new Size(264, 37);
            dteDate.TabIndex = 6;
            dteDate.Value = new DateTime(2026, 1, 4, 0, 0, 0, 0);
            // 
            // chkDte
            // 
            chkDte.AutoSize = true;
            chkDte.FlatAppearance.BorderColor = Color.Red;
            chkDte.FlatAppearance.BorderSize = 3;
            chkDte.FlatAppearance.CheckedBackColor = Color.Red;
            chkDte.FlatStyle = FlatStyle.Flat;
            chkDte.Font = new Font("Segoe UI", 7F);
            chkDte.Location = new Point(1145, 68);
            chkDte.Name = "chkDte";
            chkDte.Size = new Size(178, 23);
            chkDte.TabIndex = 7;
            chkDte.Text = "adjust according to date";
            chkDte.UseVisualStyleBackColor = true;
            chkDte.CheckedChanged += chkDte_CheckedChanged;
            // 
            // UserManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkDte);
            Controls.Add(dteDate);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbStatus);
            Controls.Add(cmbRole);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Margin = new Padding(20, 3, 20, 20);
            Name = "UserManagementUC";
            Padding = new Padding(20, 3, 20, 20);
            Size = new Size(1719, 993);
            Load += UserManagementUC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private Button btnAdd;
        private ComboBox cmbRole;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmbStatus;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DateTimePicker dteDate;
        private CheckBox chkDte;
    }
}
