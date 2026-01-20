namespace ServiceCenter.ServiceHistory
{
    partial class OrderHistoryUC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtSCustomer = new TextBox();
            cmbSBrand = new ComboBox();
            dteSDate = new DateTimePicker();
            chkDte = new CheckBox();
            tmrSearchDelay = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Location = new Point(26, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1559, 822);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(26, 15);
            label2.Name = "label2";
            label2.Size = new Size(196, 38);
            label2.TabIndex = 20;
            label2.Text = "Order History";
            // 
            // txtSCustomer
            // 
            txtSCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtSCustomer.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSCustomer.Location = new Point(353, 29);
            txtSCustomer.Name = "txtSCustomer";
            txtSCustomer.PlaceholderText = " Search...";
            txtSCustomer.Size = new Size(364, 37);
            txtSCustomer.TabIndex = 21;
            txtSCustomer.TextChanged += txtSCustomer_TextChanged;
            // 
            // cmbSBrand
            // 
            cmbSBrand.FlatStyle = FlatStyle.Flat;
            cmbSBrand.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSBrand.FormattingEnabled = true;
            cmbSBrand.Location = new Point(794, 29);
            cmbSBrand.Name = "cmbSBrand";
            cmbSBrand.Size = new Size(245, 38);
            cmbSBrand.TabIndex = 22;
            cmbSBrand.SelectedIndexChanged += cmbSBrand_SelectedIndexChanged;
            // 
            // dteSDate
            // 
            dteSDate.CustomFormat = "MMMMdd, yyyy";
            dteSDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteSDate.Format = DateTimePickerFormat.Custom;
            dteSDate.Location = new Point(1111, 30);
            dteSDate.MaxDate = new DateTime(2026, 1, 20, 0, 0, 0, 0);
            dteSDate.Name = "dteSDate";
            dteSDate.Size = new Size(300, 37);
            dteSDate.TabIndex = 23;
            dteSDate.Value = new DateTime(2026, 1, 20, 0, 0, 0, 0);
            dteSDate.ValueChanged += dteSDate_ValueChanged;
            // 
            // chkDte
            // 
            chkDte.AutoSize = true;
            chkDte.Location = new Point(1413, 35);
            chkDte.Name = "chkDte";
            chkDte.Size = new Size(183, 29);
            chkDte.TabIndex = 24;
            chkDte.Text = "According to Date";
            chkDte.UseVisualStyleBackColor = true;
            chkDte.CheckedChanged += chkDte_CheckedChanged;
            // 
            // tmrSearchDelay
            // 
            tmrSearchDelay.Interval = 500;
            tmrSearchDelay.Tick += tmrSearchDelay_Tick;
            // 
            // OrderHistoryUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkDte);
            Controls.Add(dteSDate);
            Controls.Add(cmbSBrand);
            Controls.Add(txtSCustomer);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "OrderHistoryUC";
            Size = new Size(1612, 993);
            Load += OrderHistoryUC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtSCustomer;
        private ComboBox cmbSBrand;
        private DateTimePicker dteSDate;
        private CheckBox chkDte;
        private System.Windows.Forms.Timer tmrSearchDelay;
    }
}
