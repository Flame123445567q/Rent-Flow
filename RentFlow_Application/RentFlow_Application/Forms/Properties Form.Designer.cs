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
            pnlLeases = new Panel();
            lblLeasesTopic = new Label();
            pnlRentPayments = new Panel();
            lblRentTopic = new Label();
            pnlTenants = new Panel();
            btnAddTenants = new Button();
            dataGridView1 = new DataGridView();
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
            lblExpensesTopic = new Label();
            pnlMaintenance = new Panel();
            lblMaintenanceTopic = new Label();
            pnlMaintenanceRecord = new Panel();
            pnlInsuranceRecords = new Panel();
            pnlSecurityRecords = new Panel();
            pnlUtilitiesRecords = new Panel();
            lblMaintenance = new Label();
            lblMaintenanceNumber = new Label();
            lblInsuranceNumber = new Label();
            lblInsurance = new Label();
            lblSecurity = new Label();
            lblSecutityNumber = new Label();
            lblUtilities = new Label();
            lblUtilitiesNumber = new Label();
            pnlSearchExpense = new Panel();
            txtSearchAnExpense = new TextBox();
            cmbAllCategories = new ComboBox();
            cmbAllProperties = new ComboBox();
            dgvExpensesRecords = new DataGridView();
            ExpenseID = new DataGridViewTextBoxColumn();
            Property = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ExpensesAction = new DataGridViewTextBoxColumn();
            btnAddExpense = new Button();
            pnlMainForm.SuspendLayout();
            pnlUserLoginInfo.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlDashBoard.SuspendLayout();
            pnlLeases.SuspendLayout();
            pnlRentPayments.SuspendLayout();
            pnlTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlFilterBar.SuspendLayout();
            pnlRentalUnit.SuspendLayout();
            pnlAvailability.SuspendLayout();
            pnlOccupancy.SuspendLayout();
            pnlTotalUnits.SuspendLayout();
            pnlExpenses.SuspendLayout();
            pnlMaintenance.SuspendLayout();
            pnlMaintenanceRecord.SuspendLayout();
            pnlInsuranceRecords.SuspendLayout();
            pnlSecurityRecords.SuspendLayout();
            pnlUtilitiesRecords.SuspendLayout();
            pnlSearchExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesRecords).BeginInit();
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
            pnlMainForm.MaximumSize = new Size(240, 0);
            pnlMainForm.Name = "pnlMainForm";
            pnlMainForm.Size = new Size(220, 694);
            pnlMainForm.TabIndex = 0;
            pnlMainForm.Paint += pnlMainForm_Paint;
            // 
            // pnlUserLoginInfo
            // 
            pnlUserLoginInfo.Controls.Add(lblUserName);
            pnlUserLoginInfo.Controls.Add(btnLogOut);
            pnlUserLoginInfo.Controls.Add(lblRole);
            pnlUserLoginInfo.Dock = DockStyle.Bottom;
            pnlUserLoginInfo.Location = new Point(0, 614);
            pnlUserLoginInfo.MaximumSize = new Size(0, 80);
            pnlUserLoginInfo.Name = "pnlUserLoginInfo";
            pnlUserLoginInfo.Size = new Size(220, 80);
            pnlUserLoginInfo.TabIndex = 10;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = SystemColors.ButtonFace;
            lblUserName.Location = new Point(99, 8);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "label1";
            lblUserName.Click += lblUserName_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(39, 39);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.AliceBlue;
            lblRole.Location = new Point(22, 7);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(10, 478);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(210, 40);
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
            btnExpenses.Location = new Point(10, 424);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(210, 40);
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
            btnRentPayments.Location = new Point(10, 370);
            btnRentPayments.Name = "btnRentPayments";
            btnRentPayments.Size = new Size(210, 40);
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
            btnLeases.Location = new Point(10, 316);
            btnLeases.Name = "btnLeases";
            btnLeases.Size = new Size(210, 40);
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
            btnTenants.Location = new Point(10, 262);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(210, 40);
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
            btnRentalUnits.Location = new Point(10, 208);
            btnRentalUnits.Name = "btnRentalUnits";
            btnRentalUnits.Size = new Size(210, 40);
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
            btnProperties.Location = new Point(10, 154);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(210, 40);
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
            btnDashboard.Location = new Point(10, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 40);
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
            lblLogo.Location = new Point(22, 26);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(187, 41);
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
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1159, 694);
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
            // dgvProperties
            // 
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.BackgroundColor = Color.White;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyID, PropertyName, Address, TotalUnits, Occupied, Available, Status, Actions });
            dgvProperties.Location = new Point(30, 310);
            dgvProperties.MultiSelect = false;
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RowHeadersWidth = 51;
            dgvProperties.Size = new Size(1055, 410);
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
            pnlDashBoard.Location = new Point(226, 0);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(1153, 770);
            pnlDashBoard.TabIndex = 2;
            // 
            // lblDashboardHeader
            // 
            lblDashboardHeader.AutoSize = true;
            lblDashboardHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardHeader.Location = new Point(35, 44);
            lblDashboardHeader.Name = "lblDashboardHeader";
            lblDashboardHeader.Size = new Size(193, 46);
            lblDashboardHeader.TabIndex = 0;
            lblDashboardHeader.Text = "Dashboard";
            // 
            // pnlLeases
            // 
            pnlLeases.Controls.Add(lblLeasesTopic);
            pnlLeases.Location = new Point(220, 0);
            pnlLeases.Name = "pnlLeases";
            pnlLeases.Size = new Size(1159, 694);
            pnlLeases.TabIndex = 1;
            pnlLeases.Visible = false;
            // 
            // lblLeasesTopic
            // 
            lblLeasesTopic.AutoSize = true;
            lblLeasesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeasesTopic.Location = new Point(30, 51);
            lblLeasesTopic.Name = "lblLeasesTopic";
            lblLeasesTopic.Size = new Size(121, 46);
            lblLeasesTopic.TabIndex = 0;
            lblLeasesTopic.Text = "Leases";
            // 
            // pnlRentPayments
            // 
            pnlRentPayments.Controls.Add(lblRentTopic);
            pnlRentPayments.Location = new Point(220, 0);
            pnlRentPayments.Name = "pnlRentPayments";
            pnlRentPayments.Size = new Size(1159, 694);
            pnlRentPayments.TabIndex = 1;
            // 
            // lblRentTopic
            // 
            lblRentTopic.AutoSize = true;
            lblRentTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentTopic.Location = new Point(21, 53);
            lblRentTopic.Name = "lblRentTopic";
            lblRentTopic.Size = new Size(256, 46);
            lblRentTopic.TabIndex = 0;
            lblRentTopic.Text = "Rent Payments";
            // 
            // pnlTenants
            // 
            pnlTenants.Controls.Add(btnAddTenants);
            pnlTenants.Controls.Add(dataGridView1);
            pnlTenants.Controls.Add(lblRegisteredTenants);
            pnlTenants.Controls.Add(lblTenants);
            pnlTenants.Controls.Add(pnlFilterBar);
            pnlTenants.Location = new Point(220, 0);
            pnlTenants.Name = "pnlTenants";
            pnlTenants.Size = new Size(1159, 732);
            pnlTenants.TabIndex = 17;
            // 
            // btnAddTenants
            // 
            btnAddTenants.BackColor = Color.DarkBlue;
            btnAddTenants.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTenants.ForeColor = Color.White;
            btnAddTenants.Location = new Point(884, 60);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(177, 47);
            btnAddTenants.TabIndex = 4;
            btnAddTenants.Text = "+Add Tenants";
            btnAddTenants.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tenants, Contact, Properties, Unit, Lease_Status, Outstanding, Action });
            dataGridView1.Location = new Point(35, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 433);
            dataGridView1.TabIndex = 3;
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
            lblRegisteredTenants.Location = new Point(21, 64);
            lblRegisteredTenants.Name = "lblRegisteredTenants";
            lblRegisteredTenants.Size = new Size(0, 20);
            lblRegisteredTenants.TabIndex = 1;
            // 
            // lblTenants
            // 
            lblTenants.AutoSize = true;
            lblTenants.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenants.Location = new Point(21, 20);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(126, 41);
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
            pnlFilterBar.Location = new Point(32, 157);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1029, 64);
            pnlFilterBar.TabIndex = 2;
            // 
            // cmbStatuses
            // 
            cmbStatuses.FlatStyle = FlatStyle.System;
            cmbStatuses.FormattingEnabled = true;
            cmbStatuses.Items.AddRange(new object[] { "All Statuses", "Active", "Expiring Soon" });
            cmbStatuses.Location = new Point(665, 17);
            cmbStatuses.Name = "cmbStatuses";
            cmbStatuses.Size = new Size(151, 28);
            cmbStatuses.TabIndex = 2;
            // 
            // cmbProperties
            // 
            cmbProperties.FlatStyle = FlatStyle.System;
            cmbProperties.FormattingEnabled = true;
            cmbProperties.Location = new Point(479, 17);
            cmbProperties.Name = "cmbProperties";
            cmbProperties.Size = new Size(151, 28);
            cmbProperties.TabIndex = 1;
            // 
            // txtSearchTenants
            // 
            txtSearchTenants.Location = new Point(34, 19);
            txtSearchTenants.Name = "txtSearchTenants";
            txtSearchTenants.PlaceholderText = "Search Tenants...";
            txtSearchTenants.Size = new Size(303, 27);
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
            pnlRentalUnit.Location = new Point(231, 0);
            pnlRentalUnit.Name = "pnlRentalUnit";
            pnlRentalUnit.Size = new Size(1148, 694);
            pnlRentalUnit.TabIndex = 5;
            // 
            // pnlAvailability
            // 
            pnlAvailability.Controls.Add(lblAvailableNum);
            pnlAvailability.Controls.Add(lblAvailable);
            pnlAvailability.Location = new Point(328, 112);
            pnlAvailability.Name = "pnlAvailability";
            pnlAvailability.Size = new Size(250, 125);
            pnlAvailability.TabIndex = 3;
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(14, 47);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 20);
            lblAvailableNum.TabIndex = 2;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(3, 10);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(71, 20);
            lblAvailable.TabIndex = 0;
            lblAvailable.Text = "Available";
            // 
            // pnlOccupancy
            // 
            pnlOccupancy.Controls.Add(lblOccupiedNum);
            pnlOccupancy.Controls.Add(lblOccupied);
            pnlOccupancy.Location = new Point(618, 114);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Size = new Size(250, 125);
            pnlOccupancy.TabIndex = 3;
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(25, 54);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 20);
            lblOccupiedNum.TabIndex = 3;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(3, 8);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(72, 20);
            lblOccupied.TabIndex = 1;
            lblOccupied.Text = "Occupied";
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.Controls.Add(lblTotalUnitsNum);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Location = new Point(37, 112);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(250, 125);
            pnlTotalUnits.TabIndex = 2;
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(29, 45);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 20);
            lblTotalUnitsNum.TabIndex = 1;
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Location = new Point(20, 10);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(79, 20);
            lblTotalUnits.TabIndex = 0;
            lblTotalUnits.Text = "Total Units";
            // 
            // btnAddUnit
            // 
            btnAddUnit.BackColor = Color.RoyalBlue;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.ForeColor = Color.White;
            btnAddUnit.Location = new Point(589, 41);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(156, 48);
            btnAddUnit.TabIndex = 1;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.ForeColor = SystemColors.ActiveCaptionText;
            lblRentalUnit.Location = new Point(35, 44);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(199, 46);
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
            pnlExpenses.Location = new Point(220, 0);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(1159, 694);
            pnlExpenses.TabIndex = 1;
            // 
            // lblExpensesTopic
            // 
            lblExpensesTopic.AutoSize = true;
            lblExpensesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpensesTopic.Location = new Point(19, 53);
            lblExpensesTopic.Name = "lblExpensesTopic";
            lblExpensesTopic.Size = new Size(165, 46);
            lblExpensesTopic.TabIndex = 0;
            lblExpensesTopic.Text = "Expenses";
            // 
            // pnlMaintenance
            // 
            pnlMaintenance.Controls.Add(lblMaintenanceTopic);
            pnlMaintenance.Location = new Point(220, 0);
            pnlMaintenance.Name = "pnlMaintenance";
            pnlMaintenance.Size = new Size(1159, 694);
            pnlMaintenance.TabIndex = 1;
            // 
            // lblMaintenanceTopic
            // 
            lblMaintenanceTopic.AutoSize = true;
            lblMaintenanceTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintenanceTopic.Location = new Point(27, 38);
            lblMaintenanceTopic.Name = "lblMaintenanceTopic";
            lblMaintenanceTopic.Size = new Size(227, 46);
            lblMaintenanceTopic.TabIndex = 0;
            lblMaintenanceTopic.Text = "Maintenance";
            // 
            // pnlMaintenanceRecord
            // 
            pnlMaintenanceRecord.Controls.Add(lblMaintenanceNumber);
            pnlMaintenanceRecord.Controls.Add(lblMaintenance);
            pnlMaintenanceRecord.Location = new Point(29, 127);
            pnlMaintenanceRecord.Name = "pnlMaintenanceRecord";
            pnlMaintenanceRecord.Size = new Size(250, 125);
            pnlMaintenanceRecord.TabIndex = 1;
            // 
            // pnlInsuranceRecords
            // 
            pnlInsuranceRecords.Controls.Add(lblInsurance);
            pnlInsuranceRecords.Controls.Add(lblInsuranceNumber);
            pnlInsuranceRecords.Location = new Point(285, 127);
            pnlInsuranceRecords.Name = "pnlInsuranceRecords";
            pnlInsuranceRecords.Size = new Size(250, 125);
            pnlInsuranceRecords.TabIndex = 2;
            // 
            // pnlSecurityRecords
            // 
            pnlSecurityRecords.Controls.Add(lblSecutityNumber);
            pnlSecurityRecords.Controls.Add(lblSecurity);
            pnlSecurityRecords.Location = new Point(541, 127);
            pnlSecurityRecords.Name = "pnlSecurityRecords";
            pnlSecurityRecords.Size = new Size(250, 125);
            pnlSecurityRecords.TabIndex = 3;
            // 
            // pnlUtilitiesRecords
            // 
            pnlUtilitiesRecords.Controls.Add(lblUtilitiesNumber);
            pnlUtilitiesRecords.Controls.Add(lblUtilities);
            pnlUtilitiesRecords.Location = new Point(797, 127);
            pnlUtilitiesRecords.Name = "pnlUtilitiesRecords";
            pnlUtilitiesRecords.Size = new Size(225, 125);
            pnlUtilitiesRecords.TabIndex = 3;
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.Location = new Point(21, 16);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(94, 20);
            lblMaintenance.TabIndex = 0;
            lblMaintenance.Text = "Maintenance";
            // 
            // lblMaintenanceNumber
            // 
            lblMaintenanceNumber.AutoSize = true;
            lblMaintenanceNumber.Location = new Point(100, 52);
            lblMaintenanceNumber.Name = "lblMaintenanceNumber";
            lblMaintenanceNumber.Size = new Size(0, 20);
            lblMaintenanceNumber.TabIndex = 1;
            // 
            // lblInsuranceNumber
            // 
            lblInsuranceNumber.AutoSize = true;
            lblInsuranceNumber.Location = new Point(100, 52);
            lblInsuranceNumber.Name = "lblInsuranceNumber";
            lblInsuranceNumber.Size = new Size(0, 20);
            lblInsuranceNumber.TabIndex = 1;
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Location = new Point(19, 16);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(71, 20);
            lblInsurance.TabIndex = 2;
            lblInsurance.Text = "Insurance";
            // 
            // lblSecurity
            // 
            lblSecurity.AutoSize = true;
            lblSecurity.Location = new Point(13, 8);
            lblSecurity.Name = "lblSecurity";
            lblSecurity.Size = new Size(61, 20);
            lblSecurity.TabIndex = 3;
            lblSecurity.Text = "Security";
            // 
            // lblSecutityNumber
            // 
            lblSecutityNumber.AutoSize = true;
            lblSecutityNumber.Location = new Point(100, 52);
            lblSecutityNumber.Name = "lblSecutityNumber";
            lblSecutityNumber.Size = new Size(0, 20);
            lblSecutityNumber.TabIndex = 4;
            // 
            // lblUtilities
            // 
            lblUtilities.AutoSize = true;
            lblUtilities.Location = new Point(14, 8);
            lblUtilities.Name = "lblUtilities";
            lblUtilities.Size = new Size(59, 20);
            lblUtilities.TabIndex = 5;
            lblUtilities.Text = "Utilities";
            // 
            // lblUtilitiesNumber
            // 
            lblUtilitiesNumber.AutoSize = true;
            lblUtilitiesNumber.Location = new Point(100, 52);
            lblUtilitiesNumber.Name = "lblUtilitiesNumber";
            lblUtilitiesNumber.Size = new Size(0, 20);
            lblUtilitiesNumber.TabIndex = 6;
            // 
            // pnlSearchExpense
            // 
            pnlSearchExpense.Controls.Add(cmbAllProperties);
            pnlSearchExpense.Controls.Add(cmbAllCategories);
            pnlSearchExpense.Controls.Add(txtSearchAnExpense);
            pnlSearchExpense.Location = new Point(31, 269);
            pnlSearchExpense.Name = "pnlSearchExpense";
            pnlSearchExpense.Size = new Size(991, 71);
            pnlSearchExpense.TabIndex = 4;
            // 
            // txtSearchAnExpense
            // 
            txtSearchAnExpense.Location = new Point(32, 25);
            txtSearchAnExpense.Name = "txtSearchAnExpense";
            txtSearchAnExpense.Size = new Size(350, 27);
            txtSearchAnExpense.TabIndex = 0;
            // 
            // cmbAllCategories
            // 
            cmbAllCategories.FormattingEnabled = true;
            cmbAllCategories.Items.AddRange(new object[] { "Maintenance", "Insurance", "Security", "Utilities" });
            cmbAllCategories.Location = new Point(447, 26);
            cmbAllCategories.Name = "cmbAllCategories";
            cmbAllCategories.Size = new Size(151, 28);
            cmbAllCategories.TabIndex = 1;
            // 
            // cmbAllProperties
            // 
            cmbAllProperties.FormattingEnabled = true;
            cmbAllProperties.Location = new Point(645, 25);
            cmbAllProperties.Name = "cmbAllProperties";
            cmbAllProperties.Size = new Size(151, 28);
            cmbAllProperties.TabIndex = 2;
            // 
            // dgvExpensesRecords
            // 
            dgvExpensesRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensesRecords.Columns.AddRange(new DataGridViewColumn[] { ExpenseID, Property, Category, Description, Amount, Date, ExpensesAction });
            dgvExpensesRecords.Location = new Point(27, 370);
            dgvExpensesRecords.Name = "dgvExpensesRecords";
            dgvExpensesRecords.RowHeadersWidth = 51;
            dgvExpensesRecords.Size = new Size(995, 188);
            dgvExpensesRecords.TabIndex = 5;
            // 
            // ExpenseID
            // 
            ExpenseID.HeaderText = "Expense ID";
            ExpenseID.MinimumWidth = 6;
            ExpenseID.Name = "ExpenseID";
            ExpenseID.Width = 125;
            // 
            // Property
            // 
            Property.HeaderText = "Property";
            Property.MinimumWidth = 6;
            Property.Name = "Property";
            Property.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // ExpensesAction
            // 
            ExpensesAction.HeaderText = "Expense Action";
            ExpensesAction.MinimumWidth = 6;
            ExpensesAction.Name = "ExpensesAction";
            ExpensesAction.Width = 125;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(860, 64);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(130, 42);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "+ Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // Properties_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 694);
            Controls.Add(pnlMainForm);
            Controls.Add(pnlExpenses);
            Controls.Add(pnlMaintenance);
            Controls.Add(pnlLeases);
            Controls.Add(pnlContent);
            Controls.Add(pnlTenants);
            Controls.Add(pnlRentalUnit);
            Controls.Add(pnlDashBoard);
            Controls.Add(pnlRentPayments);
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
            pnlLeases.ResumeLayout(false);
            pnlLeases.PerformLayout();
            pnlRentPayments.ResumeLayout(false);
            pnlRentPayments.PerformLayout();
            pnlTenants.ResumeLayout(false);
            pnlTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
            pnlMaintenance.ResumeLayout(false);
            pnlMaintenance.PerformLayout();
            pnlMaintenanceRecord.ResumeLayout(false);
            pnlMaintenanceRecord.PerformLayout();
            pnlInsuranceRecords.ResumeLayout(false);
            pnlInsuranceRecords.PerformLayout();
            pnlSecurityRecords.ResumeLayout(false);
            pnlSecurityRecords.PerformLayout();
            pnlUtilitiesRecords.ResumeLayout(false);
            pnlUtilitiesRecords.PerformLayout();
            pnlSearchExpense.ResumeLayout(false);
            pnlSearchExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesRecords).EndInit();
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
        private DataGridView dataGridView1;
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
        private Panel pnlLeases;
        private Label lblLeasesTopic;
        private Panel pnlRentPayments;
        private Label lblRentTopic;
        private Panel pnlExpenses;
        private Label lblExpensesTopic;
        private Panel pnlMaintenance;
        private Label lblMaintenanceTopic;
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
        private DataGridViewTextBoxColumn ExpenseID;
        private DataGridViewTextBoxColumn Property;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ExpensesAction;
        private Panel pnlSearchExpense;
        private ComboBox cmbAllProperties;
        private ComboBox cmbAllCategories;
        private TextBox txtSearchAnExpense;
        private Label lblUtilitiesNumber;
        private Button btnAddExpense;
    }
}