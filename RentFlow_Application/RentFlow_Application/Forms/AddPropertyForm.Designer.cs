namespace RentFlow_Application.Forms
{
    partial class AddPropertyForm
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
            btnCancel = new Button();
            btnCreateLease = new Button();
            cmbLeaseStatus = new ComboBox();
            lblLeaseStatus = new Label();
            txtMonthlyRental = new TextBox();
            lblMonthlyRental = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblEndDate = new Label();
            lblStartDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbRentalUnit = new ComboBox();
            lblRentalUnit = new Label();
            comboBox1 = new ComboBox();
            lblProperty = new Label();
            cmbTenant = new ComboBox();
            lblTenant = new Label();
            lblCreateNewLease = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaptionText;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(507, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreateLease
            // 
            btnCreateLease.BackColor = SystemColors.MenuHighlight;
            btnCreateLease.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCreateLease.ForeColor = Color.Transparent;
            btnCreateLease.Location = new Point(182, 388);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(191, 29);
            btnCreateLease.TabIndex = 32;
            btnCreateLease.Text = "Create Lease";
            btnCreateLease.UseVisualStyleBackColor = false;
            // 
            // cmbLeaseStatus
            // 
            cmbLeaseStatus.FormattingEnabled = true;
            cmbLeaseStatus.Location = new Point(379, 308);
            cmbLeaseStatus.Name = "cmbLeaseStatus";
            cmbLeaseStatus.Size = new Size(234, 28);
            cmbLeaseStatus.TabIndex = 31;
            // 
            // lblLeaseStatus
            // 
            lblLeaseStatus.AutoSize = true;
            lblLeaseStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaseStatus.Location = new Point(182, 316);
            lblLeaseStatus.Name = "lblLeaseStatus";
            lblLeaseStatus.Size = new Size(91, 20);
            lblLeaseStatus.TabIndex = 30;
            lblLeaseStatus.Text = "Lease Status";
            // 
            // txtMonthlyRental
            // 
            txtMonthlyRental.Location = new Point(379, 265);
            txtMonthlyRental.Name = "txtMonthlyRental";
            txtMonthlyRental.Size = new Size(234, 27);
            txtMonthlyRental.TabIndex = 29;
            // 
            // lblMonthlyRental
            // 
            lblMonthlyRental.AutoSize = true;
            lblMonthlyRental.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyRental.Location = new Point(182, 272);
            lblMonthlyRental.Name = "lblMonthlyRental";
            lblMonthlyRental.Size = new Size(156, 20);
            lblMonthlyRental.TabIndex = 28;
            lblMonthlyRental.Text = "Monthly Rental (ZAR)";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(379, 223);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 27);
            dateTimePicker2.TabIndex = 27;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(182, 228);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(112, 20);
            lblEndDate.TabIndex = 26;
            lblEndDate.Text = "Lease End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(182, 190);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(118, 20);
            lblStartDate.TabIndex = 25;
            lblStartDate.Text = "Lease Start Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(379, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // cmbRentalUnit
            // 
            cmbRentalUnit.FormattingEnabled = true;
            cmbRentalUnit.Location = new Point(379, 146);
            cmbRentalUnit.Name = "cmbRentalUnit";
            cmbRentalUnit.Size = new Size(234, 28);
            cmbRentalUnit.TabIndex = 23;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.Location = new Point(185, 154);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(83, 20);
            lblRentalUnit.TabIndex = 22;
            lblRentalUnit.Text = "Rental unit";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 28);
            comboBox1.TabIndex = 21;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperty.Location = new Point(185, 118);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(69, 20);
            lblProperty.TabIndex = 20;
            lblProperty.Text = "Property";
            // 
            // cmbTenant
            // 
            cmbTenant.FormattingEnabled = true;
            cmbTenant.Location = new Point(379, 75);
            cmbTenant.Name = "cmbTenant";
            cmbTenant.Size = new Size(234, 28);
            cmbTenant.TabIndex = 19;
            // 
            // lblTenant
            // 
            lblTenant.AutoSize = true;
            lblTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenant.Location = new Point(185, 83);
            lblTenant.Name = "lblTenant";
            lblTenant.Size = new Size(55, 20);
            lblTenant.TabIndex = 18;
            lblTenant.Text = "Tenant";
            // 
            // lblCreateNewLease
            // 
            lblCreateNewLease.AutoSize = true;
            lblCreateNewLease.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateNewLease.ForeColor = SystemColors.MenuHighlight;
            lblCreateNewLease.Location = new Point(203, 33);
            lblCreateNewLease.Name = "lblCreateNewLease";
            lblCreateNewLease.Size = new Size(244, 37);
            lblCreateNewLease.TabIndex = 17;
            lblCreateNewLease.Text = "Create New Lease";
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "AddPropertyForm";
            Text = "AddPropertyForm";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnCreateLease;
        private ComboBox cmbLeaseStatus;
        private Label lblLeaseStatus;
        private TextBox txtMonthlyRental;
        private Label lblMonthlyRental;
        private DateTimePicker dateTimePicker2;
        private Label lblEndDate;
        private Label lblStartDate;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbRentalUnit;
        private Label lblRentalUnit;
        private ComboBox comboBox1;
        private Label lblProperty;
        private ComboBox cmbTenant;
        private Label lblTenant;
        private Label lblCreateNewLease;
    }
}