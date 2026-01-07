namespace ServiceCenter.ServiceOrder
{
    partial class ServiceOrdersUC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            dteEstimate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnAddVehicle = new Button();
            btnAddCustomer = new Button();
            dgvVehicle = new DataGridView();
            dgvCustomer = new DataGridView();
            txtVehicleSearch = new TextBox();
            txtCustomerSearch = new TextBox();
            pnlAct = new Panel();
            tmrCustomerDelay = new System.Windows.Forms.Timer(components);
            tmrVehicleDelay = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(903, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 420);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fairy_icon;
            pictureBox1.Location = new Point(253, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(96, 232, 254);
            label3.Location = new Point(273, 373);
            label3.Name = "label3";
            label3.Size = new Size(195, 34);
            label3.TabIndex = 3;
            label3.Text = "Service Center";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 50F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(253, 241);
            label4.Name = "label4";
            label4.Size = new Size(331, 177);
            label4.TabIndex = 4;
            label4.Text = "Fairy";
            // 
            // panel2
            // 
            panel2.Controls.Add(dteEstimate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(btnAddVehicle);
            panel2.Controls.Add(btnAddCustomer);
            panel2.Controls.Add(dgvVehicle);
            panel2.Controls.Add(dgvCustomer);
            panel2.Controls.Add(txtVehicleSearch);
            panel2.Controls.Add(txtCustomerSearch);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 993);
            panel2.TabIndex = 7;
            // 
            // dteEstimate
            // 
            dteEstimate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteEstimate.Location = new Point(79, 914);
            dteEstimate.Name = "dteEstimate";
            dteEstimate.Size = new Size(661, 39);
            dteEstimate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 883);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 13;
            label2.Text = "Finish Estimate ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 504);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 14;
            label1.Text = "Issue";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(79, 535);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(661, 337);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddVehicle.Location = new Point(760, 284);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(44, 39);
            btnAddVehicle.TabIndex = 10;
            btnAddVehicle.Text = "+";
            btnAddVehicle.TextAlign = ContentAlignment.TopCenter;
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(760, 35);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(44, 39);
            btnAddCustomer.TabIndex = 11;
            btnAddCustomer.Text = "+";
            btnAddCustomer.TextAlign = ContentAlignment.TopCenter;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvVehicle
            // 
            dgvVehicle.AllowUserToAddRows = false;
            dgvVehicle.AllowUserToDeleteRows = false;
            dgvVehicle.AllowUserToResizeColumns = false;
            dgvVehicle.AllowUserToResizeRows = false;
            dgvVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVehicle.BackgroundColor = SystemColors.ControlLightLight;
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVehicle.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVehicle.Location = new Point(79, 347);
            dgvVehicle.Name = "dgvVehicle";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Chocolate;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVehicle.RowHeadersVisible = false;
            dgvVehicle.RowHeadersWidth = 62;
            dgvVehicle.Size = new Size(661, 136);
            dgvVehicle.TabIndex = 8;
            dgvVehicle.CellContentClick += dgvVehicle_CellContentClick;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCustomer.BackgroundColor = SystemColors.ControlLightLight;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.Location = new Point(79, 98);
            dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Chocolate;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.Size = new Size(661, 136);
            dgvCustomer.TabIndex = 9;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // txtVehicleSearch
            // 
            txtVehicleSearch.BorderStyle = BorderStyle.FixedSingle;
            txtVehicleSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtVehicleSearch.Location = new Point(79, 288);
            txtVehicleSearch.Name = "txtVehicleSearch";
            txtVehicleSearch.PlaceholderText = " Search Vehicle...";
            txtVehicleSearch.Size = new Size(661, 39);
            txtVehicleSearch.TabIndex = 6;
            txtVehicleSearch.TextChanged += txtVehicleSearch_TextChanged;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCustomerSearch.Location = new Point(79, 39);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.PlaceholderText = " Search Customer...";
            txtCustomerSearch.Size = new Size(661, 39);
            txtCustomerSearch.TabIndex = 7;
            txtCustomerSearch.TextChanged += txtCustomerSearch_TextChanged;
            // 
            // pnlAct
            // 
            pnlAct.Dock = DockStyle.Fill;
            pnlAct.Location = new Point(903, 420);
            pnlAct.Name = "pnlAct";
            pnlAct.Size = new Size(816, 573);
            pnlAct.TabIndex = 8;
            // 
            // tmrCustomerDelay
            // 
            tmrCustomerDelay.Interval = 500;
            tmrCustomerDelay.Tick += tmrCustomerDelay_Tick;
            // 
            // tmrVehicleDelay
            // 
            tmrVehicleDelay.Interval = 500;
            tmrVehicleDelay.Tick += tmrVehicleDelay_Tick;
            // 
            // ServiceOrdersUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAct);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ServiceOrdersUC";
            Size = new Size(1719, 993);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private DateTimePicker dteEstimate;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnAddVehicle;
        private Button btnAddCustomer;
        private DataGridView dgvVehicle;
        private DataGridView dgvCustomer;
        private TextBox txtVehicleSearch;
        private TextBox txtCustomerSearch;
        private Panel pnlAct;
        private System.Windows.Forms.Timer tmrCustomerDelay;
        private System.Windows.Forms.Timer tmrVehicleDelay;
    }
}
