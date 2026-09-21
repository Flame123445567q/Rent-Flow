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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlMainForm = new Panel();
            pnlUserLoginInfo = new Panel();
            lblUserName = new Label();
            btnLogOut = new Button();
            lblRole = new Label();
            btnMaintenance = new Button();
            btnExpenses = new Button();
            btnRentPayments = new Button();
            btnLeases = new Button();
            btnTenants = new Button();
            btnRentalUnits = new Button();
            btnProperties = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlContent = new Panel();
            pnlSearch = new Panel();
            btnPrint = new Button();
            button1 = new Button();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            btnAddProperty = new Button();
            lblPropertyCount = new Label();
            lblProperties = new Label();
            dgvProperties = new DataGridView();
            PropertyID = new DataGridViewTextBoxColumn();
            PropertyName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            TotalUnits = new DataGridViewTextBoxColumn();
            Occupied = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            pnlDashBoard = new Panel();
            lblDashboardHeader = new Label();
            pnlRentPayments = new Panel();
            dataGridView2 = new DataGridView();
            TENANT2 = new DataGridViewTextBoxColumn();
            PROPERTY2 = new DataGridViewTextBoxColumn();
            UNITS = new DataGridViewTextBoxColumn();
            RENTDUE = new DataGridViewTextBoxColumn();
            AMOUNTPAID = new DataGridViewTextBoxColumn();
            OUTSTANDINGS = new DataGridViewTextBoxColumn();
            PAYMENTDATE = new DataGridViewTextBoxColumn();
            RECEIPTN0 = new DataGridViewTextBoxColumn();
            STATUSES = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            btnGenerateReceipts = new Button();
            cbxStatus = new ComboBox();
            textBox1 = new TextBox();
            btnRecordPayment = new Button();
            panel4 = new Panel();
            lblExpectedRentDisplay = new Label();
            lblExpectedRent = new Label();
            panel2 = new Panel();
            lblOutstandingRentDisplay = new Label();
            lblOutstandingRent = new Label();
            panel3 = new Panel();
            lblLatePaymentDisplay = new Label();
            lblLatePayment = new Label();
            panel1 = new Panel();
            lblCollectedRentDisplay = new Label();
            lblCollectedRent = new Label();
            lblRentTopic = new Label();
            pnlTenants = new Panel();
            btnAddTenants = new Button();
            dgvAddTenants = new DataGridView();
            Tenants = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Properties = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Lease_Status = new DataGridViewTextBoxColumn();
            Outstanding = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            lblRegisteredTenants = new Label();
            lblTenants = new Label();
            pnlFilterBar = new Panel();
            cmbStatuses = new ComboBox();
            cmbProperties = new ComboBox();
            txtSearchTenants = new TextBox();
            pnlRentalUnit = new Panel();
            pnlAvailability = new Panel();
            lblAvailableNum = new Label();
            lblAvailable = new Label();
            pnlOccupancy = new Panel();
            lblOccupiedNum = new Label();
            lblOccupied = new Label();
            pnlTotalUnits = new Panel();
            lblTotalUnitsNum = new Label();
            lblTotalUnits = new Label();
            btnAddUnit = new Button();
            lblRentalUnit = new Label();
            pnlExpenses = new Panel();
            btnAddExpense = new Button();
            dgvExpensesRecords = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Property = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            pnlSearchExpense = new Panel();
            txtSearchAnExpense = new TextBox();
            pnlUtilitiesRecords = new Panel();
            lblTotalUtilities = new Label();
            lblUtilitiesNumber = new Label();
            lblUtilities = new Label();
            pnlSecurityRecords = new Panel();
            lblTotalSecurity = new Label();
            lblSecutityNumber = new Label();
            lblSecurity = new Label();
            pnlInsuranceRecords = new Panel();
            lblTotalInsurance = new Label();
            lblInsurance = new Label();
            lblInsuranceNumber = new Label();
            pnlMaintenanceRecord = new Panel();
            lblTotalMaintenance = new Label();
            lblMaintenanceNumber = new Label();
            lblMaintenance = new Label();
            lblExpensesTopic = new Label();
            pnlMaintenance = new Panel();
            dgvMaintenanceRecords = new DataGridView();
            TENANTS2 = new DataGridViewTextBoxColumn();
            PROPERTYORUNIT = new DataGridViewTextBoxColumn();
            DESCRIPTIONS = new DataGridViewTextBoxColumn();
            PRIORITY = new DataGridViewTextBoxColumn();
            STATUS1 = new DataGridViewTextBoxColumn();
            DATES = new DataGridViewTextBoxColumn();
            lblTrackAndResolveMaintenanceRequests = new Label();
            btnNewRequests = new Button();
            pnlSearchBar = new Panel();
            btnResolved = new Button();
            btnPending = new Button();
            btnOpenRequests = new Button();
            btnAll = new Button();
            txtSearchBox = new TextBox();
            panel8 = new Panel();
            lblResolved = new Label();
            label6 = new Label();
            panel7 = new Panel();
            lblPending = new Label();
            label4 = new Label();
            panel6 = new Panel();
            lblOpenRequests = new Label();
            label2 = new Label();
            lblMaintenanceTopic = new Label();
            lblLeasesTopic = new Label();
            pnlActiveLeases = new Panel();
            lblTotalActiveLeases = new Label();
            lblActiveLeaseNum = new Label();
            lblActiveLeases = new Label();
            pnlExpiredLeases = new Panel();
            lblTotalExpiredLeases = new Label();
            lblExpiredLeases = new Label();
            lblExpiredLeasesNum = new Label();
            pnlTerminatedLeases = new Panel();
            lblTotalTeminatedLeases = new Label();
            lblTerminatedLeases = new Label();
            lblTerminatedLeasesNum = new Label();
            pnlSearchLeases = new Panel();
            button2 = new Button();
            txtSearchLeases = new TextBox();
            dgvLeases = new DataGridView();
            NameTenants = new DataGridViewTextBoxColumn();
            NameProperty = new DataGridViewTextBoxColumn();
            NAMEUNITS = new DataGridViewTextBoxColumn();
            NameStartDate = new DataGridViewTextBoxColumn();
            NameEndDate = new DataGridViewTextBoxColumn();
            NameMontlyRent = new DataGridViewTextBoxColumn();
            NameStatus = new DataGridViewTextBoxColumn();
            LEASEID = new DataGridViewTextBoxColumn();
            TENANT = new DataGridViewTextBoxColumn();
            NUNIT = new DataGridViewTextBoxColumn();
            STARTDATE = new DataGridViewTextBoxColumn();
            ENDDATE = new DataGridViewTextBoxColumn();
            MONTHLYRENT = new DataGridViewTextBoxColumn();
            LEASESTATUS = new DataGridViewTextBoxColumn();
            LEASEACTIONS = new DataGridViewTextBoxColumn();
            btnCreateLease = new Button();
            pnlLeases = new Panel();
            lblLeasesAgreements = new Label();
            lblTotalLeases = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlMainForm.SuspendLayout();
            pnlUserLoginInfo.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlDashBoard.SuspendLayout();
            pnlRentPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnlTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddTenants).BeginInit();
            pnlFilterBar.SuspendLayout();
            pnlRentalUnit.SuspendLayout();
            pnlAvailability.SuspendLayout();
            pnlOccupancy.SuspendLayout();
            pnlTotalUnits.SuspendLayout();
            pnlExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesRecords).BeginInit();
            pnlSearchExpense.SuspendLayout();
            pnlUtilitiesRecords.SuspendLayout();
            pnlSecurityRecords.SuspendLayout();
            pnlInsuranceRecords.SuspendLayout();
            pnlMaintenanceRecord.SuspendLayout();
            pnlMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceRecords).BeginInit();
            pnlSearchBar.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            pnlActiveLeases.SuspendLayout();
            pnlExpiredLeases.SuspendLayout();
            pnlTerminatedLeases.SuspendLayout();
            pnlSearchLeases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeases).BeginInit();
            pnlLeases.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainForm
            // 
            pnlMainForm.BackColor = Color.FromArgb(10, 22, 40);
            pnlMainForm.Controls.Add(pnlUserLoginInfo);
            pnlMainForm.Controls.Add(btnMaintenance);
            pnlMainForm.Controls.Add(btnExpenses);
            pnlMainForm.Controls.Add(btnRentPayments);
            pnlMainForm.Controls.Add(btnLeases);
            pnlMainForm.Controls.Add(btnTenants);
            pnlMainForm.Controls.Add(btnRentalUnits);
            pnlMainForm.Controls.Add(btnProperties);
            pnlMainForm.Controls.Add(btnDashboard);
            pnlMainForm.Controls.Add(lblLogo);
            pnlMainForm.Dock = DockStyle.Left;
            pnlMainForm.Location = new Point(0, 0);
            pnlMainForm.Margin = new Padding(4);
            pnlMainForm.MaximumSize = new Size(300, 0);
            pnlMainForm.Name = "pnlMainForm";
            pnlMainForm.Size = new Size(274, 960);
            pnlMainForm.TabIndex = 0;
            pnlMainForm.Paint += pnlMainForm_Paint;
            // 
            // pnlUserLoginInfo
            // 
            pnlUserLoginInfo.Controls.Add(lblUserName);
            pnlUserLoginInfo.Controls.Add(btnLogOut);
            pnlUserLoginInfo.Controls.Add(lblRole);
            pnlUserLoginInfo.Dock = DockStyle.Bottom;
            pnlUserLoginInfo.Location = new Point(0, 860);
            pnlUserLoginInfo.Margin = new Padding(4);
            pnlUserLoginInfo.MaximumSize = new Size(0, 100);
            pnlUserLoginInfo.Name = "pnlUserLoginInfo";
            pnlUserLoginInfo.Size = new Size(274, 100);
            pnlUserLoginInfo.TabIndex = 10;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = SystemColors.ButtonFace;
            lblUserName.Location = new Point(124, 10);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(59, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "label1";
            lblUserName.Click += lblUserName_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(49, 49);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(118, 36);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.AliceBlue;
            lblRole.Location = new Point(28, 9);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 25);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(12, 596);
            btnMaintenance.Margin = new Padding(4);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(262, 50);
            btnMaintenance.TabIndex = 9;
            btnMaintenance.Text = "🔧 Maintenance";
            btnMaintenance.TextAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ForeColor = Color.White;
            btnExpenses.Location = new Point(12, 530);
            btnExpenses.Margin = new Padding(4);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(262, 50);
            btnExpenses.TabIndex = 8;
            btnExpenses.Text = "📊 Expenses";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.UseVisualStyleBackColor = true;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // btnRentPayments
            // 
            btnRentPayments.FlatStyle = FlatStyle.Flat;
            btnRentPayments.ForeColor = Color.White;
            btnRentPayments.Location = new Point(12, 464);
            btnRentPayments.Margin = new Padding(4);
            btnRentPayments.Name = "btnRentPayments";
            btnRentPayments.Size = new Size(262, 50);
            btnRentPayments.TabIndex = 7;
            btnRentPayments.Text = "💰 Rent Payments";
            btnRentPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnRentPayments.UseVisualStyleBackColor = true;
            btnRentPayments.Click += btnRentPayments_Click;
            // 
            // btnLeases
            // 
            btnLeases.FlatStyle = FlatStyle.Flat;
            btnLeases.ForeColor = Color.White;
            btnLeases.Location = new Point(12, 395);
            btnLeases.Margin = new Padding(4);
            btnLeases.Name = "btnLeases";
            btnLeases.Size = new Size(262, 50);
            btnLeases.TabIndex = 6;
            btnLeases.Text = "📄 Leases";
            btnLeases.TextAlign = ContentAlignment.MiddleLeft;
            btnLeases.UseVisualStyleBackColor = true;
            btnLeases.Click += btnLeases_Click;
            // 
            // btnTenants
            // 
            btnTenants.FlatStyle = FlatStyle.Flat;
            btnTenants.ForeColor = Color.White;
            btnTenants.Location = new Point(12, 326);
            btnTenants.Margin = new Padding(4);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(262, 50);
            btnTenants.TabIndex = 5;
            btnTenants.Text = " \t👤 Tenants";
            btnTenants.TextAlign = ContentAlignment.MiddleLeft;
            btnTenants.UseVisualStyleBackColor = true;
            btnTenants.Click += btnTenants_Click;
            // 
            // btnRentalUnits
            // 
            btnRentalUnits.FlatStyle = FlatStyle.Flat;
            btnRentalUnits.ForeColor = Color.White;
            btnRentalUnits.Location = new Point(12, 260);
            btnRentalUnits.Margin = new Padding(4);
            btnRentalUnits.Name = "btnRentalUnits";
            btnRentalUnits.Size = new Size(262, 50);
            btnRentalUnits.TabIndex = 4;
            btnRentalUnits.Text = "📋 Rental Units";
            btnRentalUnits.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalUnits.UseVisualStyleBackColor = true;
            btnRentalUnits.Click += btnRentalUnits_Click;
            // 
            // btnProperties
            // 
            btnProperties.BackColor = Color.FromArgb(10, 22, 40);
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.ForeColor = Color.White;
            btnProperties.Location = new Point(12, 194);
            btnProperties.Margin = new Padding(4);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(262, 50);
            btnProperties.TabIndex = 3;
            btnProperties.Text = "🏢 Properties";
            btnProperties.TextAlign = ContentAlignment.MiddleLeft;
            btnProperties.UseVisualStyleBackColor = false;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 125);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(262, 50);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(28, 34);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(220, 48);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "🏨RentFlow";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.BorderStyle = BorderStyle.Fixed3D;
            pnlContent.Controls.Add(pnlSearch);
            pnlContent.Controls.Add(btnAddProperty);
            pnlContent.Controls.Add(lblPropertyCount);
            pnlContent.Controls.Add(lblProperties);
            pnlContent.Controls.Add(dgvProperties);
            pnlContent.Dock = DockStyle.Right;
            pnlContent.Location = new Point(1723, 0);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1438, 960);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlMain_Paint;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.Gainsboro;
            pnlSearch.BorderStyle = BorderStyle.Fixed3D;
            pnlSearch.Controls.Add(btnPrint);
            pnlSearch.Controls.Add(button1);
            pnlSearch.Controls.Add(cmbFilter);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(38, 244);
            pnlSearch.Margin = new Padding(4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1318, 60);
            pnlSearch.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1192, 14);
            btnPrint.Margin = new Padding(4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(118, 36);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1071, 14);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 2;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "", "Active", "", "Inactive" });
            cmbFilter.Location = new Point(470, 14);
            cmbFilter.Margin = new Padding(4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(136, 33);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Location = new Point(29, 15);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(418, 31);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search properties";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = Color.DarkBlue;
            btnAddProperty.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProperty.ForeColor = Color.White;
            btnAddProperty.Location = new Point(1150, 150);
            btnAddProperty.Margin = new Padding(4);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(206, 56);
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
            lblPropertyCount.Location = new Point(22, 96);
            lblPropertyCount.Margin = new Padding(4, 0, 4, 0);
            lblPropertyCount.Name = "lblPropertyCount";
            lblPropertyCount.Size = new Size(232, 32);
            lblPropertyCount.TabIndex = 1;
            lblPropertyCount.Text = "4 Properties in total";
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperties.Location = new Point(22, 45);
            lblProperties.Margin = new Padding(4, 0, 4, 0);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(193, 48);
            lblProperties.TabIndex = 0;
            lblProperties.Text = "Properties";
            // 
            // dgvProperties
            // 
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.BackgroundColor = Color.White;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyID, PropertyName, Address, TotalUnits, Occupied, Available, Status, Actions });
            dgvProperties.Location = new Point(38, 386);
            dgvProperties.Margin = new Padding(4);
            dgvProperties.MultiSelect = false;
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RowHeadersWidth = 51;
            dgvProperties.Size = new Size(1319, 514);
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
            // pnlDashBoard
            // 
            pnlDashBoard.BackColor = Color.WhiteSmoke;
            pnlDashBoard.BorderStyle = BorderStyle.Fixed3D;
            pnlDashBoard.Controls.Add(lblDashboardHeader);
            pnlDashBoard.Location = new Point(282, 0);
            pnlDashBoard.Margin = new Padding(4);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(1440, 960);
            pnlDashBoard.TabIndex = 2;
            // 
            // lblDashboardHeader
            // 
            lblDashboardHeader.AutoSize = true;
            lblDashboardHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardHeader.Location = new Point(44, 55);
            lblDashboardHeader.Margin = new Padding(4, 0, 4, 0);
            lblDashboardHeader.Name = "lblDashboardHeader";
            lblDashboardHeader.Size = new Size(229, 54);
            lblDashboardHeader.TabIndex = 0;
            lblDashboardHeader.Text = "Dashboard";
            // 
            // pnlRentPayments
            // 
            pnlRentPayments.Controls.Add(dataGridView2);
            pnlRentPayments.Controls.Add(panel5);
            pnlRentPayments.Controls.Add(btnRecordPayment);
            pnlRentPayments.Controls.Add(panel4);
            pnlRentPayments.Controls.Add(panel2);
            pnlRentPayments.Controls.Add(panel3);
            pnlRentPayments.Controls.Add(panel1);
            pnlRentPayments.Controls.Add(lblRentTopic);
            pnlRentPayments.Location = new Point(274, 0);
            pnlRentPayments.Margin = new Padding(4);
            pnlRentPayments.Name = "pnlRentPayments";
            pnlRentPayments.Size = new Size(1449, 866);
            pnlRentPayments.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { TENANT2, PROPERTY2, UNITS, RENTDUE, AMOUNTPAID, OUTSTANDINGS, PAYMENTDATE, RECEIPTN0, STATUSES });
            dataGridView2.Location = new Point(14, 530);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1290, 250);
            dataGridView2.TabIndex = 6;
            // 
            // TENANT2
            // 
            TENANT2.HeaderText = "TENANT";
            TENANT2.MinimumWidth = 6;
            TENANT2.Name = "TENANT2";
            TENANT2.Width = 125;
            // 
            // PROPERTY2
            // 
            PROPERTY2.HeaderText = "PROPERTY";
            PROPERTY2.MinimumWidth = 6;
            PROPERTY2.Name = "PROPERTY2";
            PROPERTY2.Width = 125;
            // 
            // UNITS
            // 
            UNITS.HeaderText = "UNIT";
            UNITS.MinimumWidth = 6;
            UNITS.Name = "UNITS";
            UNITS.Width = 125;
            // 
            // RENTDUE
            // 
            RENTDUE.HeaderText = "RENT DUE";
            RENTDUE.MinimumWidth = 6;
            RENTDUE.Name = "RENTDUE";
            RENTDUE.Width = 125;
            // 
            // AMOUNTPAID
            // 
            AMOUNTPAID.HeaderText = "AMOUNT PAID";
            AMOUNTPAID.MinimumWidth = 6;
            AMOUNTPAID.Name = "AMOUNTPAID";
            AMOUNTPAID.Width = 125;
            // 
            // OUTSTANDINGS
            // 
            OUTSTANDINGS.HeaderText = "OUTSTANDING";
            OUTSTANDINGS.MinimumWidth = 6;
            OUTSTANDINGS.Name = "OUTSTANDINGS";
            OUTSTANDINGS.Width = 125;
            // 
            // PAYMENTDATE
            // 
            PAYMENTDATE.HeaderText = "PAYMENT DUE";
            PAYMENTDATE.MinimumWidth = 6;
            PAYMENTDATE.Name = "PAYMENTDATE";
            PAYMENTDATE.Width = 125;
            // 
            // RECEIPTN0
            // 
            RECEIPTN0.HeaderText = "RECEIPT N0";
            RECEIPTN0.MinimumWidth = 6;
            RECEIPTN0.Name = "RECEIPTN0";
            RECEIPTN0.Width = 125;
            // 
            // STATUSES
            // 
            STATUSES.HeaderText = "STATUS";
            STATUSES.MinimumWidth = 6;
            STATUSES.Name = "STATUSES";
            STATUSES.Width = 125;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnGenerateReceipts);
            panel5.Controls.Add(cbxStatus);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(11, 345);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1410, 100);
            panel5.TabIndex = 5;
            // 
            // btnGenerateReceipts
            // 
            btnGenerateReceipts.BackColor = SystemColors.ActiveBorder;
            btnGenerateReceipts.Location = new Point(619, 5);
            btnGenerateReceipts.Margin = new Padding(4, 5, 4, 5);
            btnGenerateReceipts.Name = "btnGenerateReceipts";
            btnGenerateReceipts.Size = new Size(169, 90);
            btnGenerateReceipts.TabIndex = 2;
            btnGenerateReceipts.Text = "Generate Receipts";
            btnGenerateReceipts.UseVisualStyleBackColor = false;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Paid", "Outstanding", "Late" });
            cbxStatus.Location = new Point(402, 29);
            cbxStatus.Margin = new Padding(4, 5, 4, 5);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(172, 33);
            cbxStatus.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 29);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 0;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.Location = new Point(1224, 46);
            btnRecordPayment.Margin = new Padding(4, 5, 4, 5);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(198, 50);
            btnRecordPayment.TabIndex = 4;
            btnRecordPayment.Text = "Record Payment";
            btnRecordPayment.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblExpectedRentDisplay);
            panel4.Controls.Add(lblExpectedRent);
            panel4.Location = new Point(9, 135);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 166);
            panel4.TabIndex = 3;
            // 
            // lblExpectedRentDisplay
            // 
            lblExpectedRentDisplay.AutoSize = true;
            lblExpectedRentDisplay.Location = new Point(14, 80);
            lblExpectedRentDisplay.Margin = new Padding(4, 0, 4, 0);
            lblExpectedRentDisplay.Name = "lblExpectedRentDisplay";
            lblExpectedRentDisplay.Size = new Size(0, 25);
            lblExpectedRentDisplay.TabIndex = 1;
            // 
            // lblExpectedRent
            // 
            lblExpectedRent.AutoSize = true;
            lblExpectedRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedRent.Location = new Point(9, 14);
            lblExpectedRent.Margin = new Padding(4, 0, 4, 0);
            lblExpectedRent.Name = "lblExpectedRent";
            lblExpectedRent.Size = new Size(212, 40);
            lblExpectedRent.TabIndex = 0;
            lblExpectedRent.Text = "Expected Rent";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblOutstandingRentDisplay);
            panel2.Controls.Add(lblOutstandingRent);
            panel2.Location = new Point(762, 135);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 166);
            panel2.TabIndex = 2;
            // 
            // lblOutstandingRentDisplay
            // 
            lblOutstandingRentDisplay.AutoSize = true;
            lblOutstandingRentDisplay.Location = new Point(4, 80);
            lblOutstandingRentDisplay.Margin = new Padding(4, 0, 4, 0);
            lblOutstandingRentDisplay.Name = "lblOutstandingRentDisplay";
            lblOutstandingRentDisplay.Size = new Size(0, 25);
            lblOutstandingRentDisplay.TabIndex = 3;
            // 
            // lblOutstandingRent
            // 
            lblOutstandingRent.AutoSize = true;
            lblOutstandingRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstandingRent.Location = new Point(4, 14);
            lblOutstandingRent.Margin = new Padding(4, 0, 4, 0);
            lblOutstandingRent.Name = "lblOutstandingRent";
            lblOutstandingRent.Size = new Size(259, 40);
            lblOutstandingRent.TabIndex = 2;
            lblOutstandingRent.Text = "Outstanding Rent";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLatePaymentDisplay);
            panel3.Controls.Add(lblLatePayment);
            panel3.Location = new Point(1136, 135);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 166);
            panel3.TabIndex = 2;
            // 
            // lblLatePaymentDisplay
            // 
            lblLatePaymentDisplay.AutoSize = true;
            lblLatePaymentDisplay.Location = new Point(14, 80);
            lblLatePaymentDisplay.Margin = new Padding(4, 0, 4, 0);
            lblLatePaymentDisplay.Name = "lblLatePaymentDisplay";
            lblLatePaymentDisplay.Size = new Size(0, 25);
            lblLatePaymentDisplay.TabIndex = 2;
            // 
            // lblLatePayment
            // 
            lblLatePayment.AutoSize = true;
            lblLatePayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLatePayment.Location = new Point(4, 14);
            lblLatePayment.Margin = new Padding(4, 0, 4, 0);
            lblLatePayment.Name = "lblLatePayment";
            lblLatePayment.Size = new Size(204, 40);
            lblLatePayment.TabIndex = 1;
            lblLatePayment.Text = "Late Payment";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCollectedRentDisplay);
            panel1.Controls.Add(lblCollectedRent);
            panel1.Location = new Point(381, 135);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 166);
            panel1.TabIndex = 1;
            // 
            // lblCollectedRentDisplay
            // 
            lblCollectedRentDisplay.AutoSize = true;
            lblCollectedRentDisplay.Location = new Point(6, 80);
            lblCollectedRentDisplay.Margin = new Padding(4, 0, 4, 0);
            lblCollectedRentDisplay.Name = "lblCollectedRentDisplay";
            lblCollectedRentDisplay.Size = new Size(0, 25);
            lblCollectedRentDisplay.TabIndex = 4;
            // 
            // lblCollectedRent
            // 
            lblCollectedRent.AutoSize = true;
            lblCollectedRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectedRent.Location = new Point(6, 14);
            lblCollectedRent.Margin = new Padding(4, 0, 4, 0);
            lblCollectedRent.Name = "lblCollectedRent";
            lblCollectedRent.Size = new Size(215, 40);
            lblCollectedRent.TabIndex = 3;
            lblCollectedRent.Text = "Collected Rent";
            // 
            // lblRentTopic
            // 
            lblRentTopic.AutoSize = true;
            lblRentTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentTopic.Location = new Point(26, 66);
            lblRentTopic.Margin = new Padding(4, 0, 4, 0);
            lblRentTopic.Name = "lblRentTopic";
            lblRentTopic.Size = new Size(306, 54);
            lblRentTopic.TabIndex = 0;
            lblRentTopic.Text = "Rent Payments";
            // 
            // pnlTenants
            // 
            pnlTenants.Controls.Add(btnAddTenants);
            pnlTenants.Controls.Add(dgvAddTenants);
            pnlTenants.Controls.Add(lblRegisteredTenants);
            pnlTenants.Controls.Add(lblTenants);
            pnlTenants.Controls.Add(pnlFilterBar);
            pnlTenants.Location = new Point(274, 0);
            pnlTenants.Margin = new Padding(4);
            pnlTenants.Name = "pnlTenants";
            pnlTenants.Size = new Size(1449, 915);
            pnlTenants.TabIndex = 17;
            // 
            // btnAddTenants
            // 
            btnAddTenants.BackColor = Color.DarkBlue;
            btnAddTenants.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTenants.ForeColor = Color.White;
            btnAddTenants.Location = new Point(1106, 75);
            btnAddTenants.Margin = new Padding(4);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(221, 59);
            btnAddTenants.TabIndex = 4;
            btnAddTenants.Text = "+Add Tenants";
            btnAddTenants.UseVisualStyleBackColor = false;
            btnAddTenants.Click += btnAddTenants_Click_1;
            // 
            // dgvAddTenants
            // 
            dgvAddTenants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddTenants.Columns.AddRange(new DataGridViewColumn[] { Tenants, Contact, Properties, Unit, Lease_Status, Outstanding, Action });
            dgvAddTenants.Location = new Point(44, 374);
            dgvAddTenants.Margin = new Padding(4);
            dgvAddTenants.Name = "dgvAddTenants";
            dgvAddTenants.RowHeadersWidth = 51;
            dgvAddTenants.Size = new Size(1160, 541);
            dgvAddTenants.TabIndex = 3;
            // 
            // Tenants
            // 
            Tenants.HeaderText = "Tenants";
            Tenants.MinimumWidth = 6;
            Tenants.Name = "Tenants";
            Tenants.Width = 125;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.MinimumWidth = 6;
            Contact.Name = "Contact";
            Contact.Width = 125;
            // 
            // Properties
            // 
            Properties.HeaderText = "Properties";
            Properties.MinimumWidth = 6;
            Properties.Name = "Properties";
            Properties.Width = 125;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.Width = 125;
            // 
            // Lease_Status
            // 
            Lease_Status.HeaderText = "Lease_Status";
            Lease_Status.MinimumWidth = 6;
            Lease_Status.Name = "Lease_Status";
            Lease_Status.Width = 125;
            // 
            // Outstanding
            // 
            Outstanding.HeaderText = "Outstanding";
            Outstanding.MinimumWidth = 6;
            Outstanding.Name = "Outstanding";
            Outstanding.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // lblRegisteredTenants
            // 
            lblRegisteredTenants.AutoSize = true;
            lblRegisteredTenants.Location = new Point(26, 80);
            lblRegisteredTenants.Margin = new Padding(4, 0, 4, 0);
            lblRegisteredTenants.Name = "lblRegisteredTenants";
            lblRegisteredTenants.Size = new Size(0, 25);
            lblRegisteredTenants.TabIndex = 1;
            // 
            // lblTenants
            // 
            lblTenants.AutoSize = true;
            lblTenants.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenants.Location = new Point(26, 25);
            lblTenants.Margin = new Padding(4, 0, 4, 0);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(150, 48);
            lblTenants.TabIndex = 0;
            lblTenants.Text = "Tenants";
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.BackColor = Color.Gainsboro;
            pnlFilterBar.BorderStyle = BorderStyle.Fixed3D;
            pnlFilterBar.Controls.Add(cmbStatuses);
            pnlFilterBar.Controls.Add(cmbProperties);
            pnlFilterBar.Controls.Add(txtSearchTenants);
            pnlFilterBar.Location = new Point(40, 196);
            pnlFilterBar.Margin = new Padding(4);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1285, 79);
            pnlFilterBar.TabIndex = 2;
            // 
            // cmbStatuses
            // 
            cmbStatuses.FlatStyle = FlatStyle.System;
            cmbStatuses.FormattingEnabled = true;
            cmbStatuses.Items.AddRange(new object[] { "All Statuses", "Active", "Expiring Soon" });
            cmbStatuses.Location = new Point(831, 21);
            cmbStatuses.Margin = new Padding(4);
            cmbStatuses.Name = "cmbStatuses";
            cmbStatuses.Size = new Size(188, 33);
            cmbStatuses.TabIndex = 2;
            // 
            // cmbProperties
            // 
            cmbProperties.FlatStyle = FlatStyle.System;
            cmbProperties.FormattingEnabled = true;
            cmbProperties.Location = new Point(599, 21);
            cmbProperties.Margin = new Padding(4);
            cmbProperties.Name = "cmbProperties";
            cmbProperties.Size = new Size(188, 33);
            cmbProperties.TabIndex = 1;
            // 
            // txtSearchTenants
            // 
            txtSearchTenants.Location = new Point(42, 24);
            txtSearchTenants.Margin = new Padding(4);
            txtSearchTenants.Name = "txtSearchTenants";
            txtSearchTenants.PlaceholderText = "Search Tenants...";
            txtSearchTenants.Size = new Size(378, 31);
            txtSearchTenants.TabIndex = 0;
            // 
            // pnlRentalUnit
            // 
            pnlRentalUnit.BackColor = Color.FromArgb(245, 246, 250);
            pnlRentalUnit.Controls.Add(pnlAvailability);
            pnlRentalUnit.Controls.Add(pnlOccupancy);
            pnlRentalUnit.Controls.Add(pnlTotalUnits);
            pnlRentalUnit.Controls.Add(btnAddUnit);
            pnlRentalUnit.Controls.Add(lblRentalUnit);
            pnlRentalUnit.Location = new Point(274, 0);
            pnlRentalUnit.Margin = new Padding(4);
            pnlRentalUnit.Name = "pnlRentalUnit";
            pnlRentalUnit.Size = new Size(1449, 866);
            pnlRentalUnit.TabIndex = 5;
            // 
            // pnlAvailability
            // 
            pnlAvailability.Controls.Add(lblAvailableNum);
            pnlAvailability.Controls.Add(lblAvailable);
            pnlAvailability.Location = new Point(410, 140);
            pnlAvailability.Margin = new Padding(4);
            pnlAvailability.Name = "pnlAvailability";
            pnlAvailability.Size = new Size(312, 156);
            pnlAvailability.TabIndex = 3;
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(18, 59);
            lblAvailableNum.Margin = new Padding(4, 0, 4, 0);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 25);
            lblAvailableNum.TabIndex = 2;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(4, 14);
            lblAvailable.Margin = new Padding(4, 0, 4, 0);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(83, 25);
            lblAvailable.TabIndex = 0;
            lblAvailable.Text = "Available";
            // 
            // pnlOccupancy
            // 
            pnlOccupancy.Controls.Add(lblOccupiedNum);
            pnlOccupancy.Controls.Add(lblOccupied);
            pnlOccupancy.Location = new Point(772, 144);
            pnlOccupancy.Margin = new Padding(4);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Size = new Size(312, 156);
            pnlOccupancy.TabIndex = 3;
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(31, 66);
            lblOccupiedNum.Margin = new Padding(4, 0, 4, 0);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 25);
            lblOccupiedNum.TabIndex = 3;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(4, 10);
            lblOccupied.Margin = new Padding(4, 0, 4, 0);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(87, 25);
            lblOccupied.TabIndex = 1;
            lblOccupied.Text = "Occupied";
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.Controls.Add(lblTotalUnitsNum);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Location = new Point(46, 140);
            pnlTotalUnits.Margin = new Padding(4);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(312, 156);
            pnlTotalUnits.TabIndex = 2;
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(36, 56);
            lblTotalUnitsNum.Margin = new Padding(4, 0, 4, 0);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 25);
            lblTotalUnitsNum.TabIndex = 1;
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Location = new Point(26, 14);
            lblTotalUnits.Margin = new Padding(4, 0, 4, 0);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(94, 25);
            lblTotalUnits.TabIndex = 0;
            lblTotalUnits.Text = "Total Units";
            // 
            // btnAddUnit
            // 
            btnAddUnit.BackColor = Color.RoyalBlue;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.ForeColor = Color.White;
            btnAddUnit.Location = new Point(736, 51);
            btnAddUnit.Margin = new Padding(4);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(194, 60);
            btnAddUnit.TabIndex = 1;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.ForeColor = SystemColors.ActiveCaptionText;
            lblRentalUnit.Location = new Point(44, 55);
            lblRentalUnit.Margin = new Padding(4, 0, 4, 0);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(234, 54);
            lblRentalUnit.TabIndex = 0;
            lblRentalUnit.Text = "Rental Unit";
            // 
            // pnlExpenses
            // 
            pnlExpenses.Controls.Add(btnAddExpense);
            pnlExpenses.Controls.Add(dgvExpensesRecords);
            pnlExpenses.Controls.Add(pnlSearchExpense);
            pnlExpenses.Controls.Add(pnlUtilitiesRecords);
            pnlExpenses.Controls.Add(pnlSecurityRecords);
            pnlExpenses.Controls.Add(pnlInsuranceRecords);
            pnlExpenses.Controls.Add(pnlMaintenanceRecord);
            pnlExpenses.Controls.Add(lblExpensesTopic);
            pnlExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlExpenses.Location = new Point(274, 0);
            pnlExpenses.Margin = new Padding(4);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(1449, 866);
            pnlExpenses.TabIndex = 1;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.FromArgb(10, 22, 40);
            btnAddExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddExpense.ForeColor = Color.White;
            btnAddExpense.Location = new Point(1224, 47);
            btnAddExpense.Margin = new Padding(4, 5, 4, 5);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(186, 70);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "+ Add Expense";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // dgvExpensesRecords
            // 
            dgvExpensesRecords.AllowUserToAddRows = false;
            dgvExpensesRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpensesRecords.BackgroundColor = Color.White;
            dgvExpensesRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensesRecords.Columns.AddRange(new DataGridViewColumn[] { Category, Property, Description, Amount, Date });
            dgvExpensesRecords.Location = new Point(30, 495);
            dgvExpensesRecords.Margin = new Padding(4, 5, 4, 5);
            dgvExpensesRecords.Name = "dgvExpensesRecords";
            dgvExpensesRecords.RowHeadersWidth = 51;
            dgvExpensesRecords.Size = new Size(1403, 366);
            dgvExpensesRecords.TabIndex = 5;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // Property
            // 
            Property.HeaderText = "Property";
            Property.MinimumWidth = 8;
            Property.Name = "Property";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // pnlSearchExpense
            // 
            pnlSearchExpense.BorderStyle = BorderStyle.FixedSingle;
            pnlSearchExpense.Controls.Add(txtSearchAnExpense);
            pnlSearchExpense.Location = new Point(30, 355);
            pnlSearchExpense.Margin = new Padding(4, 5, 4, 5);
            pnlSearchExpense.Name = "pnlSearchExpense";
            pnlSearchExpense.Size = new Size(1387, 119);
            pnlSearchExpense.TabIndex = 4;
            // 
            // txtSearchAnExpense
            // 
            txtSearchAnExpense.Location = new Point(46, 41);
            txtSearchAnExpense.Margin = new Padding(4, 5, 4, 5);
            txtSearchAnExpense.Name = "txtSearchAnExpense";
            txtSearchAnExpense.Size = new Size(742, 39);
            txtSearchAnExpense.TabIndex = 0;
            // 
            // pnlUtilitiesRecords
            // 
            pnlUtilitiesRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlUtilitiesRecords.Controls.Add(lblTotalUtilities);
            pnlUtilitiesRecords.Controls.Add(lblUtilitiesNumber);
            pnlUtilitiesRecords.Controls.Add(lblUtilities);
            pnlUtilitiesRecords.Location = new Point(1056, 160);
            pnlUtilitiesRecords.Margin = new Padding(4, 5, 4, 5);
            pnlUtilitiesRecords.Name = "pnlUtilitiesRecords";
            pnlUtilitiesRecords.Size = new Size(271, 150);
            pnlUtilitiesRecords.TabIndex = 3;
            // 
            // lblTotalUtilities
            // 
            lblTotalUtilities.AutoSize = true;
            lblTotalUtilities.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUtilities.Location = new Point(124, 75);
            lblTotalUtilities.Margin = new Padding(4, 0, 4, 0);
            lblTotalUtilities.Name = "lblTotalUtilities";
            lblTotalUtilities.Size = new Size(38, 45);
            lblTotalUtilities.TabIndex = 3;
            lblTotalUtilities.Text = "0";
            // 
            // lblUtilitiesNumber
            // 
            lblUtilitiesNumber.AutoSize = true;
            lblUtilitiesNumber.Location = new Point(142, 86);
            lblUtilitiesNumber.Margin = new Padding(4, 0, 4, 0);
            lblUtilitiesNumber.Name = "lblUtilitiesNumber";
            lblUtilitiesNumber.Size = new Size(0, 32);
            lblUtilitiesNumber.TabIndex = 6;
            // 
            // lblUtilities
            // 
            lblUtilities.AutoSize = true;
            lblUtilities.Location = new Point(20, 14);
            lblUtilities.Margin = new Padding(4, 0, 4, 0);
            lblUtilities.Name = "lblUtilities";
            lblUtilities.Size = new Size(101, 32);
            lblUtilities.TabIndex = 5;
            lblUtilities.Text = "Utilities";
            // 
            // pnlSecurityRecords
            // 
            pnlSecurityRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlSecurityRecords.Controls.Add(lblTotalSecurity);
            pnlSecurityRecords.Controls.Add(lblSecutityNumber);
            pnlSecurityRecords.Controls.Add(lblSecurity);
            pnlSecurityRecords.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlSecurityRecords.Location = new Point(703, 160);
            pnlSecurityRecords.Margin = new Padding(4, 5, 4, 5);
            pnlSecurityRecords.Name = "pnlSecurityRecords";
            pnlSecurityRecords.Size = new Size(301, 150);
            pnlSecurityRecords.TabIndex = 3;
            // 
            // lblTotalSecurity
            // 
            lblTotalSecurity.AutoSize = true;
            lblTotalSecurity.Location = new Point(114, 85);
            lblTotalSecurity.Margin = new Padding(4, 0, 4, 0);
            lblTotalSecurity.Name = "lblTotalSecurity";
            lblTotalSecurity.Size = new Size(38, 45);
            lblTotalSecurity.TabIndex = 4;
            lblTotalSecurity.Text = "0";
            // 
            // lblSecutityNumber
            // 
            lblSecutityNumber.AutoSize = true;
            lblSecutityNumber.Location = new Point(142, 86);
            lblSecutityNumber.Margin = new Padding(4, 0, 4, 0);
            lblSecutityNumber.Name = "lblSecutityNumber";
            lblSecutityNumber.Size = new Size(0, 45);
            lblSecutityNumber.TabIndex = 4;
            // 
            // lblSecurity
            // 
            lblSecurity.AutoSize = true;
            lblSecurity.Location = new Point(19, 14);
            lblSecurity.Margin = new Padding(4, 0, 4, 0);
            lblSecurity.Name = "lblSecurity";
            lblSecurity.Size = new Size(140, 45);
            lblSecurity.TabIndex = 3;
            lblSecurity.Text = "Security";
            // 
            // pnlInsuranceRecords
            // 
            pnlInsuranceRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlInsuranceRecords.Controls.Add(lblTotalInsurance);
            pnlInsuranceRecords.Controls.Add(lblInsurance);
            pnlInsuranceRecords.Controls.Add(lblInsuranceNumber);
            pnlInsuranceRecords.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlInsuranceRecords.Location = new Point(361, 160);
            pnlInsuranceRecords.Margin = new Padding(4, 5, 4, 5);
            pnlInsuranceRecords.Name = "pnlInsuranceRecords";
            pnlInsuranceRecords.Size = new Size(287, 150);
            pnlInsuranceRecords.TabIndex = 2;
            // 
            // lblTotalInsurance
            // 
            lblTotalInsurance.AutoSize = true;
            lblTotalInsurance.Location = new Point(101, 86);
            lblTotalInsurance.Margin = new Padding(4, 0, 4, 0);
            lblTotalInsurance.Name = "lblTotalInsurance";
            lblTotalInsurance.Size = new Size(38, 45);
            lblTotalInsurance.TabIndex = 5;
            lblTotalInsurance.Text = "0";
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Location = new Point(28, 26);
            lblInsurance.Margin = new Padding(4, 0, 4, 0);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(163, 45);
            lblInsurance.TabIndex = 2;
            lblInsurance.Text = "Insurance";
            // 
            // lblInsuranceNumber
            // 
            lblInsuranceNumber.AutoSize = true;
            lblInsuranceNumber.Location = new Point(142, 86);
            lblInsuranceNumber.Margin = new Padding(4, 0, 4, 0);
            lblInsuranceNumber.Name = "lblInsuranceNumber";
            lblInsuranceNumber.Size = new Size(0, 45);
            lblInsuranceNumber.TabIndex = 1;
            // 
            // pnlMaintenanceRecord
            // 
            pnlMaintenanceRecord.BorderStyle = BorderStyle.FixedSingle;
            pnlMaintenanceRecord.Controls.Add(lblTotalMaintenance);
            pnlMaintenanceRecord.Controls.Add(lblMaintenanceNumber);
            pnlMaintenanceRecord.Controls.Add(lblMaintenance);
            pnlMaintenanceRecord.Location = new Point(35, 160);
            pnlMaintenanceRecord.Margin = new Padding(4, 5, 4, 5);
            pnlMaintenanceRecord.Name = "pnlMaintenanceRecord";
            pnlMaintenanceRecord.Size = new Size(274, 146);
            pnlMaintenanceRecord.TabIndex = 1;
            // 
            // lblTotalMaintenance
            // 
            lblTotalMaintenance.AutoSize = true;
            lblTotalMaintenance.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMaintenance.Location = new Point(102, 84);
            lblTotalMaintenance.Margin = new Padding(4, 0, 4, 0);
            lblTotalMaintenance.Name = "lblTotalMaintenance";
            lblTotalMaintenance.Size = new Size(38, 45);
            lblTotalMaintenance.TabIndex = 2;
            lblTotalMaintenance.Text = "0";
            // 
            // lblMaintenanceNumber
            // 
            lblMaintenanceNumber.AutoSize = true;
            lblMaintenanceNumber.Location = new Point(142, 86);
            lblMaintenanceNumber.Margin = new Padding(4, 0, 4, 0);
            lblMaintenanceNumber.Name = "lblMaintenanceNumber";
            lblMaintenanceNumber.Size = new Size(0, 32);
            lblMaintenanceNumber.TabIndex = 1;
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.Location = new Point(30, 26);
            lblMaintenance.Margin = new Padding(4, 0, 4, 0);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(162, 32);
            lblMaintenance.TabIndex = 0;
            lblMaintenance.Text = "Maintenance";
            // 
            // lblExpensesTopic
            // 
            lblExpensesTopic.AutoSize = true;
            lblExpensesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpensesTopic.Location = new Point(24, 47);
            lblExpensesTopic.Margin = new Padding(4, 0, 4, 0);
            lblExpensesTopic.Name = "lblExpensesTopic";
            lblExpensesTopic.Size = new Size(195, 54);
            lblExpensesTopic.TabIndex = 0;
            lblExpensesTopic.Text = "Expenses";
            // 
            // pnlMaintenance
            // 
            pnlMaintenance.Controls.Add(dgvMaintenanceRecords);
            pnlMaintenance.Controls.Add(lblTrackAndResolveMaintenanceRequests);
            pnlMaintenance.Controls.Add(btnNewRequests);
            pnlMaintenance.Controls.Add(pnlSearchBar);
            pnlMaintenance.Controls.Add(panel8);
            pnlMaintenance.Controls.Add(panel7);
            pnlMaintenance.Controls.Add(panel6);
            pnlMaintenance.Controls.Add(lblMaintenanceTopic);
            pnlMaintenance.Location = new Point(274, 0);
            pnlMaintenance.Margin = new Padding(4);
            pnlMaintenance.Name = "pnlMaintenance";
            pnlMaintenance.Size = new Size(1449, 866);
            pnlMaintenance.TabIndex = 1;
            // 
            // dgvMaintenanceRecords
            // 
            dgvMaintenanceRecords.AllowUserToAddRows = false;
            dgvMaintenanceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenanceRecords.BackgroundColor = Color.White;
            dgvMaintenanceRecords.BorderStyle = BorderStyle.Fixed3D;
            dgvMaintenanceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceRecords.Columns.AddRange(new DataGridViewColumn[] { TENANTS2, PROPERTYORUNIT, DESCRIPTIONS, PRIORITY, STATUS1, DATES });
            dgvMaintenanceRecords.Location = new Point(50, 456);
            dgvMaintenanceRecords.Margin = new Padding(4);
            dgvMaintenanceRecords.Name = "dgvMaintenanceRecords";
            dgvMaintenanceRecords.RowHeadersWidth = 51;
            dgvMaintenanceRecords.Size = new Size(1348, 404);
            dgvMaintenanceRecords.TabIndex = 7;
            // 
            // TENANTS2
            // 
            TENANTS2.HeaderText = "TENANT";
            TENANTS2.MinimumWidth = 6;
            TENANTS2.Name = "TENANTS2";
            // 
            // PROPERTYORUNIT
            // 
            PROPERTYORUNIT.HeaderText = "PROPERTY/UNIT";
            PROPERTYORUNIT.MinimumWidth = 6;
            PROPERTYORUNIT.Name = "PROPERTYORUNIT";
            // 
            // DESCRIPTIONS
            // 
            DESCRIPTIONS.HeaderText = "DESCRIPTION";
            DESCRIPTIONS.MinimumWidth = 6;
            DESCRIPTIONS.Name = "DESCRIPTIONS";
            // 
            // PRIORITY
            // 
            PRIORITY.HeaderText = "PRIORITY";
            PRIORITY.MinimumWidth = 6;
            PRIORITY.Name = "PRIORITY";
            // 
            // STATUS1
            // 
            STATUS1.HeaderText = "STATUS";
            STATUS1.MinimumWidth = 6;
            STATUS1.Name = "STATUS1";
            // 
            // DATES
            // 
            DATES.HeaderText = "DATE";
            DATES.MinimumWidth = 6;
            DATES.Name = "DATES";
            // 
            // lblTrackAndResolveMaintenanceRequests
            // 
            lblTrackAndResolveMaintenanceRequests.AutoSize = true;
            lblTrackAndResolveMaintenanceRequests.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrackAndResolveMaintenanceRequests.ForeColor = Color.DimGray;
            lblTrackAndResolveMaintenanceRequests.Location = new Point(46, 108);
            lblTrackAndResolveMaintenanceRequests.Margin = new Padding(4, 0, 4, 0);
            lblTrackAndResolveMaintenanceRequests.Name = "lblTrackAndResolveMaintenanceRequests";
            lblTrackAndResolveMaintenanceRequests.Size = new Size(423, 30);
            lblTrackAndResolveMaintenanceRequests.TabIndex = 6;
            lblTrackAndResolveMaintenanceRequests.Text = "Track And Resolve Maintenance Requests";
            // 
            // btnNewRequests
            // 
            btnNewRequests.BackColor = Color.Blue;
            btnNewRequests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewRequests.ForeColor = SystemColors.ButtonHighlight;
            btnNewRequests.Location = new Point(1120, 72);
            btnNewRequests.Margin = new Padding(4);
            btnNewRequests.Name = "btnNewRequests";
            btnNewRequests.Size = new Size(222, 54);
            btnNewRequests.TabIndex = 5;
            btnNewRequests.Text = "+ New Request";
            btnNewRequests.UseVisualStyleBackColor = false;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = SystemColors.ControlDark;
            pnlSearchBar.BorderStyle = BorderStyle.Fixed3D;
            pnlSearchBar.Controls.Add(btnResolved);
            pnlSearchBar.Controls.Add(btnPending);
            pnlSearchBar.Controls.Add(btnOpenRequests);
            pnlSearchBar.Controls.Add(btnAll);
            pnlSearchBar.Controls.Add(txtSearchBox);
            pnlSearchBar.Location = new Point(38, 355);
            pnlSearchBar.Margin = new Padding(4);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1310, 64);
            pnlSearchBar.TabIndex = 4;
            // 
            // btnResolved
            // 
            btnResolved.Location = new Point(1126, 15);
            btnResolved.Margin = new Padding(4);
            btnResolved.Name = "btnResolved";
            btnResolved.Size = new Size(118, 36);
            btnResolved.TabIndex = 4;
            btnResolved.Text = "Resolved";
            btnResolved.UseVisualStyleBackColor = true;
            // 
            // btnPending
            // 
            btnPending.Location = new Point(995, 16);
            btnPending.Margin = new Padding(4);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(118, 36);
            btnPending.TabIndex = 3;
            btnPending.Text = "Pending";
            btnPending.UseVisualStyleBackColor = true;
            // 
            // btnOpenRequests
            // 
            btnOpenRequests.Location = new Point(862, 16);
            btnOpenRequests.Margin = new Padding(4);
            btnOpenRequests.Name = "btnOpenRequests";
            btnOpenRequests.Size = new Size(118, 36);
            btnOpenRequests.TabIndex = 2;
            btnOpenRequests.Text = "Open";
            btnOpenRequests.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Blue;
            btnAll.ForeColor = SystemColors.ButtonHighlight;
            btnAll.Location = new Point(726, 18);
            btnAll.Margin = new Padding(4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(118, 36);
            btnAll.TabIndex = 1;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(19, 16);
            txtSearchBox.Margin = new Padding(4);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search Requests...";
            txtSearchBox.Size = new Size(662, 31);
            txtSearchBox.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(lblResolved);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(736, 172);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(325, 155);
            panel8.TabIndex = 3;
            // 
            // lblResolved
            // 
            lblResolved.AutoSize = true;
            lblResolved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResolved.Location = new Point(166, 114);
            lblResolved.Margin = new Padding(4, 0, 4, 0);
            lblResolved.Name = "lblResolved";
            lblResolved.Size = new Size(116, 32);
            lblResolved.TabIndex = 2;
            lblResolved.Text = "Resolved";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 62);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(lblPending);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(395, 172);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(325, 155);
            panel7.TabIndex = 2;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(190, 116);
            lblPending.Margin = new Padding(4, 0, 4, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(108, 32);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 65);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(lblOpenRequests);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(44, 170);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 155);
            panel6.TabIndex = 1;
            // 
            // lblOpenRequests
            // 
            lblOpenRequests.AutoSize = true;
            lblOpenRequests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpenRequests.Location = new Point(131, 119);
            lblOpenRequests.Margin = new Padding(4, 0, 4, 0);
            lblOpenRequests.Name = "lblOpenRequests";
            lblOpenRequests.Size = new Size(184, 32);
            lblOpenRequests.TabIndex = 1;
            lblOpenRequests.Text = "Open Requests";
            lblOpenRequests.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 0;
            // 
            // lblMaintenanceTopic
            // 
            lblMaintenanceTopic.AutoSize = true;
            lblMaintenanceTopic.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintenanceTopic.Location = new Point(34, 46);
            lblMaintenanceTopic.Margin = new Padding(4, 0, 4, 0);
            lblMaintenanceTopic.Name = "lblMaintenanceTopic";
            lblMaintenanceTopic.Size = new Size(321, 65);
            lblMaintenanceTopic.TabIndex = 0;
            lblMaintenanceTopic.Text = "Maintenance";
            // 
            // lblLeasesTopic
            // 
            lblLeasesTopic.AutoSize = true;
            lblLeasesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeasesTopic.Location = new Point(44, 36);
            lblLeasesTopic.Margin = new Padding(4, 0, 4, 0);
            lblLeasesTopic.Name = "lblLeasesTopic";
            lblLeasesTopic.Size = new Size(145, 54);
            lblLeasesTopic.TabIndex = 0;
            lblLeasesTopic.Text = "Leases";
            // 
            // pnlActiveLeases
            // 
            pnlActiveLeases.BorderStyle = BorderStyle.FixedSingle;
            pnlActiveLeases.Controls.Add(lblTotalActiveLeases);
            pnlActiveLeases.Controls.Add(lblActiveLeaseNum);
            pnlActiveLeases.Controls.Add(lblActiveLeases);
            pnlActiveLeases.Location = new Point(30, 184);
            pnlActiveLeases.Margin = new Padding(4, 5, 4, 5);
            pnlActiveLeases.Name = "pnlActiveLeases";
            pnlActiveLeases.Size = new Size(259, 106);
            pnlActiveLeases.TabIndex = 1;
            // 
            // lblTotalActiveLeases
            // 
            lblTotalActiveLeases.AutoSize = true;
            lblTotalActiveLeases.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalActiveLeases.Location = new Point(30, 34);
            lblTotalActiveLeases.Margin = new Padding(4, 0, 4, 0);
            lblTotalActiveLeases.Name = "lblTotalActiveLeases";
            lblTotalActiveLeases.Size = new Size(38, 45);
            lblTotalActiveLeases.TabIndex = 2;
            lblTotalActiveLeases.Text = "0";
            // 
            // lblActiveLeaseNum
            // 
            lblActiveLeaseNum.AutoSize = true;
            lblActiveLeaseNum.Location = new Point(26, 40);
            lblActiveLeaseNum.Margin = new Padding(4, 0, 4, 0);
            lblActiveLeaseNum.Name = "lblActiveLeaseNum";
            lblActiveLeaseNum.Size = new Size(0, 25);
            lblActiveLeaseNum.TabIndex = 1;
            // 
            // lblActiveLeases
            // 
            lblActiveLeases.AutoSize = true;
            lblActiveLeases.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveLeases.Location = new Point(107, 21);
            lblActiveLeases.Margin = new Padding(4, 0, 4, 0);
            lblActiveLeases.Name = "lblActiveLeases";
            lblActiveLeases.Size = new Size(92, 64);
            lblActiveLeases.TabIndex = 0;
            lblActiveLeases.Text = "Active \r\nLeases\r\n";
            // 
            // pnlExpiredLeases
            // 
            pnlExpiredLeases.BorderStyle = BorderStyle.FixedSingle;
            pnlExpiredLeases.Controls.Add(lblTotalExpiredLeases);
            pnlExpiredLeases.Controls.Add(lblExpiredLeases);
            pnlExpiredLeases.Controls.Add(lblExpiredLeasesNum);
            pnlExpiredLeases.Location = new Point(298, 184);
            pnlExpiredLeases.Margin = new Padding(4, 5, 4, 5);
            pnlExpiredLeases.Name = "pnlExpiredLeases";
            pnlExpiredLeases.Size = new Size(258, 106);
            pnlExpiredLeases.TabIndex = 2;
            // 
            // lblTotalExpiredLeases
            // 
            lblTotalExpiredLeases.AutoSize = true;
            lblTotalExpiredLeases.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpiredLeases.Location = new Point(26, 40);
            lblTotalExpiredLeases.Margin = new Padding(4, 0, 4, 0);
            lblTotalExpiredLeases.Name = "lblTotalExpiredLeases";
            lblTotalExpiredLeases.Size = new Size(38, 45);
            lblTotalExpiredLeases.TabIndex = 4;
            lblTotalExpiredLeases.Text = "0";
            // 
            // lblExpiredLeases
            // 
            lblExpiredLeases.AutoSize = true;
            lblExpiredLeases.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiredLeases.Location = new Point(88, 26);
            lblExpiredLeases.Margin = new Padding(4, 0, 4, 0);
            lblExpiredLeases.Name = "lblExpiredLeases";
            lblExpiredLeases.Size = new Size(107, 64);
            lblExpiredLeases.TabIndex = 1;
            lblExpiredLeases.Text = "Expired \r\nLeases";
            // 
            // lblExpiredLeasesNum
            // 
            lblExpiredLeasesNum.AutoSize = true;
            lblExpiredLeasesNum.Location = new Point(18, 41);
            lblExpiredLeasesNum.Margin = new Padding(4, 0, 4, 0);
            lblExpiredLeasesNum.Name = "lblExpiredLeasesNum";
            lblExpiredLeasesNum.Size = new Size(0, 25);
            lblExpiredLeasesNum.TabIndex = 0;
            // 
            // pnlTerminatedLeases
            // 
            pnlTerminatedLeases.BorderStyle = BorderStyle.FixedSingle;
            pnlTerminatedLeases.Controls.Add(lblTotalTeminatedLeases);
            pnlTerminatedLeases.Controls.Add(lblTerminatedLeases);
            pnlTerminatedLeases.Controls.Add(lblTerminatedLeasesNum);
            pnlTerminatedLeases.Location = new Point(561, 184);
            pnlTerminatedLeases.Margin = new Padding(4, 5, 4, 5);
            pnlTerminatedLeases.Name = "pnlTerminatedLeases";
            pnlTerminatedLeases.Size = new Size(258, 109);
            pnlTerminatedLeases.TabIndex = 3;
            // 
            // lblTotalTeminatedLeases
            // 
            lblTotalTeminatedLeases.AutoSize = true;
            lblTotalTeminatedLeases.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTeminatedLeases.Location = new Point(25, 38);
            lblTotalTeminatedLeases.Margin = new Padding(4, 0, 4, 0);
            lblTotalTeminatedLeases.Name = "lblTotalTeminatedLeases";
            lblTotalTeminatedLeases.Size = new Size(38, 45);
            lblTotalTeminatedLeases.TabIndex = 3;
            lblTotalTeminatedLeases.Text = "0";
            // 
            // lblTerminatedLeases
            // 
            lblTerminatedLeases.AutoSize = true;
            lblTerminatedLeases.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTerminatedLeases.Location = new Point(98, 24);
            lblTerminatedLeases.Margin = new Padding(4, 0, 4, 0);
            lblTerminatedLeases.Name = "lblTerminatedLeases";
            lblTerminatedLeases.Size = new Size(150, 64);
            lblTerminatedLeases.TabIndex = 1;
            lblTerminatedLeases.Text = "Terminated \r\nLeases";
            // 
            // lblTerminatedLeasesNum
            // 
            lblTerminatedLeasesNum.AutoSize = true;
            lblTerminatedLeasesNum.Location = new Point(24, 39);
            lblTerminatedLeasesNum.Margin = new Padding(4, 0, 4, 0);
            lblTerminatedLeasesNum.Name = "lblTerminatedLeasesNum";
            lblTerminatedLeasesNum.Size = new Size(0, 25);
            lblTerminatedLeasesNum.TabIndex = 0;
            // 
            // pnlSearchLeases
            // 
            pnlSearchLeases.BackColor = Color.White;
            pnlSearchLeases.BorderStyle = BorderStyle.FixedSingle;
            pnlSearchLeases.Controls.Add(button2);
            pnlSearchLeases.Controls.Add(txtSearchLeases);
            pnlSearchLeases.Location = new Point(29, 311);
            pnlSearchLeases.Margin = new Padding(4, 5, 4, 5);
            pnlSearchLeases.Name = "pnlSearchLeases";
            pnlSearchLeases.Size = new Size(1348, 96);
            pnlSearchLeases.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(630, 23);
            button2.Name = "button2";
            button2.Size = new Size(182, 46);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtSearchLeases
            // 
            txtSearchLeases.Location = new Point(28, 26);
            txtSearchLeases.Margin = new Padding(4, 5, 4, 5);
            txtSearchLeases.Name = "txtSearchLeases";
            txtSearchLeases.Size = new Size(496, 31);
            txtSearchLeases.TabIndex = 0;
            // 
            // dgvLeases
            // 
            dgvLeases.AllowUserToAddRows = false;
            dgvLeases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLeases.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLeases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLeases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeases.Columns.AddRange(new DataGridViewColumn[] { NameTenants, NameProperty, NAMEUNITS, NameStartDate, NameEndDate, NameMontlyRent, NameStatus });
            dgvLeases.Location = new Point(28, 415);
            dgvLeases.Margin = new Padding(4, 5, 4, 5);
            dgvLeases.Name = "dgvLeases";
            dgvLeases.RowHeadersWidth = 51;
            dgvLeases.Size = new Size(1349, 446);
            dgvLeases.TabIndex = 5;
            // 
            // NameTenants
            // 
            NameTenants.HeaderText = "TENANTS";
            NameTenants.MinimumWidth = 8;
            NameTenants.Name = "NameTenants";
            // 
            // NameProperty
            // 
            NameProperty.HeaderText = "PROPERTY";
            NameProperty.MinimumWidth = 8;
            NameProperty.Name = "NameProperty";
            // 
            // NAMEUNITS
            // 
            NAMEUNITS.HeaderText = "UNITS";
            NAMEUNITS.MinimumWidth = 8;
            NAMEUNITS.Name = "NAMEUNITS";
            // 
            // NameStartDate
            // 
            NameStartDate.HeaderText = "START DATE";
            NameStartDate.MinimumWidth = 8;
            NameStartDate.Name = "NameStartDate";
            // 
            // NameEndDate
            // 
            NameEndDate.HeaderText = "END DATE";
            NameEndDate.MinimumWidth = 8;
            NameEndDate.Name = "NameEndDate";
            // 
            // NameMontlyRent
            // 
            NameMontlyRent.HeaderText = "MONTHLY RENT";
            NameMontlyRent.MinimumWidth = 8;
            NameMontlyRent.Name = "NameMontlyRent";
            // 
            // NameStatus
            // 
            NameStatus.HeaderText = "STATUS";
            NameStatus.MinimumWidth = 8;
            NameStatus.Name = "NameStatus";
            // 
            // LEASEID
            // 
            LEASEID.HeaderText = "LEASE ID";
            LEASEID.MinimumWidth = 6;
            LEASEID.Name = "LEASEID";
            LEASEID.Width = 125;
            // 
            // TENANT
            // 
            TENANT.HeaderText = "TENANT";
            TENANT.MinimumWidth = 6;
            TENANT.Name = "TENANT";
            TENANT.Width = 125;
            // 
            // NUNIT
            // 
            NUNIT.HeaderText = "Unit";
            NUNIT.MinimumWidth = 6;
            NUNIT.Name = "NUNIT";
            NUNIT.Width = 125;
            // 
            // STARTDATE
            // 
            STARTDATE.HeaderText = "START DATE";
            STARTDATE.MinimumWidth = 6;
            STARTDATE.Name = "STARTDATE";
            STARTDATE.Width = 125;
            // 
            // ENDDATE
            // 
            ENDDATE.HeaderText = "END DATE";
            ENDDATE.MinimumWidth = 6;
            ENDDATE.Name = "ENDDATE";
            ENDDATE.Width = 125;
            // 
            // MONTHLYRENT
            // 
            MONTHLYRENT.HeaderText = "MONTHLY RENT";
            MONTHLYRENT.MinimumWidth = 6;
            MONTHLYRENT.Name = "MONTHLYRENT";
            MONTHLYRENT.Width = 125;
            // 
            // LEASESTATUS
            // 
            LEASESTATUS.HeaderText = "LEASE STATUS";
            LEASESTATUS.MinimumWidth = 6;
            LEASESTATUS.Name = "LEASESTATUS";
            LEASESTATUS.Width = 125;
            // 
            // LEASEACTIONS
            // 
            LEASEACTIONS.HeaderText = "LEASE ACTIONS";
            LEASEACTIONS.MinimumWidth = 6;
            LEASEACTIONS.Name = "LEASEACTIONS";
            LEASEACTIONS.Width = 125;
            // 
            // btnCreateLease
            // 
            btnCreateLease.BackColor = Color.FromArgb(10, 22, 40);
            btnCreateLease.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateLease.ForeColor = Color.White;
            btnCreateLease.Location = new Point(1212, 65);
            btnCreateLease.Margin = new Padding(4, 5, 4, 5);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(198, 85);
            btnCreateLease.TabIndex = 6;
            btnCreateLease.Text = "+ Create Lease";
            btnCreateLease.UseVisualStyleBackColor = false;
            btnCreateLease.Click += btnCreateLease_Click;
            // 
            // pnlLeases
            // 
            pnlLeases.Controls.Add(lblLeasesAgreements);
            pnlLeases.Controls.Add(lblTotalLeases);
            pnlLeases.Controls.Add(btnCreateLease);
            pnlLeases.Controls.Add(dgvLeases);
            pnlLeases.Controls.Add(pnlSearchLeases);
            pnlLeases.Controls.Add(pnlTerminatedLeases);
            pnlLeases.Controls.Add(pnlExpiredLeases);
            pnlLeases.Controls.Add(pnlActiveLeases);
            pnlLeases.Controls.Add(lblLeasesTopic);
            pnlLeases.Location = new Point(274, 0);
            pnlLeases.Margin = new Padding(4);
            pnlLeases.Name = "pnlLeases";
            pnlLeases.Size = new Size(1442, 866);
            pnlLeases.TabIndex = 1;
            pnlLeases.Visible = false;
            // 
            // lblLeasesAgreements
            // 
            lblLeasesAgreements.AutoSize = true;
            lblLeasesAgreements.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeasesAgreements.Location = new Point(96, 95);
            lblLeasesAgreements.Margin = new Padding(4, 0, 4, 0);
            lblLeasesAgreements.Name = "lblLeasesAgreements";
            lblLeasesAgreements.Size = new Size(180, 28);
            lblLeasesAgreements.TabIndex = 3;
            lblLeasesAgreements.Text = "Lease Agreements";
            // 
            // lblTotalLeases
            // 
            lblTotalLeases.AutoSize = true;
            lblTotalLeases.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLeases.Location = new Point(50, 93);
            lblTotalLeases.Margin = new Padding(4, 0, 4, 0);
            lblTotalLeases.Name = "lblTotalLeases";
            lblTotalLeases.Size = new Size(38, 45);
            lblTotalLeases.TabIndex = 4;
            lblTotalLeases.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Properties_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1712, 866);
            Controls.Add(pnlMainForm);
            Controls.Add(pnlMaintenance);
            Controls.Add(pnlLeases);
            Controls.Add(pnlContent);
            Controls.Add(pnlTenants);
            Controls.Add(pnlRentalUnit);
            Controls.Add(pnlRentPayments);
            Controls.Add(pnlDashBoard);
            Controls.Add(pnlExpenses);
            Margin = new Padding(4);
            Name = "Properties_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Properties_Form";
            Load += Properties_Form_Load;
            pnlMainForm.ResumeLayout(false);
            pnlMainForm.PerformLayout();
            pnlUserLoginInfo.ResumeLayout(false);
            pnlUserLoginInfo.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            pnlRentPayments.ResumeLayout(false);
            pnlRentPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTenants.ResumeLayout(false);
            pnlTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddTenants).EndInit();
            pnlFilterBar.ResumeLayout(false);
            pnlFilterBar.PerformLayout();
            pnlRentalUnit.ResumeLayout(false);
            pnlRentalUnit.PerformLayout();
            pnlAvailability.ResumeLayout(false);
            pnlAvailability.PerformLayout();
            pnlOccupancy.ResumeLayout(false);
            pnlOccupancy.PerformLayout();
            pnlTotalUnits.ResumeLayout(false);
            pnlTotalUnits.PerformLayout();
            pnlExpenses.ResumeLayout(false);
            pnlExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesRecords).EndInit();
            pnlSearchExpense.ResumeLayout(false);
            pnlSearchExpense.PerformLayout();
            pnlUtilitiesRecords.ResumeLayout(false);
            pnlUtilitiesRecords.PerformLayout();
            pnlSecurityRecords.ResumeLayout(false);
            pnlSecurityRecords.PerformLayout();
            pnlInsuranceRecords.ResumeLayout(false);
            pnlInsuranceRecords.PerformLayout();
            pnlMaintenanceRecord.ResumeLayout(false);
            pnlMaintenanceRecord.PerformLayout();
            pnlMaintenance.ResumeLayout(false);
            pnlMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceRecords).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlActiveLeases.ResumeLayout(false);
            pnlActiveLeases.PerformLayout();
            pnlExpiredLeases.ResumeLayout(false);
            pnlExpiredLeases.PerformLayout();
            pnlTerminatedLeases.ResumeLayout(false);
            pnlTerminatedLeases.PerformLayout();
            pnlSearchLeases.ResumeLayout(false);
            pnlSearchLeases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeases).EndInit();
            pnlLeases.ResumeLayout(false);
            pnlLeases.PerformLayout();
            ResumeLayout(false);
        }

        #endregion 

        private Panel pnlMainForm;
        private Button btnDashboard;
        private Label lblLogo;
        private Button btnMaintenance;
        private Button btnExpenses;
        private Button btnRentPayments;
        private Button btnLeases;
        private Button btnTenants;
        private Button btnRentalUnits;
        private Button btnProperties;
        private Panel pnlContent;
        private Panel pnlDashBoard;
        private Label lblDashboardHeader;
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
        private Panel pnlTenants;
        private Label lblRegisteredTenants;
        private Label lblTenants;
        private Panel pnlFilterBar;
        private ComboBox cmbProperties;
        private TextBox txtSearchTenants;
        private ComboBox cmbStatuses;
        private DataGridView dgvAddTenants;
        private DataGridViewTextBoxColumn Tenants;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Properties;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Lease_Status;
        private DataGridViewTextBoxColumn Outstanding;
        private DataGridViewTextBoxColumn Action;
        private Button btnAddTenants;
        private Panel pnlRentalUnit;
        private Label lblRentalUnit;
        private Panel pnlAvailability;
        private Panel pnlOccupancy;
        private Panel pnlTotalUnits;
        private Button btnAddUnit;
        private Label lblTotalUnits;
        private Label lblAvailable;
        private Label lblOccupied;
        private Label lblAvailableNum;
        private Label lblOccupiedNum;
        private Label lblTotalUnitsNum;
        private Panel pnlUserLoginInfo;
        private Label lblRole;
        private Label lblUserName;
        private Button btnLogOut;
        private Panel pnlRentPayments;
        private Label lblRentTopic;
        private Panel pnlExpenses;
        private Label lblExpensesTopic;
        private Panel pnlMaintenance;
        private Label lblMaintenanceTopic;
        private Label lblLeasesTopic;
        private Panel pnlActiveLeases;
        private Panel pnlExpiredLeases;
        private Panel pnlTerminatedLeases;
        private Panel pnlSearchLeases;
        private TextBox txtSearchLeases;
        private DataGridView dgvLeases;
        private DataGridViewTextBoxColumn LEASEID;
        private DataGridViewTextBoxColumn TENANT;
        private DataGridViewTextBoxColumn PROPERTY;
        private DataGridViewTextBoxColumn NUNIT;
        private DataGridViewTextBoxColumn STARTDATE;
        private DataGridViewTextBoxColumn ENDDATE;
        private DataGridViewTextBoxColumn MONTHLYRENT;
        private DataGridViewTextBoxColumn LEASESTATUS;
        private DataGridViewTextBoxColumn LEASEACTIONS;
        private Button btnCreateLease;
        private Panel pnlLeases;
        private Label lblActiveLeaseNum;
        private Label lblActiveLeases;
        private Label lblExpiredLeases;
        private Label lblExpiredLeasesNum;
        private Label lblTerminatedLeases;
        private Label lblTerminatedLeasesNum;
        private Panel pnlUtilitiesRecords;
        private Panel pnlSecurityRecords;
        private Label lblUtilities;
        private Label lblSecutityNumber;
        private Label lblSecurity;
        private Panel pnlInsuranceRecords;
        private Label lblInsurance;
        private Label lblInsuranceNumber;
        private Panel pnlMaintenanceRecord;
        private Label lblMaintenanceNumber;
        private Label lblMaintenance;
        private DataGridView dgvExpensesRecords;
        private Panel pnlSearchExpense;
        private TextBox txtSearchAnExpense;
        private Label lblUtilitiesNumber;
        private Button btnAddExpense;
        private Button btnRecordPayment;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Label lblExpectedRent;
        private Label lblOutstandingRent;
        private Label lblLatePayment;
        private Label lblCollectedRent;
        private Label lblExpectedRentDisplay;
        private Label lblOutstandingRentDisplay;
        private Label lblLatePaymentDisplay;
        private Label lblCollectedRentDisplay;
        private Button btnGenerateReceipts;
        private ComboBox cbxStatus;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn TENANT2;
        private DataGridViewTextBoxColumn PROPERTY2;
        private DataGridViewTextBoxColumn UNITS;
        private DataGridViewTextBoxColumn RENTDUE;
        private DataGridViewTextBoxColumn AMOUNTPAID;
        private DataGridViewTextBoxColumn OUTSTANDINGS;
        private DataGridViewTextBoxColumn PAYMENTDATE;
        private DataGridViewTextBoxColumn RECEIPTN0;
        private DataGridViewTextBoxColumn STATUSES;
        private Panel panel6;
        private Label lblTrackAndResolveMaintenanceRequests;
        private Button btnNewRequests;
        private Panel pnlSearchBar;
        private Button btnResolved;
        private Button btnPending;
        private Button btnOpenRequests;
        private Button btnAll;
        private TextBox txtSearchBox;
        private Panel panel8;
        private Panel panel7;
        private DataGridView dgvMaintenanceRecords;
        private Label lblResolved;
        private Label label6;
        private Label lblPending;
        private Label label4;
        private Label lblOpenRequests;
        private Label label2;
        private Label lblTotalActiveLeases;
        private Label lblTotalExpiredLeases;
        private Label lblTotalTeminatedLeases;
        private Button button2;
        private Label lblLeasesAgreements;
        private Label lblTotalLeases;
        private DataGridViewTextBoxColumn NameTenants;
        private DataGridViewTextBoxColumn NameProperty;
        private DataGridViewTextBoxColumn NAMEUNITS;
        private DataGridViewTextBoxColumn NameStartDate;
        private DataGridViewTextBoxColumn NameEndDate;
        private DataGridViewTextBoxColumn NameMontlyRent;
        private DataGridViewTextBoxColumn NameStatus;
        private Label lblTotalUtilities;
        private Label lblTotalSecurity;
        private Label lblTotalInsurance;
        private Label lblTotalMaintenance;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Property;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn TENANTS2;
        private DataGridViewTextBoxColumn PROPERTYORUNIT;
        private DataGridViewTextBoxColumn DESCRIPTIONS;
        private DataGridViewTextBoxColumn PRIORITY;
        private DataGridViewTextBoxColumn STATUS1;
        private DataGridViewTextBoxColumn DATES;
    }
}