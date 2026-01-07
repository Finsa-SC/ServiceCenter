namespace ServiceCenter.ServiceOrder
{
    partial class AddOrderUC
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(43, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(726, 286);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 1;
            label1.Text = "Issue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 373);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 1;
            label2.Text = "Issue";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(43, 406);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(726, 39);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(600, 488);
            button1.Name = "button1";
            button1.Size = new Size(169, 51);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddOrderUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "AddOrderUC";
            Size = new Size(816, 573);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
