namespace RentFlow_Application.Forms
{
    partial class AddRentalUnit
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
            grpAddRentalUnitInformation = new GroupBox();
            cmbOccupancy = new ComboBox();
            cmbAvailability = new ComboBox();
            txtRentalAmount = new TextBox();
            txtPropertyID = new TextBox();
            txtUnitNumber = new TextBox();
            lblRentalAmount = new Label();
            lblPropertyID = new Label();
            lblUnitNumber = new Label();
            btnSaveUnit = new Button();
            btnClearUnit = new Button();
            grpAddRentalUnitInformation.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddRentalUnitInformation
            // 
            grpAddRentalUnitInformation.Controls.Add(cmbOccupancy);
            grpAddRentalUnitInformation.Controls.Add(cmbAvailability);
            grpAddRentalUnitInformation.Controls.Add(txtRentalAmount);
            grpAddRentalUnitInformation.Controls.Add(txtPropertyID);
            grpAddRentalUnitInformation.Controls.Add(txtUnitNumber);
            grpAddRentalUnitInformation.Controls.Add(lblRentalAmount);
            grpAddRentalUnitInformation.Controls.Add(lblPropertyID);
            grpAddRentalUnitInformation.Controls.Add(lblUnitNumber);
            grpAddRentalUnitInformation.Location = new Point(13, 12);
            grpAddRentalUnitInformation.Name = "grpAddRentalUnitInformation";
            grpAddRentalUnitInformation.Size = new Size(384, 265);
            grpAddRentalUnitInformation.TabIndex = 0;
            grpAddRentalUnitInformation.TabStop = false;
            grpAddRentalUnitInformation.Text = "Rental Unit Information";
            // 
            // cmbOccupancy
            // 
            cmbOccupancy.FormattingEnabled = true;
            cmbOccupancy.Items.AddRange(new object[] { "Vacant", "Occupied" });
            cmbOccupancy.Location = new Point(191, 184);
            cmbOccupancy.Name = "cmbOccupancy";
            cmbOccupancy.Size = new Size(151, 28);
            cmbOccupancy.TabIndex = 7;
            // 
            // cmbAvailability
            // 
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Items.AddRange(new object[] { "Available", "Unavailable" });
            cmbAvailability.Location = new Point(19, 184);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(151, 28);
            cmbAvailability.TabIndex = 6;
            // 
            // txtRentalAmount
            // 
            txtRentalAmount.Location = new Point(163, 133);
            txtRentalAmount.Name = "txtRentalAmount";
            txtRentalAmount.Size = new Size(125, 27);
            txtRentalAmount.TabIndex = 5;
            // 
            // txtPropertyID
            // 
            txtPropertyID.Location = new Point(163, 83);
            txtPropertyID.Name = "txtPropertyID";
            txtPropertyID.Size = new Size(125, 27);
            txtPropertyID.TabIndex = 4;
            // 
            // txtUnitNumber
            // 
            txtUnitNumber.Location = new Point(163, 29);
            txtUnitNumber.Name = "txtUnitNumber";
            txtUnitNumber.Size = new Size(125, 27);
            txtUnitNumber.TabIndex = 3;
            // 
            // lblRentalAmount
            // 
            lblRentalAmount.AutoSize = true;
            lblRentalAmount.BackColor = Color.DarkBlue;
            lblRentalAmount.FlatStyle = FlatStyle.Flat;
            lblRentalAmount.ForeColor = Color.White;
            lblRentalAmount.Location = new Point(13, 133);
            lblRentalAmount.Name = "lblRentalAmount";
            lblRentalAmount.Size = new Size(146, 20);
            lblRentalAmount.TabIndex = 2;
            lblRentalAmount.Text = "Enter Rental Amount";
            // 
            // lblPropertyID
            // 
            lblPropertyID.AutoSize = true;
            lblPropertyID.BackColor = Color.DarkBlue;
            lblPropertyID.ForeColor = Color.White;
            lblPropertyID.Location = new Point(13, 74);
            lblPropertyID.Name = "lblPropertyID";
            lblPropertyID.Size = new Size(118, 20);
            lblPropertyID.TabIndex = 1;
            lblPropertyID.Text = "Enter PropertyID";
            // 
            // lblUnitNumber
            // 
            lblUnitNumber.AutoSize = true;
            lblUnitNumber.BackColor = Color.DarkBlue;
            lblUnitNumber.FlatStyle = FlatStyle.Flat;
            lblUnitNumber.ForeColor = Color.White;
            lblUnitNumber.Location = new Point(13, 29);
            lblUnitNumber.Name = "lblUnitNumber";
            lblUnitNumber.Size = new Size(132, 20);
            lblUnitNumber.TabIndex = 0;
            lblUnitNumber.Text = "Enter Unit Number";
            // 
            // btnSaveUnit
            // 
            btnSaveUnit.BackColor = Color.DarkBlue;
            btnSaveUnit.ForeColor = Color.White;
            btnSaveUnit.Location = new Point(38, 300);
            btnSaveUnit.Name = "btnSaveUnit";
            btnSaveUnit.Size = new Size(120, 49);
            btnSaveUnit.TabIndex = 1;
            btnSaveUnit.Text = "Save Unit";
            btnSaveUnit.UseVisualStyleBackColor = false;
            btnSaveUnit.Click += btnSaveUnit_Click;
            // 
            // btnClearUnit
            // 
            btnClearUnit.BackColor = Color.DarkBlue;
            btnClearUnit.ForeColor = Color.White;
            btnClearUnit.Location = new Point(204, 300);
            btnClearUnit.Name = "btnClearUnit";
            btnClearUnit.Size = new Size(120, 49);
            btnClearUnit.TabIndex = 2;
            btnClearUnit.Text = "Clear Unit";
            btnClearUnit.UseVisualStyleBackColor = false;
            btnClearUnit.Click += btnClearUnit_Click;
            // 
            // AddRentalUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearUnit);
            Controls.Add(btnSaveUnit);
            Controls.Add(grpAddRentalUnitInformation);
            Name = "AddRentalUnit";
            Text = "AddRentalUnit";
            Load += AddRentalUnit_Load;
            grpAddRentalUnitInformation.ResumeLayout(false);
            grpAddRentalUnitInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddRentalUnitInformation;
        private TextBox txtRentalAmount;
        private TextBox txtPropertyID;
        private TextBox txtUnitNumber;
        private Label lblRentalAmount;
        private Label lblPropertyID;
        private Label lblUnitNumber;
        private ComboBox cmbAvailability;
        private ComboBox cmbOccupancy;
        private Button btnSaveUnit;
        private Button btnClearUnit;
    }
}