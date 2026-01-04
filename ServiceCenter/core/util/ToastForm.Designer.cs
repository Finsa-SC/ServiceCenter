namespace ServiceCenter.core.util
{
    partial class ToastForm
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
            panel1 = new Panel();
            btnClose = new Button();
            lblText = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 31);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblText);
            panel1.Controls.Add(lblTitle);
            panel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 141);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(335, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblText
            // 
            lblText.Font = new Font("Arial", 8F);
            lblText.Location = new Point(9, 37);
            lblText.Name = "lblText";
            lblText.Size = new Size(351, 95);
            lblText.TabIndex = 1;
            lblText.Text = "Notification";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(21, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 232, 254);
            ClientSize = new Size(375, 146);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label lblText;
        private Label lblTitle;
    }
}