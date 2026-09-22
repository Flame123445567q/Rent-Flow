namespace RentFlow_Application.Forms
{
    partial class Add_New_Tenants
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
            components = new System.ComponentModel.Container();
            lblRegisterNewTenant = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblEmailAddress = new Label();
            lblIDNumber = new Label();
            lblAssignedProperty = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtIDNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            lblAssignedUnit = new Label();
            cmbAssignedProperty = new ComboBox();
            cmbAssignedUnit = new ComboBox();
            btnSaveTenant = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRegisterNewTenant
            // 
            lblRegisterNewTenant.AutoSize = true;
            lblRegisterNewTenant.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterNewTenant.Location = new Point(27, 26);
            lblRegisterNewTenant.Name = "lblRegisterNewTenant";
            lblRegisterNewTenant.Size = new Size(233, 31);
            lblRegisterNewTenant.TabIndex = 0;
            lblRegisterNewTenant.Text = "Register New Tenant";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(27, 103);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(404, 113);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(32, 189);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(404, 189);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(103, 20);
            lblEmailAddress.TabIndex = 4;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Location = new Point(32, 276);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(82, 20);
            lblIDNumber.TabIndex = 5;
            lblIDNumber.Text = "lD Number";
            // 
            // lblAssignedProperty
            // 
            lblAssignedProperty.AutoSize = true;
            lblAssignedProperty.Location = new Point(32, 352);
            lblAssignedProperty.Name = "lblAssignedProperty";
            lblAssignedProperty.Size = new Size(129, 20);
            lblAssignedProperty.TabIndex = 6;
            lblAssignedProperty.Text = "Assigned Property";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(32, 136);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "eg.Thando";
            txtFirstName.Size = new Size(239, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(397, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "eg.Mkhize";
            txtLastName.Size = new Size(264, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(32, 299);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PlaceholderText = "13-digit SA ID Number";
            txtIDNumber.Size = new Size(629, 27);
            txtIDNumber.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(397, 212);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "eg.thembalamik79@gmail.com";
            txtEmailAddress.Size = new Size(264, 27);
            txtEmailAddress.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(27, 212);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "eg.076 789 9056";
            txtPhoneNumber.Size = new Size(244, 27);
            txtPhoneNumber.TabIndex = 11;
            // 
            // lblAssignedUnit
            // 
            lblAssignedUnit.AutoSize = true;
            lblAssignedUnit.Location = new Point(397, 352);
            lblAssignedUnit.Name = "lblAssignedUnit";
            lblAssignedUnit.Size = new Size(100, 20);
            lblAssignedUnit.TabIndex = 12;
            lblAssignedUnit.Text = "Assigned Unit";
            // 
            // cmbAssignedProperty
            // 
            cmbAssignedProperty.FormattingEnabled = true;
            cmbAssignedProperty.Location = new Point(34, 383);
            cmbAssignedProperty.Name = "cmbAssignedProperty";
            cmbAssignedProperty.Size = new Size(237, 28);
            cmbAssignedProperty.TabIndex = 13;
            // 
            // cmbAssignedUnit
            // 
            cmbAssignedUnit.FormattingEnabled = true;
            cmbAssignedUnit.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbAssignedUnit.Location = new Point(397, 383);
            cmbAssignedUnit.Name = "cmbAssignedUnit";
            cmbAssignedUnit.Size = new Size(264, 28);
            cmbAssignedUnit.TabIndex = 14;
            // 
            // btnSaveTenant
            // 
            btnSaveTenant.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveTenant.FlatStyle = FlatStyle.Popup;
            btnSaveTenant.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveTenant.ForeColor = Color.White;
            btnSaveTenant.Location = new Point(34, 458);
            btnSaveTenant.Name = "btnSaveTenant";
            btnSaveTenant.Size = new Size(391, 46);
            btnSaveTenant.TabIndex = 15;
            btnSaveTenant.Text = "Save Tenant";
            btnSaveTenant.UseVisualStyleBackColor = false;
            btnSaveTenant.Click += btnSaveTenant_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(520, 458);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 46);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Add_New_Tenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveTenant);
            Controls.Add(cmbAssignedUnit);
            Controls.Add(cmbAssignedProperty);
            Controls.Add(lblAssignedUnit);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtIDNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAssignedProperty);
            Controls.Add(lblIDNumber);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblRegisterNewTenant);
            Name = "Add_New_Tenants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_New_Tenants";
            Click += btnSaveTenant_Click_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisterNewTenant;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblEmailAddress;
        private Label lblIDNumber;
        private Label lblAssignedProperty;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtIDNumber;
        private TextBox txtEmailAddress;
        private TextBox txtPhoneNumber;
        private Label lblAssignedUnit;
        private ComboBox cmbAssignedProperty;
        private ComboBox cmbAssignedUnit;
        private Button btnSaveTenant;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}