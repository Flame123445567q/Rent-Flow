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
            cmbProperty = new ComboBox();
            lblRentalUnit = new Label();
            cmbRentalUnit = new ComboBox();
            dtpStart = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpEnd = new DateTimePicker();
            lblMonthlyRental = new Label();
            txtMonthlyRent = new TextBox();
            lblLeaseStatus = new Label();
            cmbStatus = new ComboBox();
            btnCreateLease = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCreateNewLease
            // 
            lblCreateNewLease.AutoSize = true;
            lblCreateNewLease.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateNewLease.ForeColor = SystemColors.MenuHighlight;
            lblCreateNewLease.Location = new Point(41, 34);
            lblCreateNewLease.Margin = new Padding(4, 0, 4, 0);
            lblCreateNewLease.Name = "lblCreateNewLease";
            lblCreateNewLease.Size = new Size(283, 45);
            lblCreateNewLease.TabIndex = 0;
            lblCreateNewLease.Text = "Create New Lease";
            // 
            // lblTenant
            // 
            lblTenant.AutoSize = true;
            lblTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenant.Location = new Point(19, 96);
            lblTenant.Margin = new Padding(4, 0, 4, 0);
            lblTenant.Name = "lblTenant";
            lblTenant.Size = new Size(68, 25);
            lblTenant.TabIndex = 1;
            lblTenant.Text = "Tenant";
            // 
            // cmbTenant
            // 
            cmbTenant.FormattingEnabled = true;
            cmbTenant.Location = new Point(261, 86);
            cmbTenant.Margin = new Padding(4);
            cmbTenant.Name = "cmbTenant";
            cmbTenant.Size = new Size(292, 33);
            cmbTenant.TabIndex = 2;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperty.Location = new Point(19, 140);
            lblProperty.Margin = new Padding(4, 0, 4, 0);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(86, 25);
            lblProperty.TabIndex = 3;
            lblProperty.Text = "Property";
            // 
            // cmbProperty
            // 
            cmbProperty.FormattingEnabled = true;
            cmbProperty.Location = new Point(261, 130);
            cmbProperty.Margin = new Padding(4);
            cmbProperty.Name = "cmbProperty";
            cmbProperty.Size = new Size(292, 33);
            cmbProperty.TabIndex = 4;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.Location = new Point(19, 185);
            lblRentalUnit.Margin = new Padding(4, 0, 4, 0);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(104, 25);
            lblRentalUnit.TabIndex = 5;
            lblRentalUnit.Text = "Rental unit";
            // 
            // cmbRentalUnit
            // 
            cmbRentalUnit.FormattingEnabled = true;
            cmbRentalUnit.Location = new Point(261, 175);
            cmbRentalUnit.Margin = new Padding(4);
            cmbRentalUnit.Name = "cmbRentalUnit";
            cmbRentalUnit.Size = new Size(292, 33);
            cmbRentalUnit.TabIndex = 6;
            cmbRentalUnit.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(261, 224);
            dtpStart.Margin = new Padding(4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(299, 31);
            dtpStart.TabIndex = 7;
            dtpStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(15, 230);
            lblStartDate.Margin = new Padding(4, 0, 4, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(147, 25);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Lease Start Date";
            lblStartDate.Click += label1_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(15, 278);
            lblEndDate.Margin = new Padding(4, 0, 4, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(138, 25);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "Lease End Date";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(261, 271);
            dtpEnd.Margin = new Padding(4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(299, 31);
            dtpEnd.TabIndex = 10;
            // 
            // lblMonthlyRental
            // 
            lblMonthlyRental.AutoSize = true;
            lblMonthlyRental.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyRental.Location = new Point(15, 332);
            lblMonthlyRental.Margin = new Padding(4, 0, 4, 0);
            lblMonthlyRental.Name = "lblMonthlyRental";
            lblMonthlyRental.Size = new Size(191, 25);
            lblMonthlyRental.TabIndex = 11;
            lblMonthlyRental.Text = "Monthly Rental (ZAR)";
            // 
            // txtMonthlyRent
            // 
            txtMonthlyRent.Location = new Point(261, 324);
            txtMonthlyRent.Margin = new Padding(4);
            txtMonthlyRent.Name = "txtMonthlyRent";
            txtMonthlyRent.Size = new Size(292, 31);
            txtMonthlyRent.TabIndex = 12;
            // 
            // lblLeaseStatus
            // 
            lblLeaseStatus.AutoSize = true;
            lblLeaseStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaseStatus.Location = new Point(15, 388);
            lblLeaseStatus.Margin = new Padding(4, 0, 4, 0);
            lblLeaseStatus.Name = "lblLeaseStatus";
            lblLeaseStatus.Size = new Size(114, 25);
            lblLeaseStatus.TabIndex = 13;
            lblLeaseStatus.Text = "Lease Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Expired", "Terminated" });
            cmbStatus.Location = new Point(261, 378);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(292, 33);
            cmbStatus.TabIndex = 14;
            // 
            // btnCreateLease
            // 
            btnCreateLease.BackColor = SystemColors.MenuHighlight;
            btnCreateLease.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCreateLease.ForeColor = Color.Transparent;
            btnCreateLease.Location = new Point(15, 478);
            btnCreateLease.Margin = new Padding(4);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(239, 36);
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
            btnCancel.Location = new Point(421, 478);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateLeaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(602, 566);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateLease);
            Controls.Add(cmbStatus);
            Controls.Add(lblLeaseStatus);
            Controls.Add(txtMonthlyRent);
            Controls.Add(lblMonthlyRental);
            Controls.Add(dtpEnd);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpStart);
            Controls.Add(cmbRentalUnit);
            Controls.Add(lblRentalUnit);
            Controls.Add(cmbProperty);
            Controls.Add(lblProperty);
            Controls.Add(cmbTenant);
            Controls.Add(lblTenant);
            Controls.Add(lblCreateNewLease);
            Margin = new Padding(4);
            Name = "CreateLeaseForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ComboBox cmbProperty;
        private Label lblRentalUnit;
        private ComboBox cmbRentalUnit;
        private DateTimePicker dtpStart;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEnd;
        private Label lblMonthlyRental;
        private TextBox txtMonthlyRent;
        private Label lblLeaseStatus;
        private ComboBox cmbStatus;
        private Button btnCreateLease;
        private Button btnCancel;
    }
}