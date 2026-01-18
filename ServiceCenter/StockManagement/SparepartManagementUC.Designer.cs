namespace ServiceCenter.StockManagement
{
    partial class SparepartManagementUC
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ss = new Label();
            txtSparepart = new TextBox();
            label4 = new Label();
            txtCode = new TextBox();
            label5 = new Label();
            txtSelling = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dteEffective = new DateTimePicker();
            nmcStock = new NumericUpDown();
            label9 = new Label();
            nmcMinimum = new NumericUpDown();
            label10 = new Label();
            cmbUnit = new ComboBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            cmbSupplier = new ComboBox();
            pnlButton = new Panel();
            btnAdds = new Button();
            txtSSparepart = new TextBox();
            txtSSupplier = new TextBox();
            cmbSUnit = new ComboBox();
            tmrSpareDelay = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tmrSupDelay = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcMinimum).BeginInit();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(329, 38);
            label2.TabIndex = 15;
            label2.Text = "Sparepart Management";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(33, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1562, 597);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 810);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 17;
            label1.Text = "Supplier Name";
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ss.Location = new Point(1035, 741);
            ss.Name = "ss";
            ss.Size = new Size(148, 28);
            ss.TabIndex = 17;
            ss.Text = "Stock Available";
            // 
            // txtSparepart
            // 
            txtSparepart.BorderStyle = BorderStyle.FixedSingle;
            txtSparepart.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSparepart.Location = new Point(230, 770);
            txtSparepart.Name = "txtSparepart";
            txtSparepart.Size = new Size(366, 37);
            txtSparepart.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 742);
            label4.Name = "label4";
            label4.Size = new Size(160, 28);
            label4.TabIndex = 17;
            label4.Text = "Sparepart Name";
            // 
            // txtCode
            // 
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(33, 770);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(166, 37);
            txtCode.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 742);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 17;
            label5.Text = "Service Code";
            // 
            // txtSelling
            // 
            txtSelling.BorderStyle = BorderStyle.FixedSingle;
            txtSelling.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSelling.Location = new Point(630, 843);
            txtSelling.Name = "txtSelling";
            txtSelling.Size = new Size(366, 37);
            txtSelling.TabIndex = 16;
            txtSelling.KeyPress += txtPrice_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(630, 771);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(366, 37);
            txtPrice.TabIndex = 16;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(630, 815);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 17;
            label6.Text = "Selling Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(630, 889);
            label7.Name = "label7";
            label7.Size = new Size(137, 28);
            label7.TabIndex = 17;
            label7.Text = "Effective Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(630, 743);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 17;
            label8.Text = "Purchase Price";
            // 
            // dteEffective
            // 
            dteEffective.CustomFormat = "MMMMdd, yyyy ";
            dteEffective.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteEffective.Format = DateTimePickerFormat.Custom;
            dteEffective.Location = new Point(630, 917);
            dteEffective.Name = "dteEffective";
            dteEffective.Size = new Size(366, 37);
            dteEffective.TabIndex = 18;
            // 
            // nmcStock
            // 
            nmcStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmcStock.Location = new Point(1035, 769);
            nmcStock.Name = "nmcStock";
            nmcStock.Size = new Size(153, 37);
            nmcStock.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1035, 814);
            label9.Name = "label9";
            label9.Size = new Size(155, 28);
            label9.TabIndex = 17;
            label9.Text = "Minimum Stock";
            // 
            // nmcMinimum
            // 
            nmcMinimum.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmcMinimum.Location = new Point(1035, 842);
            nmcMinimum.Name = "nmcMinimum";
            nmcMinimum.Size = new Size(153, 37);
            nmcMinimum.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1035, 888);
            label10.Name = "label10";
            label10.Size = new Size(99, 28);
            label10.TabIndex = 17;
            label10.Text = "Unit Type";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Items.AddRange(new object[] { "Pcs", "Set", "Unit", "Box", "Botol", "Kaleng", "Tube", "Liter", "Biji", "Pack" });
            cmbUnit.Location = new Point(1035, 916);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(153, 38);
            cmbUnit.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(192, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 67);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SpringGreen;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(28, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 67);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(192, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 67);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DeepPink;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(28, 74);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 67);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "Pcs", "Set", "Unit", "Box", "Botol", "Kaleng", "Tube", "Liter", "Biji", "Pack" });
            cmbSupplier.Location = new Point(230, 841);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(366, 38);
            cmbSupplier.TabIndex = 20;
            // 
            // pnlButton
            // 
            pnlButton.Controls.Add(btnDelete);
            pnlButton.Controls.Add(btnClear);
            pnlButton.Controls.Add(btnUpdate);
            pnlButton.Controls.Add(btnAdd);
            pnlButton.Location = new Point(1255, 770);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(340, 154);
            pnlButton.TabIndex = 22;
            // 
            // btnAdds
            // 
            btnAdds.BackColor = Color.SpringGreen;
            btnAdds.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdds.ForeColor = Color.White;
            btnAdds.Location = new Point(1294, 769);
            btnAdds.Name = "btnAdds";
            btnAdds.Size = new Size(147, 67);
            btnAdds.TabIndex = 23;
            btnAdds.Text = "Add";
            btnAdds.UseVisualStyleBackColor = false;
            btnAdds.Click += btnAdds_Click;
            // 
            // txtSSparepart
            // 
            txtSSparepart.BorderStyle = BorderStyle.FixedSingle;
            txtSSparepart.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSSparepart.Location = new Point(53, 68);
            txtSSparepart.Name = "txtSSparepart";
            txtSSparepart.PlaceholderText = " Search Sparepart...";
            txtSSparepart.Size = new Size(366, 37);
            txtSSparepart.TabIndex = 24;
            txtSSparepart.Tag = "nullable";
            txtSSparepart.TextChanged += txtSSparepart_TextChanged;
            // 
            // txtSSupplier
            // 
            txtSSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtSSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSSupplier.Location = new Point(464, 68);
            txtSSupplier.Name = "txtSSupplier";
            txtSSupplier.PlaceholderText = "Search Supplier";
            txtSSupplier.Size = new Size(366, 37);
            txtSSupplier.TabIndex = 24;
            txtSSupplier.Tag = "nullable";
            // 
            // cmbSUnit
            // 
            cmbSUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSUnit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSUnit.FormattingEnabled = true;
            cmbSUnit.Items.AddRange(new object[] { "Pcs", "Set", "Unit", "Box", "Botol", "Kaleng", "Tube", "Liter", "Biji", "Pack" });
            cmbSUnit.Location = new Point(869, 68);
            cmbSUnit.Name = "cmbSUnit";
            cmbSUnit.Size = new Size(153, 38);
            cmbSUnit.TabIndex = 20;
            cmbSUnit.Tag = "nullable";
            cmbSUnit.SelectedIndexChanged += cmbSUnit_SelectedIndexChanged;
            // 
            // tmrSpareDelay
            // 
            tmrSpareDelay.Interval = 500;
            tmrSpareDelay.Tick += tmrSparepart_Tick;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            // 
            // tmrSupDelay
            // 
            tmrSupDelay.Interval = 500;
            tmrSupDelay.Tick += tmrSupDelay_Tick;
            // 
            // SparepartManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSSupplier);
            Controls.Add(txtSSparepart);
            Controls.Add(pnlButton);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbSUnit);
            Controls.Add(cmbUnit);
            Controls.Add(btnAdds);
            Controls.Add(nmcMinimum);
            Controls.Add(nmcStock);
            Controls.Add(dteEffective);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(ss);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Controls.Add(txtPrice);
            Controls.Add(txtSparepart);
            Controls.Add(txtSelling);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "SparepartManagementUC";
            Size = new Size(1630, 993);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcMinimum).EndInit();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label ss;
        private TextBox txtSparepart;
        private Label label4;
        private TextBox txtCode;
        private Label label5;
        private TextBox txtSelling;
        private TextBox txtPrice;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dteEffective;
        private NumericUpDown nmcStock;
        private Label label9;
        private NumericUpDown nmcMinimum;
        private Label label10;
        private ComboBox cmbUnit;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private ComboBox cmbSupplier;
        private Panel pnlButton;
        private Button btnAdds;
        private TextBox txtSSparepart;
        private TextBox txtSSupplier;
        private ComboBox cmbSUnit;
        private System.Windows.Forms.Timer tmrSpareDelay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrSupDelay;
    }
}
