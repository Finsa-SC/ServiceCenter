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
            textBox1 = new TextBox();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox2 = new ComboBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(46, 65, 88);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(46, 65, 88);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(41, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1634, 859);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(113, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Search...";
            textBox1.Size = new Size(419, 39);
            textBox1.TabIndex = 2;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(619, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 40);
            comboBox1.TabIndex = 4;
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
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(899, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 40);
            comboBox2.TabIndex = 4;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(1145, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 37);
            dateTimePicker1.TabIndex = 6;
            // 
            // UserManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(20, 3, 20, 20);
            Name = "UserManagementUC";
            Padding = new Padding(20, 3, 20, 20);
            Size = new Size(1719, 993);
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
        private TextBox textBox1;
        private Button btnAdd;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DateTimePicker dateTimePicker1;
    }
}
