//namespace RentFlow_Application.Forms
//{
//    partial class AddRentalUnit
//    {
//        / <summary>
//        / Required designer variable.
//        / </summary>
//        private System.ComponentModel.IContainer components = null;

//        / <summary>
//        / Clean up any resources being used.
//        / </summary>
//        / <param/* name="disposing"*/>true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        / <summary>
//        / Required method for Designer support - do not modify
//        / the contents of this method with the code editor.
//        / </summary>
//        private void InitializeComponent()
//        {
//            lblAddRentalUnit = new Label();
//            lblProperty = new Label();
//            txtMonthlyRent = new TextBox();
//            lblUnitNumber = new Label();
//            txtUnitNumber = new TextBox();
//            cmbProperties = new ComboBox();
//            lblMonthlyRent = new Label();
//            lblAvailableStatus = new Label();
//            cmbAvailabilityStatus = new ComboBox();
//            btnSaveUnits = new Button();
//            btnCancel = new Button();
//            SuspendLayout();
//            // 
//            // lblAddRentalUnit
//            // 
//            lblAddRentalUnit.AutoSize = true;
//            lblAddRentalUnit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblAddRentalUnit.Location = new Point(7, 13);
//            lblAddRentalUnit.Name = "lblAddRentalUnit";
//            lblAddRentalUnit.Size = new Size(185, 31);
//            lblAddRentalUnit.TabIndex = 0;
//            lblAddRentalUnit.Text = "Add Rental Unit";
//            // 
//            // lblProperty
//            // 
//            lblProperty.AutoSize = true;
//            lblProperty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblProperty.Location = new Point(21, 66);
//            lblProperty.Name = "lblProperty";
//            lblProperty.Size = new Size(95, 28);
//            lblProperty.TabIndex = 1;
//            lblProperty.Text = "Property";
//            // 
//            // txtMonthlyRent
//            // 
//            txtMonthlyRent.Location = new Point(21, 297);
//            txtMonthlyRent.Name = "txtMonthlyRent";
//            txtMonthlyRent.PlaceholderText = "e.g. 9500";
//            txtMonthlyRent.Size = new Size(311, 27);
//            txtMonthlyRent.TabIndex = 2;
//            // 
//            // lblUnitNumber
//            // 
//            lblUnitNumber.AutoSize = true;
//            lblUnitNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblUnitNumber.Location = new Point(21, 180);
//            lblUnitNumber.Name = "lblUnitNumber";
//            lblUnitNumber.Size = new Size(135, 28);
//            lblUnitNumber.TabIndex = 3;
//            lblUnitNumber.Text = "Unit Number";
//            // 
//            // txtUnitNumber
//            // 
//            txtUnitNumber.Location = new Point(21, 211);
//            txtUnitNumber.Name = "txtUnitNumber";
//            txtUnitNumber.PlaceholderText = "e.g. 301";
//            txtUnitNumber.Size = new Size(610, 27);
//            txtUnitNumber.TabIndex = 4;
//            // 
//            // cmbProperties
//            // 
//            cmbProperties.FormattingEnabled = true;
//            cmbProperties.Location = new Point(21, 116);
//            cmbProperties.Name = "cmbProperties";
//            cmbProperties.Size = new Size(610, 28);
//            cmbProperties.TabIndex = 5;
//            // 
//            // lblMonthlyRent
//            // 
//            lblMonthlyRent.AutoSize = true;
//            lblMonthlyRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblMonthlyRent.Location = new Point(21, 266);
//            lblMonthlyRent.Name = "lblMonthlyRent";
//            lblMonthlyRent.Size = new Size(201, 28);
//            lblMonthlyRent.TabIndex = 6;
//            lblMonthlyRent.Text = "Monthly Rent (ZAR)";
//            // 
//            // lblAvailableStatus
//            // 
//            lblAvailableStatus.AutoSize = true;
//            lblAvailableStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblAvailableStatus.Location = new Point(21, 374);
//            lblAvailableStatus.Name = "lblAvailableStatus";
//            lblAvailableStatus.Size = new Size(185, 28);
//            lblAvailableStatus.TabIndex = 7;
//            lblAvailableStatus.Text = "Availability Status";
//            // 
//            // cmbAvailabilityStatus
//            // 
//            cmbAvailabilityStatus.FormattingEnabled = true;
//            cmbAvailabilityStatus.Location = new Point(21, 426);
//            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
//            cmbAvailabilityStatus.Size = new Size(610, 28);
//            cmbAvailabilityStatus.TabIndex = 8;
//            // 
//            // btnSaveUnits
//            // 
//            btnSaveUnits.BackColor = Color.DarkBlue;
//            btnSaveUnits.ForeColor = Color.White;
//            btnSaveUnits.Location = new Point(22, 489);
//            btnSaveUnits.Name = "btnSaveUnits";
//            btnSaveUnits.Size = new Size(476, 47);
//            btnSaveUnits.TabIndex = 9;
//            btnSaveUnits.Text = "Save Unit";
//            btnSaveUnits.UseVisualStyleBackColor = false;
//            btnSaveUnits.Click += btnSaveUnits_Click;
//            // 
//            // btnCancel
//            // 
//            btnCancel.Location = new Point(539, 489);
//            btnCancel.Name = "btnCancel";
//            btnCancel.Size = new Size(117, 47);
//            btnCancel.TabIndex = 10;
//            btnCancel.Text = "Cancel";
//            btnCancel.UseVisualStyleBackColor = true;
//            btnCancel.Click += btnCancel_Click;
//            // 
//            // AddRentalUnit
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(668, 548);
//            Controls.Add(btnCancel);
//            Controls.Add(btnSaveUnits);
//            Controls.Add(cmbAvailabilityStatus);
//            Controls.Add(lblAvailableStatus);
//            Controls.Add(lblMonthlyRent);
//            Controls.Add(cmbProperties);


//            Controls.Add(txtMonthlyRent);
//            Controls.Add(lblProperty);
//            Controls.Add(lblAddRentalUnit);
//            Name = "AddRentalUnit";
//            Text = "Add_Rental_Unit";
//            Load += AddRentalUnit_Load;
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label lblAddRentalUnit;
//        private Label lblProperty;
//        private TextBox txtMonthlyRent;


//        private ComboBox cmbProperties;
//        private Label lblMonthlyRent;
//        private Label lblAvailableStatus;
//        private ComboBox cmbAvailabilityStatus;
//        private Button btnSaveUnits;
//        private Button btnCancel;
//    }
//}