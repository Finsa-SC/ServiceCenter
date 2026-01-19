namespace ServiceCenter.ServiceHistory
{
    partial class ServiceHistoryUC
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnOrderHistory = new Button();
            btnTechPerf = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(107, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1612, 993);
            panel1.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(46, 65, 88);
            flowLayoutPanel1.Controls.Add(btnOrderHistory);
            flowLayoutPanel1.Controls.Add(btnTechPerf);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(107, 993);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.FlatStyle = FlatStyle.Flat;
            btnOrderHistory.Image = Properties.Resources.icons_history_48;
            btnOrderHistory.Location = new Point(3, 3);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(102, 102);
            btnOrderHistory.TabIndex = 0;
            btnOrderHistory.UseVisualStyleBackColor = true;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnTechPerf
            // 
            btnTechPerf.FlatStyle = FlatStyle.Flat;
            btnTechPerf.Image = Properties.Resources.icons8_technician_48;
            btnTechPerf.Location = new Point(3, 111);
            btnTechPerf.Name = "btnTechPerf";
            btnTechPerf.Size = new Size(102, 102);
            btnTechPerf.TabIndex = 0;
            btnTechPerf.UseVisualStyleBackColor = true;
            // 
            // ServiceHistoryUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "ServiceHistoryUC";
            Size = new Size(1719, 993);
            Load += ServiceHistoryUC_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnOrderHistory;
        private Button btnTechPerf;
    }
}
