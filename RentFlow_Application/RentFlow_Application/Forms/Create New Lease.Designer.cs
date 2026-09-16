namespace RentFlow_Application.Forms
{
    partial class Create_New_Lease
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
            lblProperty = new Label();
            txtProperty = new TextBox();
            cmbTenant = new ComboBox();
            lblLeaseStartDate = new Label();
            nudMonthlyRent = new NumericUpDown();
            btnCreateLease = new Button();
            btnClear = new Button();
            lblMonthlyRent = new Label();
            txtLeaseStartDate = new TextBox();
            lblRentalUnit = new Label();
            lblLeaseEndDate = new Label();
            lblLeaseStatus = new Label();
            txtLeaseEndDate = new TextBox();
            cmbRentalUnit = new ComboBox();
            cmbLeaseStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudMonthlyRent).BeginInit();
            SuspendLayout();
            // 
            // lblCreateNewLease
            // 
            lblCreateNewLease.AutoSize = true;
            lblCreateNewLease.Location = new Point(12, 29);
            lblCreateNewLease.Name = "lblCreateNewLease";
            lblCreateNewLease.Size = new Size(100, 15);
            lblCreateNewLease.TabIndex = 0;
            lblCreateNewLease.Text = "Create New Lease";
            // 
            // lblTenant
            // 
            lblTenant.AutoSize = true;
            lblTenant.Location = new Point(12, 85);
            lblTenant.Name = "lblTenant";
            lblTenant.Size = new Size(42, 15);
            lblTenant.TabIndex = 1;
            lblTenant.Text = "Tenant";
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Location = new Point(12, 150);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(52, 15);
            lblProperty.TabIndex = 2;
            lblProperty.Text = "Property";
            // 
            // txtProperty
            // 
            txtProperty.Location = new Point(12, 180);
            txtProperty.Name = "txtProperty";
            txtProperty.Size = new Size(138, 23);
            txtProperty.TabIndex = 3;
            // 
            // cmbTenant
            // 
            cmbTenant.FormattingEnabled = true;
            cmbTenant.Location = new Point(15, 103);
            cmbTenant.Name = "cmbTenant";
            cmbTenant.Size = new Size(336, 23);
            cmbTenant.TabIndex = 4;
            // 
            // lblLeaseStartDate
            // 
            lblLeaseStartDate.AutoSize = true;
            lblLeaseStartDate.Location = new Point(12, 226);
            lblLeaseStartDate.Name = "lblLeaseStartDate";
            lblLeaseStartDate.Size = new Size(90, 15);
            lblLeaseStartDate.TabIndex = 5;
            lblLeaseStartDate.Text = "Lease Start Date";
            // 
            // nudMonthlyRent
            // 
            nudMonthlyRent.Location = new Point(12, 322);
            nudMonthlyRent.Name = "nudMonthlyRent";
            nudMonthlyRent.Size = new Size(138, 23);
            nudMonthlyRent.TabIndex = 6;
            // 
            // btnCreateLease
            // 
            btnCreateLease.Location = new Point(12, 370);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(207, 34);
            btnCreateLease.TabIndex = 7;
            btnCreateLease.Text = "Create Lease";
            btnCreateLease.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Cancel";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblMonthlyRent
            // 
            lblMonthlyRent.AutoSize = true;
            lblMonthlyRent.Location = new Point(15, 304);
            lblMonthlyRent.Name = "lblMonthlyRent";
            lblMonthlyRent.Size = new Size(112, 15);
            lblMonthlyRent.TabIndex = 9;
            lblMonthlyRent.Text = "Monthly Rent (ZAR)";
            // 
            // txtLeaseStartDate
            // 
            txtLeaseStartDate.Location = new Point(20, 253);
            txtLeaseStartDate.Name = "txtLeaseStartDate";
            txtLeaseStartDate.Size = new Size(130, 23);
            txtLeaseStartDate.TabIndex = 10;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Location = new Point(220, 150);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(65, 15);
            lblRentalUnit.TabIndex = 11;
            lblRentalUnit.Text = "Rental Unit";
            // 
            // lblLeaseEndDate
            // 
            lblLeaseEndDate.AutoSize = true;
            lblLeaseEndDate.Location = new Point(220, 226);
            lblLeaseEndDate.Name = "lblLeaseEndDate";
            lblLeaseEndDate.Size = new Size(86, 15);
            lblLeaseEndDate.TabIndex = 12;
            lblLeaseEndDate.Text = "Lease End Date";
            // 
            // lblLeaseStatus
            // 
            lblLeaseStatus.AutoSize = true;
            lblLeaseStatus.Location = new Point(220, 304);
            lblLeaseStatus.Name = "lblLeaseStatus";
            lblLeaseStatus.Size = new Size(71, 15);
            lblLeaseStatus.TabIndex = 13;
            lblLeaseStatus.Text = "Lease Status";
            // 
            // txtLeaseEndDate
            // 
            txtLeaseEndDate.Location = new Point(220, 253);
            txtLeaseEndDate.Name = "txtLeaseEndDate";
            txtLeaseEndDate.Size = new Size(131, 23);
            txtLeaseEndDate.TabIndex = 14;
            // 
            // cmbRentalUnit
            // 
            cmbRentalUnit.FormattingEnabled = true;
            cmbRentalUnit.Location = new Point(218, 186);
            cmbRentalUnit.Name = "cmbRentalUnit";
            cmbRentalUnit.Size = new Size(133, 23);
            cmbRentalUnit.TabIndex = 15;
            // 
            // cmbLeaseStatus
            // 
            cmbLeaseStatus.FormattingEnabled = true;
            cmbLeaseStatus.Location = new Point(218, 322);
            cmbLeaseStatus.Name = "cmbLeaseStatus";
            cmbLeaseStatus.Size = new Size(133, 23);
            cmbLeaseStatus.TabIndex = 16;
            // 
            // Create_New_Lease
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbLeaseStatus);
            Controls.Add(cmbRentalUnit);
            Controls.Add(txtLeaseEndDate);
            Controls.Add(lblLeaseStatus);
            Controls.Add(lblLeaseEndDate);
            Controls.Add(lblRentalUnit);
            Controls.Add(txtLeaseStartDate);
            Controls.Add(lblMonthlyRent);
            Controls.Add(btnClear);
            Controls.Add(btnCreateLease);
            Controls.Add(nudMonthlyRent);
            Controls.Add(lblLeaseStartDate);
            Controls.Add(cmbTenant);
            Controls.Add(txtProperty);
            Controls.Add(lblProperty);
            Controls.Add(lblTenant);
            Controls.Add(lblCreateNewLease);
            Name = "Create_New_Lease";
            Text = "Create_New_Lease";
            ((System.ComponentModel.ISupportInitialize)nudMonthlyRent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateNewLease;
        private Label lblTenant;
        private Label lblProperty;
        private TextBox txtProperty;
        private ComboBox cmbTenant;
        private Label lblLeaseStartDate;
        private NumericUpDown nudMonthlyRent;
        private Button btnCreateLease;
        private Button btnClear;
        private Label lblMonthlyRent;
        private TextBox txtLeaseStartDate;
        private Label lblRentalUnit;
        private Label lblLeaseEndDate;
        private Label lblLeaseStatus;
        private TextBox txtLeaseEndDate;
        private ComboBox cmbRentalUnit;
        private ComboBox cmbLeaseStatus;
    }
}