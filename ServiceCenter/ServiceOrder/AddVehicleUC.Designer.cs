namespace ServiceCenter.ServiceOrder
{
    partial class AddVehicleUC
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
            txtPlat = new TextBox();
            label1 = new Label();
            txtFrm = new TextBox();
            label2 = new Label();
            cmbBrand = new ComboBox();
            label3 = new Label();
            txtMode = new TextBox();
            txtEng = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbYears = new ComboBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtPlat
            // 
            txtPlat.BorderStyle = BorderStyle.FixedSingle;
            txtPlat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPlat.Location = new Point(113, 148);
            txtPlat.MaxLength = 9;
            txtPlat.Name = "txtPlat";
            txtPlat.Size = new Size(576, 39);
            txtPlat.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 120);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 1;
            label1.Text = "Plat Number";
            // 
            // txtFrm
            // 
            txtFrm.BorderStyle = BorderStyle.FixedSingle;
            txtFrm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFrm.Location = new Point(113, 548);
            txtFrm.MaxLength = 12;
            txtFrm.Name = "txtFrm";
            txtFrm.Size = new Size(576, 39);
            txtFrm.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 520);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 1;
            label2.Text = "Frame Number";
            // 
            // cmbBrand
            // 
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Items.AddRange(new object[] { "Honda", "Yamaha", "Kawasaki", "Suzuki", "Vespa", "Ducati", "BMW", "KTM", "Harley-Davidson", "TVS" });
            cmbBrand.Location = new Point(113, 230);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(576, 40);
            cmbBrand.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(113, 201);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 1;
            label3.Text = "Brand";
            // 
            // txtMode
            // 
            txtMode.BorderStyle = BorderStyle.FixedSingle;
            txtMode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMode.Location = new Point(113, 311);
            txtMode.MaxLength = 20;
            txtMode.Name = "txtMode";
            txtMode.Size = new Size(576, 39);
            txtMode.TabIndex = 0;
            // 
            // txtEng
            // 
            txtEng.BorderStyle = BorderStyle.FixedSingle;
            txtEng.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEng.Location = new Point(113, 468);
            txtEng.MaxLength = 12;
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(576, 39);
            txtEng.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 283);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 1;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(113, 440);
            label5.Name = "label5";
            label5.Size = new Size(155, 28);
            label5.TabIndex = 1;
            label5.Text = "Engine Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(113, 362);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 1;
            label6.Text = "Years";
            // 
            // cmbYears
            // 
            cmbYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYears.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbYears.FormattingEnabled = true;
            cmbYears.Items.AddRange(new object[] { "Honda", "Yamaha", "Kawasaki", "Suzuki", "Vespa", "Ducati", "BMW", "KTM", "Harley-Davidson", "TVS" });
            cmbYears.Location = new Point(113, 391);
            cmbYears.Name = "cmbYears";
            cmbYears.Size = new Size(576, 40);
            cmbYears.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(582, 608);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 51);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddVehicleUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(cmbYears);
            Controls.Add(label6);
            Controls.Add(cmbBrand);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtEng);
            Controls.Add(txtMode);
            Controls.Add(txtFrm);
            Controls.Add(txtPlat);
            Name = "AddVehicleUC";
            Size = new Size(816, 710);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlat;
        private Label label1;
        private TextBox txtFrm;
        private Label label2;
        private ComboBox cmbBrand;
        private Label label3;
        private TextBox txtMode;
        private TextBox txtEng;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbYears;
        private Button btnAdd;
    }
}
