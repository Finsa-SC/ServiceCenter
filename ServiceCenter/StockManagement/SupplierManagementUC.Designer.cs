namespace ServiceCenter.StockManagement
{
    partial class SupplierManagementUC
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtSupplier = new TextBox();
            txtSAddress = new TextBox();
            txtSSupplier = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(309, 38);
            label2.TabIndex = 17;
            label2.Text = "Supplier Management";
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(529, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1065, 836);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 248, 254);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtSupplier);
            panel1.Location = new Point(45, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 879);
            panel1.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.ForestGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(19, 796);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 54);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 716);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(179, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.ForestGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(225, 716);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(179, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(28, 308);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(28, 206);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 1;
            label3.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(28, 101);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Supplier Name";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(28, 336);
            txtAddress.MaxLength = 255;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(369, 37);
            txtAddress.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(28, 234);
            txtPhone.MaxLength = 14;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(369, 37);
            txtPhone.TabIndex = 0;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtSupplier
            // 
            txtSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(28, 129);
            txtSupplier.MaxLength = 100;
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(369, 37);
            txtSupplier.TabIndex = 0;
            // 
            // txtSAddress
            // 
            txtSAddress.BorderStyle = BorderStyle.FixedSingle;
            txtSAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSAddress.Location = new Point(1228, 71);
            txtSAddress.Name = "txtSAddress";
            txtSAddress.PlaceholderText = "Search Address...";
            txtSAddress.Size = new Size(366, 37);
            txtSAddress.TabIndex = 25;
            // 
            // txtSSupplier
            // 
            txtSSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtSSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSSupplier.Location = new Point(527, 71);
            txtSSupplier.Name = "txtSSupplier";
            txtSSupplier.PlaceholderText = " Search Supplier...";
            txtSSupplier.Size = new Size(366, 37);
            txtSSupplier.TabIndex = 26;
            // 
            // SupplierManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSAddress);
            Controls.Add(txtSSupplier);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "SupplierManagementUC";
            Size = new Size(1630, 993);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnUpdate;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtSupplier;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtSAddress;
        private TextBox txtSSupplier;
    }
}
