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
            lblProvince = new Label();
            lblCity = new Label();
            lblRentalUnit = new Label();
            lblProperty = new Label();
            lblEnterPropertyBelow = new Label();
            lblAddNewProperty = new Label();
            txtPropertyName = new TextBox();
            txtStreetAddress = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            lblPostalcode = new Label();
            txtPostalCode = new TextBox();
            btnSaveProperty = new Button();
            SuspendLayout();
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProvince.Location = new Point(34, 334);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(82, 24);
            lblProvince.TabIndex = 26;
            lblProvince.Text = "Province";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(28, 256);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 24);
            lblCity.TabIndex = 25;
            lblCity.Text = "City";
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.Location = new Point(22, 184);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(132, 24);
            lblRentalUnit.TabIndex = 22;
            lblRentalUnit.Text = "Street Address";
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperty.Location = new Point(22, 108);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(137, 24);
            lblProperty.TabIndex = 20;
            lblProperty.Text = "Property Name";
            // 
            // lblEnterPropertyBelow
            // 
            lblEnterPropertyBelow.AutoSize = true;
            lblEnterPropertyBelow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterPropertyBelow.ForeColor = Color.DimGray;
            lblEnterPropertyBelow.Location = new Point(12, 55);
            lblEnterPropertyBelow.Name = "lblEnterPropertyBelow";
            lblEnterPropertyBelow.Size = new Size(210, 20);
            lblEnterPropertyBelow.TabIndex = 18;
            lblEnterPropertyBelow.Text = "Enter property deatails below";
            // 
            // lblAddNewProperty
            // 
            lblAddNewProperty.AutoSize = true;
            lblAddNewProperty.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAddNewProperty.ForeColor = Color.Black;
            lblAddNewProperty.Location = new Point(10, 9);
            lblAddNewProperty.Name = "lblAddNewProperty";
            lblAddNewProperty.Size = new Size(257, 37);
            lblAddNewProperty.TabIndex = 17;
            lblAddNewProperty.Text = "Add New Property";
            // 
            // txtPropertyName
            // 
            txtPropertyName.Location = new Point(28, 136);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.PlaceholderText = "eg.Greenview Residences";
            txtPropertyName.Size = new Size(553, 27);
            txtPropertyName.TabIndex = 28;
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(28, 211);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.PlaceholderText = "eg. 14 Oak Avenue";
            txtStreetAddress.Size = new Size(553, 27);
            txtStreetAddress.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(33, 292);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "eg. Johannesburg";
            txtCity.Size = new Size(548, 27);
            txtCity.TabIndex = 30;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(33, 376);
            txtProvince.Name = "txtProvince";
            txtProvince.PlaceholderText = "eg. Gauteng";
            txtProvince.Size = new Size(548, 27);
            txtProvince.TabIndex = 31;
            // 
            // lblPostalcode
            // 
            lblPostalcode.AutoSize = true;
            lblPostalcode.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalcode.Location = new Point(33, 438);
            lblPostalcode.Name = "lblPostalcode";
            lblPostalcode.Size = new Size(110, 24);
            lblPostalcode.TabIndex = 32;
            lblPostalcode.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(40, 496);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PlaceholderText = "eg. 2000";
            txtPostalCode.Size = new Size(541, 27);
            txtPostalCode.TabIndex = 33;
            // 
            // btnSaveProperty
            // 
            btnSaveProperty.BackColor = Color.DarkBlue;
            btnSaveProperty.FlatStyle = FlatStyle.Flat;
            btnSaveProperty.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProperty.ForeColor = Color.White;
            btnSaveProperty.Location = new Point(22, 594);
            btnSaveProperty.Name = "btnSaveProperty";
            btnSaveProperty.Size = new Size(535, 48);
            btnSaveProperty.TabIndex = 34;
            btnSaveProperty.Text = "Save Property";
            btnSaveProperty.UseVisualStyleBackColor = false;
            btnSaveProperty.Click += btnSaveProperty_Click;
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 654);
            Controls.Add(btnSaveProperty);
            Controls.Add(txtPostalCode);
            Controls.Add(lblPostalcode);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(txtStreetAddress);
            Controls.Add(txtPropertyName);
            Controls.Add(lblProvince);
            Controls.Add(lblCity);
            Controls.Add(lblRentalUnit);
            Controls.Add(lblProperty);
            Controls.Add(lblEnterPropertyBelow);
            Controls.Add(lblAddNewProperty);
            Name = "AddPropertyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPropertyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveProperty;
        private Button btnCreateLease;
        private ComboBox cmbLeaseStatus;
        private Label lblLeaseStatus;
        private TextBox txtMonthlyRental;
        private Label lblMonthlyRental;
        private Label lblProvince;
        private Label lblCity;
        private Label lblRentalUnit;
        private Label lblProperty;
        private Label lblEnterPropertyBelow;
        private Label lblAddNewProperty;
        private TextBox txtPropertyName;
        private TextBox txtStreetAddress;
        private TextBox txtCity;
        private TextBox txtProvince;
        private Label lblPostalcode;
        private TextBox txtPostalCode;
        private Button btnCancel;
    }
}