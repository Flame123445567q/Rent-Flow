namespace RentFlow_Application.Forms
{
    partial class RentalUnit_Form
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
            pnlSidebar = new Panel();
            lblLogoIcon = new Label();
            lblLogo = new Label();
            btnDashboard = new Button();
            btnProperties = new Button();
            btnRentalUnits = new Button();
            btnTenants = new Button();
            btnLeases = new Button();
            btnRentPayments = new Button();
            btnExpenses = new Button();
            btnMaintenance = new Button();
            pnlMain = new Panel();
            lblRentalUnits = new Label();
            btnAddUnit = new Button();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            dvgRentalUnits = new DataGridView();
            UnitID = new DataGridViewTextBoxColumn();
            UnitNumber = new DataGridViewTextBoxColumn();
            Property = new DataGridViewTextBoxColumn();
            MonthlyRent = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CurrentTenant = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnEditUnit = new Button();
            pnlTotalUnits = new Panel();
            pnlOccupied = new Panel();
            pnlAvailable = new Panel();
            lblTotalUnits = new Label();
            lblTotalUnitsNum = new Label();
            lblAvailable = new Label();
            lblAvailableNum = new Label();
            lblOccupied = new Label();
            lblOccupiedNum = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRentalUnits).BeginInit();
            pnlTotalUnits.SuspendLayout();
            pnlOccupied.SuspendLayout();
            pnlAvailable.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkBlue;
            pnlSidebar.Controls.Add(btnMaintenance);
            pnlSidebar.Controls.Add(btnExpenses);
            pnlSidebar.Controls.Add(btnRentPayments);
            pnlSidebar.Controls.Add(btnLeases);
            pnlSidebar.Controls.Add(btnTenants);
            pnlSidebar.Controls.Add(btnRentalUnits);
            pnlSidebar.Controls.Add(btnProperties);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(lblLogoIcon);
            pnlSidebar.Location = new Point(12, 12);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.RightToLeft = RightToLeft.No;
            pnlSidebar.Size = new Size(231, 735);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogoIcon
            // 
            lblLogoIcon.AutoSize = true;
            lblLogoIcon.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogoIcon.ForeColor = Color.White;
            lblLogoIcon.Location = new Point(15, 27);
            lblLogoIcon.Name = "lblLogoIcon";
            lblLogoIcon.Size = new Size(48, 38);
            lblLogoIcon.TabIndex = 1;
            lblLogoIcon.Text = "RF";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(59, 24);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(169, 41);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "RentalFlow";
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnProperties
            // 
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.ForeColor = Color.White;
            btnProperties.Location = new Point(10, 140);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(210, 40);
            btnProperties.TabIndex = 1;
            btnProperties.Text = "Properties";
            btnProperties.UseVisualStyleBackColor = true;
            // 
            // btnRentalUnits
            // 
            btnRentalUnits.BackColor = Color.LightSteelBlue;
            btnRentalUnits.Location = new Point(10, 180);
            btnRentalUnits.Name = "btnRentalUnits";
            btnRentalUnits.Size = new Size(210, 40);
            btnRentalUnits.TabIndex = 1;
            btnRentalUnits.Text = "Rental Units";
            btnRentalUnits.UseVisualStyleBackColor = false;
            // 
            // btnTenants
            // 
            btnTenants.FlatStyle = FlatStyle.Flat;
            btnTenants.ForeColor = Color.White;
            btnTenants.Location = new Point(10, 226);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(210, 40);
            btnTenants.TabIndex = 1;
            btnTenants.Text = "Tenants";
            btnTenants.UseVisualStyleBackColor = true;
            // 
            // btnLeases
            // 
            btnLeases.FlatStyle = FlatStyle.Flat;
            btnLeases.ForeColor = Color.White;
            btnLeases.Location = new Point(10, 272);
            btnLeases.Name = "btnLeases";
            btnLeases.Size = new Size(210, 40);
            btnLeases.TabIndex = 1;
            btnLeases.Text = "Leases";
            btnLeases.UseVisualStyleBackColor = true;
            // 
            // btnRentPayments
            // 
            btnRentPayments.FlatStyle = FlatStyle.Flat;
            btnRentPayments.ForeColor = Color.White;
            btnRentPayments.Location = new Point(10, 318);
            btnRentPayments.Name = "btnRentPayments";
            btnRentPayments.Size = new Size(210, 40);
            btnRentPayments.TabIndex = 1;
            btnRentPayments.Text = "Rent Payments";
            btnRentPayments.UseVisualStyleBackColor = true;
            // 
            // btnExpenses
            // 
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ForeColor = Color.White;
            btnExpenses.Location = new Point(10, 353);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(210, 40);
            btnExpenses.TabIndex = 1;
            btnExpenses.Text = "Expenses";
            btnExpenses.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(10, 399);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(210, 40);
            btnMaintenance.TabIndex = 2;
            btnMaintenance.Text = "Maintenace";
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlAvailable);
            pnlMain.Controls.Add(pnlOccupied);
            pnlMain.Controls.Add(pnlTotalUnits);
            pnlMain.Controls.Add(btnEditUnit);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(dvgRentalUnits);
            pnlMain.Controls.Add(pnlSearch);
            pnlMain.Controls.Add(btnAddUnit);
            pnlMain.Controls.Add(lblRentalUnits);
            pnlMain.Location = new Point(246, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(970, 700);
            pnlMain.TabIndex = 1;
            // 
            // lblRentalUnits
            // 
            lblRentalUnits.AutoSize = true;
            lblRentalUnits.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnits.ForeColor = Color.RoyalBlue;
            lblRentalUnits.Location = new Point(18, 36);
            lblRentalUnits.Name = "lblRentalUnits";
            lblRentalUnits.Size = new Size(206, 46);
            lblRentalUnits.TabIndex = 0;
            lblRentalUnits.Text = "Rental Units";
            // 
            // btnAddUnit
            // 
            btnAddUnit.BackColor = Color.Blue;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUnit.ForeColor = Color.White;
            btnAddUnit.Location = new Point(541, 53);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(110, 40);
            btnAddUnit.TabIndex = 1;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.LightBlue;
            pnlSearch.Controls.Add(cmbFilter);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new Point(30, 255);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(930, 70);
            pnlSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(107, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Enter to search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Available", "Occupied" });
            cmbFilter.Location = new Point(330, 15);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(100, 28);
            cmbFilter.TabIndex = 2;
            // 
            // dvgRentalUnits
            // 
            dvgRentalUnits.AllowUserToAddRows = false;
            dvgRentalUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRentalUnits.BackgroundColor = Color.White;
            dvgRentalUnits.BorderStyle = BorderStyle.None;
            dvgRentalUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRentalUnits.Columns.AddRange(new DataGridViewColumn[] { UnitID, UnitNumber, Property, MonthlyRent, Status, CurrentTenant, Actions });
            dvgRentalUnits.Location = new Point(30, 340);
            dvgRentalUnits.Name = "dvgRentalUnits";
            dvgRentalUnits.ReadOnly = true;
            dvgRentalUnits.RowHeadersVisible = false;
            dvgRentalUnits.RowHeadersWidth = 51;
            dvgRentalUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgRentalUnits.Size = new Size(930, 300);
            dvgRentalUnits.TabIndex = 5;
            // 
            // UnitID
            // 
            UnitID.HeaderText = "UnitID";
            UnitID.MinimumWidth = 6;
            UnitID.Name = "UnitID";
            UnitID.ReadOnly = true;
            // 
            // UnitNumber
            // 
            UnitNumber.HeaderText = "UnitNumber";
            UnitNumber.MinimumWidth = 6;
            UnitNumber.Name = "UnitNumber";
            UnitNumber.ReadOnly = true;
            // 
            // Property
            // 
            Property.HeaderText = "Property";
            Property.MinimumWidth = 6;
            Property.Name = "Property";
            Property.ReadOnly = true;
            // 
            // MonthlyRent
            // 
            MonthlyRent.HeaderText = "MonthlyRent";
            MonthlyRent.MinimumWidth = 6;
            MonthlyRent.Name = "MonthlyRent";
            MonthlyRent.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CurrentTenant
            // 
            CurrentTenant.HeaderText = "CurrentTenant";
            CurrentTenant.MinimumWidth = 6;
            CurrentTenant.Name = "CurrentTenant";
            CurrentTenant.ReadOnly = true;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Blue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(556, 646);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 40);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEditUnit
            // 
            btnEditUnit.BackColor = Color.Blue;
            btnEditUnit.FlatStyle = FlatStyle.Flat;
            btnEditUnit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUnit.ForeColor = Color.White;
            btnEditUnit.Location = new Point(292, 646);
            btnEditUnit.Name = "btnEditUnit";
            btnEditUnit.Size = new Size(110, 40);
            btnEditUnit.TabIndex = 8;
            btnEditUnit.Text = "Edit Unit";
            btnEditUnit.UseVisualStyleBackColor = false;
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.Controls.Add(lblTotalUnitsNum);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Location = new Point(33, 100);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(250, 125);
            pnlTotalUnits.TabIndex = 9;
            // 
            // pnlOccupied
            // 
            pnlOccupied.Controls.Add(lblAvailableNum);
            pnlOccupied.Controls.Add(lblAvailable);
            pnlOccupied.Location = new Point(305, 100);
            pnlOccupied.Name = "pnlOccupied";
            pnlOccupied.Size = new Size(250, 125);
            pnlOccupied.TabIndex = 10;
            // 
            // pnlAvailable
            // 
            pnlAvailable.Controls.Add(lblOccupiedNum);
            pnlAvailable.Controls.Add(lblOccupied);
            pnlAvailable.Location = new Point(584, 100);
            pnlAvailable.Name = "pnlAvailable";
            pnlAvailable.Size = new Size(250, 125);
            pnlAvailable.TabIndex = 11;
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Location = new Point(3, 10);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(79, 20);
            lblTotalUnits.TabIndex = 0;
            lblTotalUnits.Text = "Total Units";
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(34, 50);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 20);
            lblTotalUnitsNum.TabIndex = 1;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(12, 10);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(71, 20);
            lblAvailable.TabIndex = 1;
            lblAvailable.Text = "Available";
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(35, 50);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 20);
            lblAvailableNum.TabIndex = 2;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(17, 10);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(72, 20);
            lblOccupied.TabIndex = 1;
            lblOccupied.Text = "Occupied";
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(32, 50);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 20);
            lblOccupiedNum.TabIndex = 2;
            // 
            // RentalUnit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 759);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "RentalUnit_Form";
            Text = "RentalUnit_Form";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRentalUnits).EndInit();
            pnlTotalUnits.ResumeLayout(false);
            pnlTotalUnits.PerformLayout();
            pnlOccupied.ResumeLayout(false);
            pnlOccupied.PerformLayout();
            pnlAvailable.ResumeLayout(false);
            pnlAvailable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLogoIcon;
        private Label lblLogo;
        private Button btnDashboard;
        private Button btnTenants;
        private Button btnRentalUnits;
        private Button btnProperties;
        private Button btnMaintenance;
        private Button btnExpenses;
        private Button btnRentPayments;
        private Button btnLeases;
        private Panel pnlMain;
        private Label lblRentalUnits;
        private Button btnAddUnit;
        private Panel pnlSearch;
        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dvgRentalUnits;
        private DataGridViewTextBoxColumn UnitID;
        private DataGridViewTextBoxColumn UnitNumber;
        private DataGridViewTextBoxColumn Property;
        private DataGridViewTextBoxColumn MonthlyRent;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CurrentTenant;
        private DataGridViewTextBoxColumn Actions;
        private Button btnClear;
        private Button btnEditUnit;
        private Panel pnlAvailable;
        private Panel pnlOccupied;
        private Panel pnlTotalUnits;
        private Label lblOccupiedNum;
        private Label lblOccupied;
        private Label lblAvailableNum;
        private Label lblAvailable;
        private Label lblTotalUnitsNum;
        private Label lblTotalUnits;
    }
}