namespace ServiceCenter.StockManagement
{
    partial class StockManagementUC
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSparepart = new Button();
            btnSupplier = new Button();
            pnlActivity = new Panel();
            btnStockIn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnStockIn);
            flowLayoutPanel1.Controls.Add(btnSparepart);
            flowLayoutPanel1.Controls.Add(btnSupplier);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 16, 0, 0);
            flowLayoutPanel1.Size = new Size(89, 993);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSparepart
            // 
            btnSparepart.BackColor = Color.RoyalBlue;
            btnSparepart.FlatAppearance.BorderColor = Color.White;
            btnSparepart.FlatAppearance.BorderSize = 3;
            btnSparepart.FlatStyle = FlatStyle.Flat;
            btnSparepart.Image = Properties.Resources.icons8_item_48;
            btnSparepart.Location = new Point(9, 106);
            btnSparepart.Margin = new Padding(9, 10, 0, 0);
            btnSparepart.Name = "btnSparepart";
            btnSparepart.Size = new Size(70, 70);
            btnSparepart.TabIndex = 0;
            btnSparepart.UseVisualStyleBackColor = false;
            btnSparepart.Click += btnSparepart_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.RoyalBlue;
            btnSupplier.FlatAppearance.BorderColor = Color.White;
            btnSupplier.FlatAppearance.BorderSize = 3;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Image = Properties.Resources.icons8_supplier_48;
            btnSupplier.Location = new Point(9, 186);
            btnSupplier.Margin = new Padding(9, 10, 0, 0);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(70, 70);
            btnSupplier.TabIndex = 0;
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // pnlActivity
            // 
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new Point(89, 0);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1630, 993);
            pnlActivity.TabIndex = 1;
            // 
            // btnStockIn
            // 
            btnStockIn.BackColor = Color.RoyalBlue;
            btnStockIn.FlatAppearance.BorderColor = Color.White;
            btnStockIn.FlatAppearance.BorderSize = 3;
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Image = Properties.Resources.icons8_insert_48;
            btnStockIn.Location = new Point(9, 26);
            btnStockIn.Margin = new Padding(9, 10, 0, 0);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(70, 70);
            btnStockIn.TabIndex = 0;
            btnStockIn.UseVisualStyleBackColor = false;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // StockManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlActivity);
            Controls.Add(flowLayoutPanel1);
            Name = "StockManagementUC";
            Size = new Size(1719, 993);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSparepart;
        private Panel pnlActivity;
        private Button btnSupplier;
        private Button btnStockIn;
    }
}
