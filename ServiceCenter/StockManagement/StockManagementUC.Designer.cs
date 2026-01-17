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
            pnlActivity = new Panel();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(89, 993);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlActivity
            // 
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new Point(89, 0);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1630, 993);
            pnlActivity.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 232, 254);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_item_48;
            button1.Location = new Point(2, 20);
            button1.Margin = new Padding(2, 0, 0, 0);
            button1.Name = "button1";
            button1.Size = new Size(86, 83);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
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
        private Button button1;
        private Panel pnlActivity;
    }
}
