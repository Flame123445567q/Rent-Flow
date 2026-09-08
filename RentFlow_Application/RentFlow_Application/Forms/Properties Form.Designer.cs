namespace RentFlow_Application.Forms
{
    partial class Properties_Form
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
            pnlMainForm = new Panel();
            btnMaintenance = new Button();
            btnExpenses = new Button();
            btnRentPayments = new Button();
            btnLeases = new Button();
            btnTenants = new Button();
            btnRentalUnits = new Button();
            btnProperties = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            lblLogoIcon = new Label();
            pnlContent = new Panel();
            dgvProperties = new DataGridView();
            PropertyID = new DataGridViewTextBoxColumn();
            PropertyName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            TotalUnits = new DataGridViewTextBoxColumn();
            Occupied = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            pnlSearch = new Panel();
            btnPrint = new Button();
            button1 = new Button();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            btnAddProperty = new Button();
            lblPropertyCount = new Label();
            lblProperties = new Label();
            lblRentalUnits = new Label();
            btnAddUnit = new Button();
            pnlTotalUnits = new Panel();
            lblTotalUnitsNum = new Label();
            lblTotalUnits = new Label();
            pnlOccupied = new Panel();
            lblAvailableNum = new Label();
            lblAvailable = new Label();
            pnlAvailable = new Panel();
            lblOccupiedNum = new Label();
            lblOccupied = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblSearch = new Label();
            dvgRentalUnits = new DataGridView();
            UnitID = new DataGridViewTextBoxColumn();
            UnitNumber = new DataGridViewTextBoxColumn();
            Property = new DataGridViewTextBoxColumn();
            MonthlyRent = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CurrentTenant = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            pnlRentalUnits = new Panel();
            pnlTenants = new Panel();
            pnlSearching = new Panel();
            cmbAllStatus = new ComboBox();
            cmbAllProperties = new ComboBox();
            txtSearchTenant = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NTENANT = new DataGridViewTextBoxColumn();
            NContact = new DataGridViewTextBoxColumn();
            nProperty = new DataGridViewTextBoxColumn();
            NUnit = new DataGridViewTextBoxColumn();
            NLeaseStatus = new DataGridViewTextBoxColumn();
            NOUTSTANDING = new DataGridViewTextBoxColumn();
            NAction = new DataGridViewTextBoxColumn();
            lblTenants = new Label();
            pnlTotalProperties = new Panel();
            lblTotalPropertiesNumber = new Label();
            lblTotalPropertiesDisplay = new Label();
            lblTotalProperties = new Label();
            pnlOccupiedUnits = new Panel();
            lblOccupiedUnitsNumber = new Label();
            lblOccupiedUnitsDisplay = new Label();
            lblOccupiedUnits = new Label();
            pnlVacantUnits = new Panel();
            lblVacantUnitsNumber = new Label();
            lblVacantUnitsDisplay = new Label();
            lblVacantUnits = new Label();
            pnlOpenMaintenance = new Panel();
            lblOpenMaintenanceDisplay = new Label();
            lblOpenMaintenanceNumber = new Label();
            lblOpenMaintenance = new Label();
            pnlOutstadingRent = new Panel();
            lblOutstandingRentNumber = new Label();
            lblOutstandingRentDisplay = new Label();
            lblOutstandingRent = new Label();
            pnlMonthlyRentalIncome = new Panel();
            lblMonthlyRentalIncomeNumber = new Label();
            lblMonthlyRentalIncomeDisplay = new Label();
            lblMonthlyRentalIncome = new Label();
            lblDashboard = new Label();
            lblCurrentDate = new Label();
            dGVRecentRentPayments = new DataGridView();
            TENANT = new DataGridViewTextBoxColumn();
            AMOUNT = new DataGridViewTextBoxColumn();
            DATE = new DataGridViewTextBoxColumn();
            STATUSES = new DataGridViewTextBoxColumn();
            pnlDashBoard = new Panel();
            pnlMainForm.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlSearch.SuspendLayout();
            pnlTotalUnits.SuspendLayout();
            pnlOccupied.SuspendLayout();
            pnlAvailable.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRentalUnits).BeginInit();
            pnlRentalUnits.SuspendLayout();
            pnlTenants.SuspendLayout();
            pnlSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTotalProperties.SuspendLayout();
            pnlOccupiedUnits.SuspendLayout();
            pnlVacantUnits.SuspendLayout();
            pnlOpenMaintenance.SuspendLayout();
            pnlOutstadingRent.SuspendLayout();
            pnlMonthlyRentalIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVRecentRentPayments).BeginInit();
            pnlDashBoard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainForm
            // 
            pnlMainForm.BackColor = Color.DarkBlue;
            pnlMainForm.Controls.Add(btnMaintenance);
            pnlMainForm.Controls.Add(btnExpenses);
            pnlMainForm.Controls.Add(btnRentPayments);
            pnlMainForm.Controls.Add(btnLeases);
            pnlMainForm.Controls.Add(btnTenants);
            pnlMainForm.Controls.Add(btnRentalUnits);
            pnlMainForm.Controls.Add(btnProperties);
            pnlMainForm.Controls.Add(btnDashboard);
            pnlMainForm.Controls.Add(lblLogo);
            pnlMainForm.Controls.Add(lblLogoIcon);
            pnlMainForm.Location = new Point(12, 12);
            pnlMainForm.Name = "pnlMainForm";
            pnlMainForm.Size = new Size(231, 735);
            pnlMainForm.TabIndex = 0;
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(10, 422);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(210, 40);
            btnMaintenance.TabIndex = 9;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnExpenses
            // 
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ForeColor = Color.White;
            btnExpenses.Location = new Point(10, 376);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(210, 40);
            btnExpenses.TabIndex = 8;
            btnExpenses.Text = "Expenses";
            btnExpenses.UseVisualStyleBackColor = true;
            // 
            // btnRentPayments
            // 
            btnRentPayments.FlatStyle = FlatStyle.Flat;
            btnRentPayments.ForeColor = Color.White;
            btnRentPayments.Location = new Point(10, 330);
            btnRentPayments.Name = "btnRentPayments";
            btnRentPayments.Size = new Size(210, 40);
            btnRentPayments.TabIndex = 7;
            btnRentPayments.Text = "Rent Payments";
            btnRentPayments.UseVisualStyleBackColor = true;
            // 
            // btnLeases
            // 
            btnLeases.FlatStyle = FlatStyle.Flat;
            btnLeases.ForeColor = Color.White;
            btnLeases.Location = new Point(10, 284);
            btnLeases.Name = "btnLeases";
            btnLeases.Size = new Size(210, 40);
            btnLeases.TabIndex = 6;
            btnLeases.Text = "Leases";
            btnLeases.UseVisualStyleBackColor = true;
            // 
            // btnTenants
            // 
            btnTenants.FlatStyle = FlatStyle.Flat;
            btnTenants.ForeColor = Color.White;
            btnTenants.Location = new Point(10, 238);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(210, 40);
            btnTenants.TabIndex = 5;
            btnTenants.Text = " Tenants";
            btnTenants.UseVisualStyleBackColor = true;
            btnTenants.Click += btnTenants_Click;
            // 
            // btnRentalUnits
            // 
            btnRentalUnits.FlatStyle = FlatStyle.Flat;
            btnRentalUnits.ForeColor = Color.White;
            btnRentalUnits.Location = new Point(10, 192);
            btnRentalUnits.Name = "btnRentalUnits";
            btnRentalUnits.Size = new Size(210, 40);
            btnRentalUnits.TabIndex = 4;
            btnRentalUnits.Text = "Rental Units";
            btnRentalUnits.UseVisualStyleBackColor = true;
            btnRentalUnits.Click += btnRentalUnits_Click;
            // 
            // btnProperties
            // 
            btnProperties.BackColor = Color.DarkBlue;
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.ForeColor = Color.White;
            btnProperties.Location = new Point(10, 146);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(210, 40);
            btnProperties.TabIndex = 3;
            btnProperties.Text = "Properties";
            btnProperties.UseVisualStyleBackColor = false;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 40);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(59, 24);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(145, 41);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "RentFlow";
            // 
            // lblLogoIcon
            // 
            lblLogoIcon.AutoSize = true;
            lblLogoIcon.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogoIcon.ForeColor = Color.White;
            lblLogoIcon.Location = new Point(15, 27);
            lblLogoIcon.Name = "lblLogoIcon";
            lblLogoIcon.Size = new Size(48, 38);
            lblLogoIcon.TabIndex = 0;
            lblLogoIcon.Text = "RF";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.BorderStyle = BorderStyle.Fixed3D;
            pnlContent.Controls.Add(dgvProperties);
            pnlContent.Controls.Add(pnlSearch);
            pnlContent.Controls.Add(btnAddProperty);
            pnlContent.Controls.Add(lblPropertyCount);
            pnlContent.Controls.Add(lblProperties);
            pnlContent.Dock = DockStyle.Right;
            pnlContent.Location = new Point(269, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1110, 732);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlMain_Paint;
            // 
            // dgvProperties
            // 
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.BackgroundColor = Color.White;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyID, PropertyName, Address, TotalUnits, Occupied, Available, Status, Actions });
            dgvProperties.Location = new Point(3, 282);
            dgvProperties.MultiSelect = false;
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RowHeadersWidth = 51;
            dgvProperties.Size = new Size(1082, 448);
            dgvProperties.TabIndex = 4;
            // 
            // PropertyID
            // 
            PropertyID.HeaderText = "PropertyID";
            PropertyID.MinimumWidth = 6;
            PropertyID.Name = "PropertyID";
            PropertyID.ReadOnly = true;
            // 
            // PropertyName
            // 
            PropertyName.HeaderText = "PropertyName";
            PropertyName.MinimumWidth = 6;
            PropertyName.Name = "PropertyName";
            PropertyName.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // TotalUnits
            // 
            TotalUnits.HeaderText = "TotalUnits";
            TotalUnits.MinimumWidth = 6;
            TotalUnits.Name = "TotalUnits";
            TotalUnits.ReadOnly = true;
            // 
            // Occupied
            // 
            Occupied.HeaderText = "Occupied";
            Occupied.MinimumWidth = 6;
            Occupied.Name = "Occupied";
            Occupied.ReadOnly = true;
            // 
            // Available
            // 
            Available.HeaderText = "Available";
            Available.MinimumWidth = 6;
            Available.Name = "Available";
            Available.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.Gainsboro;
            pnlSearch.BorderStyle = BorderStyle.Fixed3D;
            pnlSearch.Controls.Add(btnPrint);
            pnlSearch.Controls.Add(button1);
            pnlSearch.Controls.Add(cmbFilter);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(30, 195);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1055, 50);
            pnlSearch.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(954, 10);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(857, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "", "Active", "", "Inactive" });
            cmbFilter.Location = new Point(376, 11);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(110, 28);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Location = new Point(23, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(335, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search properties";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = Color.DarkBlue;
            btnAddProperty.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProperty.ForeColor = Color.White;
            btnAddProperty.Location = new Point(920, 120);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(165, 45);
            btnAddProperty.TabIndex = 2;
            btnAddProperty.Text = " +Add Property";
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // lblPropertyCount
            // 
            lblPropertyCount.AutoSize = true;
            lblPropertyCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropertyCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblPropertyCount.Location = new Point(18, 77);
            lblPropertyCount.Name = "lblPropertyCount";
            lblPropertyCount.Size = new Size(194, 28);
            lblPropertyCount.TabIndex = 1;
            lblPropertyCount.Text = "4 Properties in total";
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperties.Location = new Point(18, 36);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(164, 41);
            lblProperties.TabIndex = 0;
            lblProperties.Text = "Properties";
            // 
            // lblRentalUnits
            // 
            lblRentalUnits.AutoSize = true;
            lblRentalUnits.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnits.ForeColor = Color.RoyalBlue;
            lblRentalUnits.Location = new Point(41, 39);
            lblRentalUnits.Name = "lblRentalUnits";
            lblRentalUnits.Size = new Size(206, 46);
            lblRentalUnits.TabIndex = 1;
            lblRentalUnits.Text = "Rental Units";
            // 
            // btnAddUnit
            // 
            btnAddUnit.BackColor = Color.Blue;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUnit.ForeColor = Color.White;
            btnAddUnit.Location = new Point(678, 37);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(110, 40);
            btnAddUnit.TabIndex = 2;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.Controls.Add(lblTotalUnitsNum);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Location = new Point(41, 99);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(250, 125);
            pnlTotalUnits.TabIndex = 10;
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(34, 50);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 20);
            lblTotalUnitsNum.TabIndex = 1;
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
            // pnlOccupied
            // 
            pnlOccupied.Controls.Add(lblAvailableNum);
            pnlOccupied.Controls.Add(lblAvailable);
            pnlOccupied.Location = new Point(333, 99);
            pnlOccupied.Name = "pnlOccupied";
            pnlOccupied.Size = new Size(250, 125);
            pnlOccupied.TabIndex = 11;
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(35, 50);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 20);
            lblAvailableNum.TabIndex = 2;
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
            // pnlAvailable
            // 
            pnlAvailable.Controls.Add(lblOccupiedNum);
            pnlAvailable.Controls.Add(lblOccupied);
            pnlAvailable.Location = new Point(620, 99);
            pnlAvailable.Name = "pnlAvailable";
            pnlAvailable.Size = new Size(250, 125);
            pnlAvailable.TabIndex = 12;
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(32, 50);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 20);
            lblOccupiedNum.TabIndex = 2;
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
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblSearch);
            panel1.Location = new Point(41, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 70);
            panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Available", "Occupied" });
            comboBox1.Location = new Point(330, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 1;
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
            // dvgRentalUnits
            // 
            dvgRentalUnits.AllowUserToAddRows = false;
            dvgRentalUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRentalUnits.BackgroundColor = Color.White;
            dvgRentalUnits.BorderStyle = BorderStyle.None;
            dvgRentalUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRentalUnits.Columns.AddRange(new DataGridViewColumn[] { UnitID, UnitNumber, Property, MonthlyRent, dataGridViewTextBoxColumn1, CurrentTenant, dataGridViewTextBoxColumn2 });
            dvgRentalUnits.Location = new Point(32, 342);
            dvgRentalUnits.Name = "dvgRentalUnits";
            dvgRentalUnits.ReadOnly = true;
            dvgRentalUnits.RowHeadersVisible = false;
            dvgRentalUnits.RowHeadersWidth = 51;
            dvgRentalUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgRentalUnits.Size = new Size(939, 390);
            dvgRentalUnits.TabIndex = 14;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Status";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CurrentTenant
            // 
            CurrentTenant.HeaderText = "CurrentTenant";
            CurrentTenant.MinimumWidth = 6;
            CurrentTenant.Name = "CurrentTenant";
            CurrentTenant.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Actions";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pnlRentalUnits
            // 
            pnlRentalUnits.Controls.Add(dvgRentalUnits);
            pnlRentalUnits.Controls.Add(panel1);
            pnlRentalUnits.Controls.Add(pnlAvailable);
            pnlRentalUnits.Controls.Add(pnlOccupied);
            pnlRentalUnits.Controls.Add(pnlTotalUnits);
            pnlRentalUnits.Controls.Add(btnAddUnit);
            pnlRentalUnits.Controls.Add(lblRentalUnits);
            pnlRentalUnits.Location = new Point(269, 0);
            pnlRentalUnits.Name = "pnlRentalUnits";
            pnlRentalUnits.Size = new Size(1110, 732);
            pnlRentalUnits.TabIndex = 5;
            // 
            // pnlTenants
            // 
            pnlTenants.Controls.Add(pnlSearching);
            pnlTenants.Controls.Add(label1);
            pnlTenants.Controls.Add(dataGridView1);
            pnlTenants.Controls.Add(lblTenants);
            pnlTenants.Location = new Point(269, 0);
            pnlTenants.Name = "pnlTenants";
            pnlTenants.Size = new Size(1110, 732);
            pnlTenants.TabIndex = 17;
            // 
            // pnlSearching
            // 
            pnlSearching.Controls.Add(cmbAllStatus);
            pnlSearching.Controls.Add(cmbAllProperties);
            pnlSearching.Controls.Add(txtSearchTenant);
            pnlSearching.Location = new Point(20, 158);
            pnlSearching.Name = "pnlSearching";
            pnlSearching.Size = new Size(941, 104);
            pnlSearching.TabIndex = 4;
            // 
            // cmbAllStatus
            // 
            cmbAllStatus.FormattingEnabled = true;
            cmbAllStatus.Location = new Point(540, 38);
            cmbAllStatus.Name = "cmbAllStatus";
            cmbAllStatus.Size = new Size(180, 28);
            cmbAllStatus.TabIndex = 2;
            // 
            // cmbAllProperties
            // 
            cmbAllProperties.FormattingEnabled = true;
            cmbAllProperties.Location = new Point(308, 38);
            cmbAllProperties.Name = "cmbAllProperties";
            cmbAllProperties.Size = new Size(213, 28);
            cmbAllProperties.TabIndex = 1;
            // 
            // txtSearchTenant
            // 
            txtSearchTenant.Location = new Point(17, 39);
            txtSearchTenant.Name = "txtSearchTenant";
            txtSearchTenant.PlaceholderText = "Search tenants...";
            txtSearchTenant.Size = new Size(254, 27);
            txtSearchTenant.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NTENANT, NContact, nProperty, NUnit, NLeaseStatus, NOUTSTANDING, NAction });
            dataGridView1.Location = new Point(20, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(912, 436);
            dataGridView1.TabIndex = 2;
            // 
            // NTENANT
            // 
            NTENANT.HeaderText = "TENANT";
            NTENANT.MinimumWidth = 6;
            NTENANT.Name = "NTENANT";
            NTENANT.Width = 125;
            // 
            // NContact
            // 
            NContact.HeaderText = "CONTACT";
            NContact.MinimumWidth = 6;
            NContact.Name = "NContact";
            NContact.Width = 125;
            // 
            // nProperty
            // 
            nProperty.HeaderText = "PROPERTY";
            nProperty.MinimumWidth = 6;
            nProperty.Name = "nProperty";
            nProperty.Width = 125;
            // 
            // NUnit
            // 
            NUnit.HeaderText = "UNIT";
            NUnit.MinimumWidth = 6;
            NUnit.Name = "NUnit";
            NUnit.Width = 125;
            // 
            // NLeaseStatus
            // 
            NLeaseStatus.HeaderText = "LEASE STATUS";
            NLeaseStatus.MinimumWidth = 6;
            NLeaseStatus.Name = "NLeaseStatus";
            NLeaseStatus.Width = 125;
            // 
            // NOUTSTANDING
            // 
            NOUTSTANDING.HeaderText = "OUTSTANDING";
            NOUTSTANDING.MinimumWidth = 6;
            NOUTSTANDING.Name = "NOUTSTANDING";
            NOUTSTANDING.Width = 125;
            // 
            // NAction
            // 
            NAction.HeaderText = "ACTIONS";
            NAction.MinimumWidth = 6;
            NAction.Name = "NAction";
            NAction.Width = 125;
            // 
            // lblTenants
            // 
            lblTenants.AutoSize = true;
            lblTenants.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenants.Location = new Point(32, 44);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(126, 41);
            lblTenants.TabIndex = 0;
            lblTenants.Text = "Tenants";
            // 
            // pnlTotalProperties
            // 
            pnlTotalProperties.Controls.Add(lblTotalPropertiesNumber);
            pnlTotalProperties.Controls.Add(lblTotalPropertiesDisplay);
            pnlTotalProperties.Controls.Add(lblTotalProperties);
            pnlTotalProperties.Location = new Point(23, 122);
            pnlTotalProperties.Name = "pnlTotalProperties";
            pnlTotalProperties.Size = new Size(250, 125);
            pnlTotalProperties.TabIndex = 0;
            // 
            // lblTotalPropertiesNumber
            // 
            lblTotalPropertiesNumber.AutoSize = true;
            lblTotalPropertiesNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPropertiesNumber.Location = new Point(9, 47);
            lblTotalPropertiesNumber.Name = "lblTotalPropertiesNumber";
            lblTotalPropertiesNumber.Size = new Size(0, 38);
            lblTotalPropertiesNumber.TabIndex = 1;
            // 
            // lblTotalPropertiesDisplay
            // 
            lblTotalPropertiesDisplay.AutoSize = true;
            lblTotalPropertiesDisplay.Location = new Point(9, 97);
            lblTotalPropertiesDisplay.Name = "lblTotalPropertiesDisplay";
            lblTotalPropertiesDisplay.Size = new Size(0, 20);
            lblTotalPropertiesDisplay.TabIndex = 3;
            // 
            // lblTotalProperties
            // 
            lblTotalProperties.AutoSize = true;
            lblTotalProperties.Location = new Point(8, 6);
            lblTotalProperties.Name = "lblTotalProperties";
            lblTotalProperties.Size = new Size(113, 20);
            lblTotalProperties.TabIndex = 0;
            lblTotalProperties.Text = "Total Properties";
            // 
            // pnlOccupiedUnits
            // 
            pnlOccupiedUnits.Controls.Add(lblOccupiedUnitsNumber);
            pnlOccupiedUnits.Controls.Add(lblOccupiedUnitsDisplay);
            pnlOccupiedUnits.Controls.Add(lblOccupiedUnits);
            pnlOccupiedUnits.Location = new Point(345, 122);
            pnlOccupiedUnits.Name = "pnlOccupiedUnits";
            pnlOccupiedUnits.Size = new Size(250, 125);
            pnlOccupiedUnits.TabIndex = 1;
            // 
            // lblOccupiedUnitsNumber
            // 
            lblOccupiedUnitsNumber.AutoSize = true;
            lblOccupiedUnitsNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOccupiedUnitsNumber.Location = new Point(12, 47);
            lblOccupiedUnitsNumber.Name = "lblOccupiedUnitsNumber";
            lblOccupiedUnitsNumber.Size = new Size(0, 38);
            lblOccupiedUnitsNumber.TabIndex = 6;
            // 
            // lblOccupiedUnitsDisplay
            // 
            lblOccupiedUnitsDisplay.AutoSize = true;
            lblOccupiedUnitsDisplay.Location = new Point(13, 97);
            lblOccupiedUnitsDisplay.Name = "lblOccupiedUnitsDisplay";
            lblOccupiedUnitsDisplay.Size = new Size(0, 20);
            lblOccupiedUnitsDisplay.TabIndex = 4;
            // 
            // lblOccupiedUnits
            // 
            lblOccupiedUnits.AutoSize = true;
            lblOccupiedUnits.Location = new Point(3, 11);
            lblOccupiedUnits.Name = "lblOccupiedUnits";
            lblOccupiedUnits.Size = new Size(109, 20);
            lblOccupiedUnits.TabIndex = 6;
            lblOccupiedUnits.Text = "Occupied Units";
            // 
            // pnlVacantUnits
            // 
            pnlVacantUnits.Controls.Add(lblVacantUnitsNumber);
            pnlVacantUnits.Controls.Add(lblVacantUnitsDisplay);
            pnlVacantUnits.Controls.Add(lblVacantUnits);
            pnlVacantUnits.Location = new Point(678, 122);
            pnlVacantUnits.Name = "pnlVacantUnits";
            pnlVacantUnits.Size = new Size(250, 125);
            pnlVacantUnits.TabIndex = 1;
            // 
            // lblVacantUnitsNumber
            // 
            lblVacantUnitsNumber.AutoSize = true;
            lblVacantUnitsNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVacantUnitsNumber.Location = new Point(12, 46);
            lblVacantUnitsNumber.Name = "lblVacantUnitsNumber";
            lblVacantUnitsNumber.Size = new Size(0, 38);
            lblVacantUnitsNumber.TabIndex = 5;
            // 
            // lblVacantUnitsDisplay
            // 
            lblVacantUnitsDisplay.AutoSize = true;
            lblVacantUnitsDisplay.Location = new Point(12, 97);
            lblVacantUnitsDisplay.Name = "lblVacantUnitsDisplay";
            lblVacantUnitsDisplay.Size = new Size(132, 20);
            lblVacantUnitsDisplay.TabIndex = 7;
            lblVacantUnitsDisplay.Text = "Available for lease";
            // 
            // lblVacantUnits
            // 
            lblVacantUnits.AutoSize = true;
            lblVacantUnits.Location = new Point(3, 6);
            lblVacantUnits.Name = "lblVacantUnits";
            lblVacantUnits.Size = new Size(90, 20);
            lblVacantUnits.TabIndex = 5;
            lblVacantUnits.Text = "Vacant Units";
            // 
            // pnlOpenMaintenance
            // 
            pnlOpenMaintenance.Controls.Add(lblOpenMaintenanceDisplay);
            pnlOpenMaintenance.Controls.Add(lblOpenMaintenanceNumber);
            pnlOpenMaintenance.Controls.Add(lblOpenMaintenance);
            pnlOpenMaintenance.Location = new Point(678, 287);
            pnlOpenMaintenance.Name = "pnlOpenMaintenance";
            pnlOpenMaintenance.Size = new Size(250, 125);
            pnlOpenMaintenance.TabIndex = 1;
            // 
            // lblOpenMaintenanceDisplay
            // 
            lblOpenMaintenanceDisplay.AutoSize = true;
            lblOpenMaintenanceDisplay.Location = new Point(12, 101);
            lblOpenMaintenanceDisplay.Name = "lblOpenMaintenanceDisplay";
            lblOpenMaintenanceDisplay.Size = new Size(0, 20);
            lblOpenMaintenanceDisplay.TabIndex = 8;
            // 
            // lblOpenMaintenanceNumber
            // 
            lblOpenMaintenanceNumber.AutoSize = true;
            lblOpenMaintenanceNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpenMaintenanceNumber.Location = new Point(12, 55);
            lblOpenMaintenanceNumber.Name = "lblOpenMaintenanceNumber";
            lblOpenMaintenanceNumber.Size = new Size(0, 38);
            lblOpenMaintenanceNumber.TabIndex = 2;
            // 
            // lblOpenMaintenance
            // 
            lblOpenMaintenance.AutoSize = true;
            lblOpenMaintenance.Location = new Point(3, 13);
            lblOpenMaintenance.Name = "lblOpenMaintenance";
            lblOpenMaintenance.Size = new Size(134, 20);
            lblOpenMaintenance.TabIndex = 2;
            lblOpenMaintenance.Text = "Open Maintenance";
            // 
            // pnlOutstadingRent
            // 
            pnlOutstadingRent.Controls.Add(lblOutstandingRentNumber);
            pnlOutstadingRent.Controls.Add(lblOutstandingRentDisplay);
            pnlOutstadingRent.Controls.Add(lblOutstandingRent);
            pnlOutstadingRent.Location = new Point(345, 287);
            pnlOutstadingRent.Name = "pnlOutstadingRent";
            pnlOutstadingRent.Size = new Size(250, 125);
            pnlOutstadingRent.TabIndex = 1;
            // 
            // lblOutstandingRentNumber
            // 
            lblOutstandingRentNumber.AutoSize = true;
            lblOutstandingRentNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutstandingRentNumber.Location = new Point(12, 55);
            lblOutstandingRentNumber.Name = "lblOutstandingRentNumber";
            lblOutstandingRentNumber.Size = new Size(0, 38);
            lblOutstandingRentNumber.TabIndex = 3;
            // 
            // lblOutstandingRentDisplay
            // 
            lblOutstandingRentDisplay.AutoSize = true;
            lblOutstandingRentDisplay.Location = new Point(13, 101);
            lblOutstandingRentDisplay.Name = "lblOutstandingRentDisplay";
            lblOutstandingRentDisplay.Size = new Size(0, 20);
            lblOutstandingRentDisplay.TabIndex = 6;
            // 
            // lblOutstandingRent
            // 
            lblOutstandingRent.AutoSize = true;
            lblOutstandingRent.Location = new Point(3, 7);
            lblOutstandingRent.Name = "lblOutstandingRent";
            lblOutstandingRent.Size = new Size(124, 20);
            lblOutstandingRent.TabIndex = 3;
            lblOutstandingRent.Text = "Outstanding Rent";
            // 
            // pnlMonthlyRentalIncome
            // 
            pnlMonthlyRentalIncome.Controls.Add(lblMonthlyRentalIncomeNumber);
            pnlMonthlyRentalIncome.Controls.Add(lblMonthlyRentalIncomeDisplay);
            pnlMonthlyRentalIncome.Controls.Add(lblMonthlyRentalIncome);
            pnlMonthlyRentalIncome.Location = new Point(20, 287);
            pnlMonthlyRentalIncome.Name = "pnlMonthlyRentalIncome";
            pnlMonthlyRentalIncome.Size = new Size(250, 125);
            pnlMonthlyRentalIncome.TabIndex = 1;
            // 
            // lblMonthlyRentalIncomeNumber
            // 
            lblMonthlyRentalIncomeNumber.AutoSize = true;
            lblMonthlyRentalIncomeNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonthlyRentalIncomeNumber.Location = new Point(12, 55);
            lblMonthlyRentalIncomeNumber.Name = "lblMonthlyRentalIncomeNumber";
            lblMonthlyRentalIncomeNumber.Size = new Size(0, 38);
            lblMonthlyRentalIncomeNumber.TabIndex = 4;
            // 
            // lblMonthlyRentalIncomeDisplay
            // 
            lblMonthlyRentalIncomeDisplay.AutoSize = true;
            lblMonthlyRentalIncomeDisplay.Location = new Point(11, 101);
            lblMonthlyRentalIncomeDisplay.Name = "lblMonthlyRentalIncomeDisplay";
            lblMonthlyRentalIncomeDisplay.Size = new Size(0, 20);
            lblMonthlyRentalIncomeDisplay.TabIndex = 5;
            // 
            // lblMonthlyRentalIncome
            // 
            lblMonthlyRentalIncome.AutoSize = true;
            lblMonthlyRentalIncome.Location = new Point(5, 16);
            lblMonthlyRentalIncome.Name = "lblMonthlyRentalIncome";
            lblMonthlyRentalIncome.Size = new Size(162, 20);
            lblMonthlyRentalIncome.TabIndex = 4;
            lblMonthlyRentalIncome.Text = "Monthly Rental Income";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(31, 6);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(171, 40);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Dashboard";
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Location = new Point(43, 56);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(0, 20);
            lblCurrentDate.TabIndex = 3;
            // 
            // dGVRecentRentPayments
            // 
            dGVRecentRentPayments.BackgroundColor = Color.White;
            dGVRecentRentPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVRecentRentPayments.Columns.AddRange(new DataGridViewColumn[] { TENANT, AMOUNT, DATE, STATUSES });
            dGVRecentRentPayments.Location = new Point(20, 480);
            dGVRecentRentPayments.Name = "dGVRecentRentPayments";
            dGVRecentRentPayments.RowHeadersWidth = 51;
            dGVRecentRentPayments.Size = new Size(670, 188);
            dGVRecentRentPayments.TabIndex = 4;
            // 
            // TENANT
            // 
            TENANT.HeaderText = "TENANT";
            TENANT.MinimumWidth = 6;
            TENANT.Name = "TENANT";
            TENANT.Width = 125;
            // 
            // AMOUNT
            // 
            AMOUNT.HeaderText = "AMOUNT";
            AMOUNT.MinimumWidth = 6;
            AMOUNT.Name = "AMOUNT";
            AMOUNT.Width = 125;
            // 
            // DATE
            // 
            DATE.HeaderText = "DATE";
            DATE.MinimumWidth = 6;
            DATE.Name = "DATE";
            DATE.Width = 125;
            // 
            // STATUSES
            // 
            STATUSES.HeaderText = "STATUSES";
            STATUSES.MinimumWidth = 6;
            STATUSES.Name = "STATUSES";
            STATUSES.Width = 125;
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.Controls.Add(dGVRecentRentPayments);
            pnlDashBoard.Controls.Add(lblCurrentDate);
            pnlDashBoard.Controls.Add(lblDashboard);
            pnlDashBoard.Controls.Add(pnlMonthlyRentalIncome);
            pnlDashBoard.Controls.Add(pnlOutstadingRent);
            pnlDashBoard.Controls.Add(pnlOpenMaintenance);
            pnlDashBoard.Controls.Add(pnlVacantUnits);
            pnlDashBoard.Controls.Add(pnlOccupiedUnits);
            pnlDashBoard.Controls.Add(pnlTotalProperties);
            pnlDashBoard.Location = new Point(269, 0);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(1110, 732);
            pnlDashBoard.TabIndex = 5;
            // 
            // Properties_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 732);
            Controls.Add(pnlDashBoard);
            Controls.Add(pnlTenants);
            Controls.Add(pnlRentalUnits);
            Controls.Add(pnlContent);
            Controls.Add(pnlMainForm);
            Name = "Properties_Form";
            Text = "Properties_Form";
            Load += Properties_Form_Load;
            pnlMainForm.ResumeLayout(false);
            pnlMainForm.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlTotalUnits.ResumeLayout(false);
            pnlTotalUnits.PerformLayout();
            pnlOccupied.ResumeLayout(false);
            pnlOccupied.PerformLayout();
            pnlAvailable.ResumeLayout(false);
            pnlAvailable.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRentalUnits).EndInit();
            pnlRentalUnits.ResumeLayout(false);
            pnlRentalUnits.PerformLayout();
            pnlTenants.ResumeLayout(false);
            pnlTenants.PerformLayout();
            pnlSearching.ResumeLayout(false);
            pnlSearching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTotalProperties.ResumeLayout(false);
            pnlTotalProperties.PerformLayout();
            pnlOccupiedUnits.ResumeLayout(false);
            pnlOccupiedUnits.PerformLayout();
            pnlVacantUnits.ResumeLayout(false);
            pnlVacantUnits.PerformLayout();
            pnlOpenMaintenance.ResumeLayout(false);
            pnlOpenMaintenance.PerformLayout();
            pnlOutstadingRent.ResumeLayout(false);
            pnlOutstadingRent.PerformLayout();
            pnlMonthlyRentalIncome.ResumeLayout(false);
            pnlMonthlyRentalIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVRecentRentPayments).EndInit();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion 

        private Panel pnlMainForm;
        private Button btnDashboard;
        private Label lblLogo;
        private Label lblLogoIcon;
        private Button btnMaintenance;
        private Button btnExpenses;
        private Button btnRentPayments;
        private Button btnLeases;
        private Button btnTenants;
        private Button btnRentalUnits;
        private Button btnProperties;
        private Panel pnlContent;
        private Label lblProperties;
        private Label lblPropertyCount;
        private Button btnAddProperty;
        private Panel pnlSearch;
        private TextBox txtSearch;
        private ComboBox cmbFilter;
        private Button button1;
        private Button btnPrint;
        private DataGridView dgvProperties;
        private DataGridViewTextBoxColumn PropertyID;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn TotalUnits;
        private DataGridViewTextBoxColumn Occupied;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Actions;
        private Label lblRentalUnits;
        private Button btnAddUnit;
        private Panel pnlTotalUnits;
        private Label lblTotalUnitsNum;
        private Label lblTotalUnits;
        private Panel pnlOccupied;
        private Label lblAvailableNum;
        private Label lblAvailable;
        private Panel pnlAvailable;
        private Label lblOccupiedNum;
        private Label lblOccupied;
        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label lblSearch;
        private DataGridView dvgRentalUnits;
        private DataGridViewTextBoxColumn UnitID;
        private DataGridViewTextBoxColumn UnitNumber;
        private DataGridViewTextBoxColumn Property;
        private DataGridViewTextBoxColumn MonthlyRent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CurrentTenant;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Panel pnlRentalUnits;
        private Panel pnlTenants;
        private Label lblTenants;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NTENANT;
        private DataGridViewTextBoxColumn NContact;
        private DataGridViewTextBoxColumn nProperty;
        private DataGridViewTextBoxColumn NUnit;
        private DataGridViewTextBoxColumn NLeaseStatus;
        private Panel pnlSearching;
        private Label label1;
        private DataGridViewTextBoxColumn NOUTSTANDING;
        private DataGridViewTextBoxColumn NAction;
        private ComboBox cmbAllStatus;
        private ComboBox cmbAllProperties;
        private TextBox txtSearchTenant;
        private Panel pnlTotalProperties;
        private Label lblTotalPropertiesNumber;
        private Label lblTotalPropertiesDisplay;
        private Label lblTotalProperties;
        private Panel pnlOccupiedUnits;
        private Label lblOccupiedUnitsNumber;
        private Label lblOccupiedUnitsDisplay;
        private Label lblOccupiedUnits;
        private Panel pnlVacantUnits;
        private Label lblVacantUnitsNumber;
        private Label lblVacantUnitsDisplay;
        private Label lblVacantUnits;
        private Panel pnlOpenMaintenance;
        private Label lblOpenMaintenanceDisplay;
        private Label lblOpenMaintenanceNumber;
        private Label lblOpenMaintenance;
        private Panel pnlOutstadingRent;
        private Label lblOutstandingRentNumber;
        private Label lblOutstandingRentDisplay;
        private Label lblOutstandingRent;
        private Panel pnlMonthlyRentalIncome;
        private Label lblMonthlyRentalIncomeNumber;
        private Label lblMonthlyRentalIncomeDisplay;
        private Label lblMonthlyRentalIncome;
        private Label lblDashboard;
        private Label lblCurrentDate;
        private DataGridView dGVRecentRentPayments;
        private DataGridViewTextBoxColumn TENANT;
        private DataGridViewTextBoxColumn AMOUNT;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn STATUSES;
        public Panel pnlDashBoard;
    }
}