namespace ServiceCenter.StockManagement
{
    partial class StockInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInForm));
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            txtStock = new TextBox();
            txtStockIn = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMove = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1072, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Cyan;
            btnClose.Location = new Point(1027, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 37);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(35, 126, 204);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(191, 328);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(247, 37);
            txtStock.TabIndex = 2;
            // 
            // txtStockIn
            // 
            txtStockIn.BackColor = Color.FromArgb(35, 126, 204);
            txtStockIn.BorderStyle = BorderStyle.FixedSingle;
            txtStockIn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStockIn.ForeColor = Color.White;
            txtStockIn.Location = new Point(657, 328);
            txtStockIn.MaxLength = 10;
            txtStockIn.Name = "txtStockIn";
            txtStockIn.Size = new Size(247, 37);
            txtStockIn.TabIndex = 2;
            txtStockIn.TextChanged += txtStockIn_TextChanged;
            txtStockIn.KeyPress += txtStockIn_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_warehouse_100;
            pictureBox2.Location = new Point(191, 404);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_truck_100;
            pictureBox3.Location = new Point(657, 390);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 179);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(96, 232, 254);
            label1.Location = new Point(484, 443);
            label1.Name = "label1";
            label1.Size = new Size(126, 96);
            label1.TabIndex = 4;
            label1.Text = "⋘";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(96, 232, 254);
            label2.Location = new Point(657, 300);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 5;
            label2.Text = "Stock In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(96, 232, 254);
            label3.Location = new Point(191, 300);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 5;
            label3.Text = "Available Stock";
            // 
            // btnMove
            // 
            btnMove.FlatStyle = FlatStyle.Flat;
            btnMove.ForeColor = Color.Cyan;
            btnMove.Location = new Point(469, 583);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(162, 46);
            btnMove.TabIndex = 1;
            btnMove.Text = "Move it";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // StockInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 29, 52);
            ClientSize = new Size(1072, 660);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtStockIn);
            Controls.Add(txtStock);
            Controls.Add(btnMove);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockInForm";
            Load += StockInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnClose;
        private TextBox txtStock;
        private TextBox txtStockIn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMove;
    }
}