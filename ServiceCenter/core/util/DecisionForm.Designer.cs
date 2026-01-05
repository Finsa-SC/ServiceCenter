namespace ServiceCenter.core.util
{
    partial class DecisionForm
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
            btnOk = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.FlatAppearance.BorderColor = Color.Silver;
            btnOk.FlatAppearance.BorderSize = 2;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnOk.ForeColor = Color.FromArgb(49, 142, 204);
            btnOk.Location = new Point(-8, 176);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(220, 67);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            btnOk.MouseEnter += btnOk_MouseEnter;
            btnOk.MouseLeave += btnOk_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(168, 49, 34);
            btnCancel.Location = new Point(210, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(216, 67);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(12, 74);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(395, 94);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "message";
            lblMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // DecisionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 221, 221);
            ClientSize = new Size(419, 238);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DecisionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecisionForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblMessage;
    }
}