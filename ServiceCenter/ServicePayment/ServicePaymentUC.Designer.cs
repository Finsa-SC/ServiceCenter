namespace ServiceCenter
{
    partial class ServicePaymentUC
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtPaid = new TextBox();
            txtChange = new TextBox();
            txtTotal = new TextBox();
            btnFinish = new Button();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbMethod = new ComboBox();
            Method = new Label();
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
            dataGridView1.Location = new Point(45, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1209, 871);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(1286, 68);
            label4.Name = "label4";
            label4.Size = new Size(153, 26);
            label4.TabIndex = 9;
            label4.Text = "Total Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(1286, 305);
            label3.Name = "label3";
            label3.Size = new Size(149, 26);
            label3.TabIndex = 10;
            label3.Text = "Paid Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(1286, 446);
            label1.Name = "label1";
            label1.Size = new Size(183, 26);
            label1.TabIndex = 11;
            label1.Text = "Change Amount";
            // 
            // txtPaid
            // 
            txtPaid.BackColor = Color.White;
            txtPaid.BorderStyle = BorderStyle.FixedSingle;
            txtPaid.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtPaid.Location = new Point(1286, 333);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(401, 45);
            txtPaid.TabIndex = 6;
            txtPaid.TextChanged += txtPaid_TextChanged;
            txtPaid.KeyPress += txtPaid_KeyPress;
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.White;
            txtChange.BorderStyle = BorderStyle.FixedSingle;
            txtChange.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtChange.Location = new Point(1286, 474);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(401, 45);
            txtChange.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtTotal.Location = new Point(1286, 96);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(401, 45);
            txtTotal.TabIndex = 8;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.MediumTurquoise;
            btnFinish.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinish.Location = new Point(1461, 888);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(226, 51);
            btnFinish.TabIndex = 12;
            btnFinish.Text = "Finish Order";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(35, 16);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 13;
            label2.Text = "Payment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 17F, FontStyle.Bold);
            label5.Location = new Point(1472, 404);
            label5.Name = "label5";
            label5.Size = new Size(43, 46);
            label5.TabIndex = 14;
            label5.Text = "⇩";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1443, 388);
            label6.Name = "label6";
            label6.Size = new Size(91, 30);
            label6.TabIndex = 15;
            label6.Text = "Change";
            // 
            // cmbMethod
            // 
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Transfer Bank", "QRIS", "Debit Card", "Credit Card", "Piutang/Tempo" });
            cmbMethod.Location = new Point(1287, 192);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(400, 44);
            cmbMethod.TabIndex = 16;
            // 
            // Method
            // 
            Method.AutoSize = true;
            Method.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Method.Location = new Point(1287, 163);
            Method.Name = "Method";
            Method.Size = new Size(191, 26);
            Method.TabIndex = 9;
            Method.Text = "Payment Method";
            // 
            // ServicePaymentUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbMethod);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnFinish);
            Controls.Add(Method);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPaid);
            Controls.Add(txtChange);
            Controls.Add(txtTotal);
            Controls.Add(dataGridView1);
            Name = "ServicePaymentUC";
            Size = new Size(1719, 993);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtPaid;
        private TextBox txtChange;
        private TextBox txtTotal;
        private Button btnFinish;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox cmbMethod;
        private Label Method;
    }
}
