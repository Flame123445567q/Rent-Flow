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
            btnSaveProperty = new Button();
            lblPropertyName = new Label();
            lblTenant = new Label();
            lblCreateNewLease = new Label();
            lblStreetAddress = new Label();
            txtStreetAddress = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            txtPostalCode = new TextBox();
            txtPropName = new TextBox();
            lblCity = new Label();
            lblProvince = new Label();
            lblPostalCode = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaptionText;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(553, 516);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 43);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveProperty
            // 
            btnSaveProperty.BackColor = Color.DarkBlue;
            btnSaveProperty.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveProperty.ForeColor = Color.Transparent;
            btnSaveProperty.Location = new Point(29, 516);
            btnSaveProperty.Name = "btnSaveProperty";
            btnSaveProperty.Size = new Size(448, 43);
            btnSaveProperty.TabIndex = 32;
            btnSaveProperty.Text = "Save Property";
            btnSaveProperty.UseVisualStyleBackColor = false;
            btnSaveProperty.Click += btnSaveProperty_Click;
            // 
            // lblPropertyName
            // 
            lblPropertyName.AutoSize = true;
            lblPropertyName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropertyName.Location = new Point(35, 100);
            lblPropertyName.Name = "lblPropertyName";
            lblPropertyName.Size = new Size(137, 24);
            lblPropertyName.TabIndex = 20;
            lblPropertyName.Text = "Property Name";
            // 
            // lblTenant
            // 
            lblTenant.AutoSize = true;
            lblTenant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenant.ForeColor = Color.DimGray;
            lblTenant.Location = new Point(12, 56);
            lblTenant.Name = "lblTenant";
            lblTenant.Size = new Size(202, 20);
            lblTenant.TabIndex = 18;
            lblTenant.Text = "Enter property details below";
            lblTenant.Click += lblTenant_Click;
            // 
            // lblCreateNewLease
            // 
            lblCreateNewLease.AutoSize = true;
            lblCreateNewLease.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateNewLease.ForeColor = Color.Black;
            lblCreateNewLease.Location = new Point(12, 9);
            lblCreateNewLease.Name = "lblCreateNewLease";
            lblCreateNewLease.Size = new Size(257, 37);
            lblCreateNewLease.TabIndex = 17;
            lblCreateNewLease.Text = "Add New Property";
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStreetAddress.Location = new Point(35, 182);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(132, 24);
            lblStreetAddress.TabIndex = 34;
            lblStreetAddress.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(35, 217);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.PlaceholderText = "eg. 14 Oak Avenue";
            txtStreetAddress.Size = new Size(593, 27);
            txtStreetAddress.TabIndex = 35;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(35, 282);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "eg. Johannesburg";
            txtCity.Size = new Size(593, 27);
            txtCity.TabIndex = 36;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(35, 339);
            txtProvince.Name = "txtProvince";
            txtProvince.PlaceholderText = "eg. Gauteng";
            txtProvince.Size = new Size(234, 27);
            txtProvince.TabIndex = 37;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(35, 420);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PlaceholderText = " eg. 2000";
            txtPostalCode.Size = new Size(593, 27);
            txtPostalCode.TabIndex = 38;
            // 
            // txtPropName
            // 
            txtPropName.Location = new Point(41, 142);
            txtPropName.Name = "txtPropName";
            txtPropName.PlaceholderText = "eg. Greenview";
            txtPropName.Size = new Size(587, 27);
            txtPropName.TabIndex = 39;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(35, 251);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 24);
            lblCity.TabIndex = 40;
            lblCity.Text = "City";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProvince.Location = new Point(35, 317);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(82, 24);
            lblProvince.TabIndex = 41;
            lblProvince.Text = "Province";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Location = new Point(35, 393);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(110, 24);
            lblPostalCode.TabIndex = 42;
            lblPostalCode.Text = "Postal Code";
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 583);
            Controls.Add(lblPostalCode);
            Controls.Add(lblProvince);
            Controls.Add(lblCity);
            Controls.Add(txtPropName);
            Controls.Add(txtPostalCode);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(txtStreetAddress);
            Controls.Add(lblStreetAddress);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProperty);
            Controls.Add(lblPropertyName);
            Controls.Add(lblTenant);
            Controls.Add(lblCreateNewLease);
            Name = "AddPropertyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPropertyForm";
            Load += AddPropertyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSaveProperty;
        private ComboBox cmbLeaseStatus;
        private Label lblLeaseStatus;
        private TextBox txtPropertyName;
        private Label lblMonthlyRental;
        private DateTimePicker dateTimePicker2;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblRentalUnit;
        private Label lblPropertyName;
        private Label lblTenant;
        private Label lblCreateNewLease;
        private Label lblStreetAddress;
        private TextBox txtStreetAddress;
        private TextBox txtCity;
        private TextBox txtProvince;
        private TextBox txtPostalCode;
        private TextBox txtPropName;
        private Label lblCity;
        private Label lblProvince;
        private Label lblPostalCode;
    }
}