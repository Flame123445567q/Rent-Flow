namespace RentFlow_Application.Forms
{
    partial class CreateLeaseForm
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
            lblCreateNewLease = new Label();
            lblTenant = new Label();
            cmbTenant = new ComboBox();
            lblProperty = new Label();
            comboBox1 = new ComboBox();
            lblRentalUnit = new Label();
            cmbRentalUnit = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblMonthlyRental = new Label();
            txtMonthlyRental = new TextBox();
            lblLeaseStatus = new Label();
            cmbLeaseStatus = new ComboBox();
            btnCreateLease = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCreateNewLease
            // 
            lblCreateNewLease.AutoSize = true;
            lblCreateNewLease.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateNewLease.ForeColor = SystemColors.MenuHighlight;
            lblCreateNewLease.Location = new Point(33, 27);
            lblCreateNewLease.Name = "lblCreateNewLease";
            lblCreateNewLease.Size = new Size(244, 37);
            lblCreateNewLease.TabIndex = 0;
            lblCreateNewLease.Text = "Create New Lease";
            // 
            // lblTenant
            // 
            lblTenant.AutoSize = true;
            lblTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenant.Location = new Point(15, 77);
            lblTenant.Name = "lblTenant";
            lblTenant.Size = new Size(55, 20);
            lblTenant.TabIndex = 1;
            lblTenant.Text = "Tenant";
            // 
            // cmbTenant
            // 
            cmbTenant.FormattingEnabled = true;
            cmbTenant.Location = new Point(209, 69);
            cmbTenant.Name = "cmbTenant";
            cmbTenant.Size = new Size(234, 28);
            cmbTenant.TabIndex = 2;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperty.Location = new Point(15, 112);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(69, 20);
            lblProperty.TabIndex = 3;
            lblProperty.Text = "Property";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(209, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 28);
            comboBox1.TabIndex = 4;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.Location = new Point(15, 148);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(83, 20);
            lblRentalUnit.TabIndex = 5;
            lblRentalUnit.Text = "Rental unit";
            // 
            // cmbRentalUnit
            // 
            cmbRentalUnit.FormattingEnabled = true;
            cmbRentalUnit.Location = new Point(209, 140);
            cmbRentalUnit.Name = "cmbRentalUnit";
            cmbRentalUnit.Size = new Size(234, 28);
            cmbRentalUnit.TabIndex = 6;
            cmbRentalUnit.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(209, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(12, 184);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(118, 20);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Lease Start Date";
            lblStartDate.Click += label1_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(12, 222);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(112, 20);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "Lease End Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(209, 217);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 27);
            dateTimePicker2.TabIndex = 10;
            // 
            // lblMonthlyRental
            // 
            lblMonthlyRental.AutoSize = true;
            lblMonthlyRental.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyRental.Location = new Point(12, 266);
            lblMonthlyRental.Name = "lblMonthlyRental";
            lblMonthlyRental.Size = new Size(156, 20);
            lblMonthlyRental.TabIndex = 11;
            lblMonthlyRental.Text = "Monthly Rental (ZAR)";
            // 
            // txtMonthlyRental
            // 
            txtMonthlyRental.Location = new Point(209, 259);
            txtMonthlyRental.Name = "txtMonthlyRental";
            txtMonthlyRental.Size = new Size(234, 27);
            txtMonthlyRental.TabIndex = 12;
            // 
            // lblLeaseStatus
            // 
            lblLeaseStatus.AutoSize = true;
            lblLeaseStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaseStatus.Location = new Point(12, 310);
            lblLeaseStatus.Name = "lblLeaseStatus";
            lblLeaseStatus.Size = new Size(91, 20);
            lblLeaseStatus.TabIndex = 13;
            lblLeaseStatus.Text = "Lease Status";
            // 
            // cmbLeaseStatus
            // 
            cmbLeaseStatus.FormattingEnabled = true;
            cmbLeaseStatus.Location = new Point(209, 302);
            cmbLeaseStatus.Name = "cmbLeaseStatus";
            cmbLeaseStatus.Size = new Size(234, 28);
            cmbLeaseStatus.TabIndex = 14;
            // 
            // btnCreateLease
            // 
            btnCreateLease.BackColor = SystemColors.MenuHighlight;
            btnCreateLease.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCreateLease.ForeColor = Color.Transparent;
            btnCreateLease.Location = new Point(12, 382);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(191, 29);
            btnCreateLease.TabIndex = 15;
            btnCreateLease.Text = "Create Lease";
            btnCreateLease.UseVisualStyleBackColor = false;
            btnCreateLease.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaptionText;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(337, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateLeaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(482, 453);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateLease);
            Controls.Add(cmbLeaseStatus);
            Controls.Add(lblLeaseStatus);
            Controls.Add(txtMonthlyRental);
            Controls.Add(lblMonthlyRental);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbRentalUnit);
            Controls.Add(lblRentalUnit);
            Controls.Add(comboBox1);
            Controls.Add(lblProperty);
            Controls.Add(cmbTenant);
            Controls.Add(lblTenant);
            Controls.Add(lblCreateNewLease);
            Name = "CreateLeaseForm";
            Text = "Create New Lease";
            Load += CreateLeaseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateNewLease;
        private Label lblTenant;
        private ComboBox cmbTenant;
        private Label lblProperty;
        private ComboBox comboBox1;
        private Label lblRentalUnit;
        private ComboBox cmbRentalUnit;
        private DateTimePicker dateTimePicker1;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker2;
        private Label lblMonthlyRental;
        private TextBox txtMonthlyRental;
        private Label lblLeaseStatus;
        private ComboBox cmbLeaseStatus;
        private Button btnCreateLease;
        private Button btnCancel;
    }
}