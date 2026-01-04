namespace ServiceCenter
{
    partial class ImageShow
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
            pctProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctProfile).BeginInit();
            SuspendLayout();
            // 
            // pctProfile
            // 
            pctProfile.Dock = DockStyle.Fill;
            pctProfile.Location = new Point(0, 0);
            pctProfile.Name = "pctProfile";
            pctProfile.Size = new Size(484, 450);
            pctProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pctProfile.TabIndex = 0;
            pctProfile.TabStop = false;
            // 
            // ImageShow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(pctProfile);
            Name = "ImageShow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageShow";
            ((System.ComponentModel.ISupportInitialize)pctProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctProfile;
    }
}