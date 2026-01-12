namespace ServiceCenter.ServiceWorkshop
{
    partial class ServiceDiagnosisUC
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
            txtCode = new TextBox();
            txtPlate = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtFrame = new TextBox();
            txtEngine = new TextBox();
            txtComplaint = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            tmrSearchDelay = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtCode.Location = new Point(47, 75);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(616, 45);
            txtCode.TabIndex = 0;
            // 
            // txtPlate
            // 
            txtPlate.BackColor = Color.White;
            txtPlate.BorderStyle = BorderStyle.FixedSingle;
            txtPlate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtPlate.Location = new Point(47, 196);
            txtPlate.Name = "txtPlate";
            txtPlate.ReadOnly = true;
            txtPlate.Size = new Size(616, 45);
            txtPlate.TabIndex = 0;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.White;
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtBrand.Location = new Point(47, 323);
            txtBrand.Name = "txtBrand";
            txtBrand.ReadOnly = true;
            txtBrand.Size = new Size(616, 45);
            txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.White;
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtModel.Location = new Point(47, 442);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(616, 45);
            txtModel.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtYear.Location = new Point(47, 567);
            txtYear.Name = "txtYear";
            txtYear.ReadOnly = true;
            txtYear.Size = new Size(616, 45);
            txtYear.TabIndex = 0;
            // 
            // txtFrame
            // 
            txtFrame.BackColor = Color.White;
            txtFrame.BorderStyle = BorderStyle.FixedSingle;
            txtFrame.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtFrame.Location = new Point(47, 817);
            txtFrame.Name = "txtFrame";
            txtFrame.ReadOnly = true;
            txtFrame.Size = new Size(616, 45);
            txtFrame.TabIndex = 0;
            // 
            // txtEngine
            // 
            txtEngine.BackColor = Color.White;
            txtEngine.BorderStyle = BorderStyle.FixedSingle;
            txtEngine.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtEngine.Location = new Point(52, 688);
            txtEngine.Name = "txtEngine";
            txtEngine.ReadOnly = true;
            txtEngine.Size = new Size(616, 45);
            txtEngine.TabIndex = 0;
            // 
            // txtComplaint
            // 
            txtComplaint.BackColor = Color.White;
            txtComplaint.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtComplaint.Location = new Point(797, 76);
            txtComplaint.Name = "txtComplaint";
            txtComplaint.ReadOnly = true;
            txtComplaint.Size = new Size(887, 165);
            txtComplaint.TabIndex = 1;
            txtComplaint.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(47, 295);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 2;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.Location = new Point(47, 416);
            label2.Name = "label2";
            label2.Size = new Size(76, 26);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(47, 168);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 2;
            label3.Text = "Plate Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(47, 47);
            label4.Name = "label4";
            label4.Size = new Size(68, 26);
            label4.TabIndex = 2;
            label4.Text = "Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label5.Location = new Point(47, 789);
            label5.Name = "label5";
            label5.Size = new Size(171, 26);
            label5.TabIndex = 2;
            label5.Text = "Frame Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label6.Location = new Point(47, 660);
            label6.Name = "label6";
            label6.Size = new Size(177, 26);
            label6.TabIndex = 2;
            label6.Text = "Engine Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label7.Location = new Point(47, 539);
            label7.Name = "label7";
            label7.Size = new Size(63, 26);
            label7.TabIndex = 2;
            label7.Text = "Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label8.Location = new Point(797, 51);
            label8.Name = "label8";
            label8.Size = new Size(120, 26);
            label8.TabIndex = 2;
            label8.Text = "Complaint";
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
            dataGridView1.Location = new Point(797, 397);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(887, 465);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtSearch.Location = new Point(797, 323);
            txtSearch.MaxLength = 30;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search Service...";
            txtSearch.Size = new Size(556, 45);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(1399, 323);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(285, 46);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // tmrSearchDelay
            // 
            tmrSearchDelay.Interval = 500;
            tmrSearchDelay.Tick += tmrSearchDelay_Tick;
            // 
            // ServiceDiagnosisUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 239, 255);
            Controls.Add(cmbCategory);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtComplaint);
            Controls.Add(txtModel);
            Controls.Add(txtEngine);
            Controls.Add(txtPlate);
            Controls.Add(txtFrame);
            Controls.Add(txtSearch);
            Controls.Add(txtBrand);
            Controls.Add(txtYear);
            Controls.Add(txtCode);
            Name = "ServiceDiagnosisUC";
            Size = new Size(1803, 993);
            Load += ServiceDiagnosisUC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtPlate;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtFrame;
        private TextBox txtEngine;
        private RichTextBox txtComplaint;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private System.Windows.Forms.Timer tmrSearchDelay;
    }
}
