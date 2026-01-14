namespace ServiceCenter.ServiceWorkshop
{
    partial class ServiceAssessmentUC
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvSparePart = new DataGridView();
            dgvCart = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNote = new RichTextBox();
            btnFinished = new Button();
            txtSubtotal = new TextBox();
            chkPrice = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSparePart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvSparePart
            // 
            dgvSparePart.AllowUserToAddRows = false;
            dgvSparePart.AllowUserToDeleteRows = false;
            dgvSparePart.AllowUserToResizeColumns = false;
            dgvSparePart.AllowUserToResizeRows = false;
            dgvSparePart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSparePart.BackgroundColor = Color.FromArgb(243, 248, 254);
            dgvSparePart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSparePart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSparePart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSparePart.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSparePart.EnableHeadersVisualStyles = false;
            dgvSparePart.GridColor = Color.DarkGray;
            dgvSparePart.Location = new Point(35, 70);
            dgvSparePart.Name = "dgvSparePart";
            dgvSparePart.ReadOnly = true;
            dgvSparePart.RowHeadersVisible = false;
            dgvSparePart.RowHeadersWidth = 62;
            dgvSparePart.Size = new Size(801, 596);
            dgvSparePart.TabIndex = 5;
            dgvSparePart.CellContentClick += dgvSparePart_CellContentClick;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.FromArgb(243, 248, 254);
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(243, 248, 254);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(46, 67, 88);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.GridColor = Color.DarkGray;
            dgvCart.Location = new Point(883, 70);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.Size = new Size(801, 596);
            dgvCart.TabIndex = 5;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 12);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 6;
            label1.Text = "Sparepart Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(890, 12);
            label2.Name = "label2";
            label2.Size = new Size(223, 38);
            label2.TabIndex = 6;
            label2.Text = "Sparepart Taken";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.FromArgb(243, 248, 254);
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Location = new Point(45, 729);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(764, 211);
            txtNote.TabIndex = 7;
            txtNote.Text = "";
            // 
            // btnFinished
            // 
            btnFinished.BackColor = Color.FromArgb(45, 98, 223);
            btnFinished.FlatStyle = FlatStyle.Flat;
            btnFinished.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinished.ForeColor = Color.White;
            btnFinished.Location = new Point(1416, 903);
            btnFinished.Name = "btnFinished";
            btnFinished.Size = new Size(255, 62);
            btnFinished.TabIndex = 8;
            btnFinished.Text = "Finished";
            btnFinished.UseVisualStyleBackColor = false;
            btnFinished.Click += btnFinished_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = Color.FromArgb(243, 248, 254);
            txtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(1177, 773);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(494, 39);
            txtSubtotal.TabIndex = 9;
            // 
            // chkPrice
            // 
            chkPrice.AutoSize = true;
            chkPrice.Location = new Point(1177, 738);
            chkPrice.Name = "chkPrice";
            chkPrice.Size = new Size(206, 29);
            chkPrice.TabIndex = 10;
            chkPrice.Text = "Hide spareparts price";
            chkPrice.UseVisualStyleBackColor = true;
            chkPrice.CheckedChanged += chkPrice_CheckedChanged;
            // 
            // ServiceAssessmentUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            Controls.Add(chkPrice);
            Controls.Add(txtSubtotal);
            Controls.Add(btnFinished);
            Controls.Add(txtNote);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCart);
            Controls.Add(dgvSparePart);
            Name = "ServiceAssessmentUC";
            Size = new Size(1719, 993);
            ((System.ComponentModel.ISupportInitialize)dgvSparePart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSparePart;
        private DataGridView dgvCart;
        private Label label1;
        private Label label2;
        private RichTextBox txtNote;
        private Button btnFinished;
        private TextBox txtSubtotal;
        private CheckBox chkPrice;
    }
}
