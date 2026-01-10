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
            panel2 = new Panel();
            btnCancel = new Button();
            btnApply = new Button();
            dteEstimate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtIssue = new RichTextBox();
            btnAddVehicle = new Button();
            btnAddCustomer = new Button();
            dgvVehicle = new DataGridView();
            dgvCustomer = new DataGridView();
            txtVehicleSearch = new TextBox();
            txtCustomerSearch = new TextBox();
            pnlAct = new Panel();
            tmrCustomerDelay = new System.Windows.Forms.Timer(components);
            tmrVehicleDelay = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnApply);
            panel2.Controls.Add(dteEstimate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtIssue);
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(354, 913);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.BackColor = SystemColors.Highlight;
            btnApply.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(550, 913);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(190, 50);
            btnApply.TabIndex = 9;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // dteEstimate
            // 
            dteEstimate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteEstimate.Location = new Point(79, 850);
            dteEstimate.Name = "dteEstimate";
            dteEstimate.Size = new Size(661, 39);
            dteEstimate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 819);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 13;
            label2.Text = "Finish Estimate ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 440);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 14;
            label1.Text = "Issue";
            // 
            // txtIssue
            // 
            txtIssue.BorderStyle = BorderStyle.FixedSingle;
            txtIssue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIssue.Location = new Point(79, 471);
            txtIssue.Name = "txtIssue";
            txtIssue.Size = new Size(661, 337);
            txtIssue.TabIndex = 12;
            txtIssue.Text = "";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddVehicle.Location = new Point(748, 277);
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
            btnAddCustomer.Location = new Point(748, 54);
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
            dgvVehicle.Location = new Point(81, 307);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.ReadOnly = true;
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
            dgvVehicle.Size = new Size(661, 113);
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
            dgvCustomer.ReadOnly = true;
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
            dgvCustomer.Size = new Size(661, 113);
            dgvCustomer.TabIndex = 9;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // txtVehicleSearch
            // 
            txtVehicleSearch.BorderStyle = BorderStyle.FixedSingle;
            txtVehicleSearch.Enabled = false;
            txtVehicleSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtVehicleSearch.Location = new Point(81, 262);
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
            txtCustomerSearch.Location = new Point(79, 53);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.PlaceholderText = " Search Customer...";
            txtCustomerSearch.Size = new Size(661, 39);
            txtCustomerSearch.TabIndex = 7;
            txtCustomerSearch.TextChanged += txtCustomerSearch_TextChanged;
            // 
            // pnlAct
            // 
            pnlAct.Dock = DockStyle.Top;
            pnlAct.Location = new Point(903, 0);
            pnlAct.Name = "pnlAct";
            pnlAct.Size = new Size(816, 872);
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
            Controls.Add(panel2);
            Name = "ServiceOrdersUC";
            Size = new Size(1719, 993);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DateTimePicker dteEstimate;
        private Label label2;
        private Label label1;
        private RichTextBox txtIssue;
        private Button btnAddVehicle;
        private Button btnAddCustomer;
        private DataGridView dgvVehicle;
        private DataGridView dgvCustomer;
        private TextBox txtVehicleSearch;
        private TextBox txtCustomerSearch;
        private Panel pnlAct;
        private System.Windows.Forms.Timer tmrCustomerDelay;
        private System.Windows.Forms.Timer tmrVehicleDelay;
        private Button btnCancel;
        private Button btnApply;
    }
}
