namespace ServiceCenter
{
    partial class ServiceWorkshopUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceWorkshopUC));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlAvailable = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlAvailable.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(588, 527);
            label1.Name = "label1";
            label1.Size = new Size(564, 48);
            label1.TabIndex = 1;
            label1.Text = "no jobs are available at this time";
            // 
            // pnlAvailable
            // 
            pnlAvailable.Controls.Add(button1);
            pnlAvailable.Dock = DockStyle.Fill;
            pnlAvailable.Location = new Point(0, 0);
            pnlAvailable.Name = "pnlAvailable";
            pnlAvailable.Size = new Size(1719, 993);
            pnlAvailable.TabIndex = 2;
            pnlAvailable.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(209, 675);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // ServiceWorkshopUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAvailable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ServiceWorkshopUC";
            Size = new Size(1719, 993);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlAvailable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlAvailable;
        private Button button1;
    }
}
