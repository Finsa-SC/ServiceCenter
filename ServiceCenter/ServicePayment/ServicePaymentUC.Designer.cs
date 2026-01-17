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
            txtPlate = new TextBox();
            txtTotal = new TextBox();
            txtCode = new TextBox();
            btnFinish = new Button();
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
            dataGridView1.Location = new Point(70, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1045, 878);
            dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(1150, 91);
            label4.Name = "label4";
            label4.Size = new Size(68, 26);
            label4.TabIndex = 9;
            label4.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(1150, 212);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 10;
            label3.Text = "Plate Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(1150, 771);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 11;
            label1.Text = "Brand";
            // 
            // txtPlate
            // 
            txtPlate.BackColor = Color.White;
            txtPlate.BorderStyle = BorderStyle.FixedSingle;
            txtPlate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtPlate.Location = new Point(1150, 240);
            txtPlate.Name = "txtPlate";
            txtPlate.ReadOnly = true;
            txtPlate.Size = new Size(537, 45);
            txtPlate.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtTotal.Location = new Point(1150, 799);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(537, 45);
            txtTotal.TabIndex = 7;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtCode.Location = new Point(1150, 119);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(537, 45);
            txtCode.TabIndex = 8;
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
            // 
            // ServicePayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFinish);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPlate);
            Controls.Add(txtTotal);
            Controls.Add(txtCode);
            Controls.Add(dataGridView1);
            Name = "ServicePayment";
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
        private TextBox txtPlate;
        private TextBox txtTotal;
        private TextBox txtCode;
        private Button btnFinish;
    }
}
