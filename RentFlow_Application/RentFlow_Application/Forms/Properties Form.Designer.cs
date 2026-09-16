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
            pnlRentPayments = new Panel();
            panel5 = new Panel();
            btnRecordPayment = new Button();
            panel4 = new Panel();
            lblExpectedRent = new Label();
            panel2 = new Panel();
            lblOutstandingRent = new Label();
            panel3 = new Panel();
            lblLatePayment = new Label();
            panel1 = new Panel();
            lblCollectedRent = new Label();
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
            lblLeasesTopic = new Label();
            pnlActiveLeases = new Panel();
            pnlExpiredLeases = new Panel();
            pnlTerminatedLeases = new Panel();
            pnlSearchLeases = new Panel();
            txtSearchLeases = new TextBox();
            cmbAllStatus = new ComboBox();
            dgvLeases = new DataGridView();
            LEASEACTIONS = new DataGridViewTextBoxColumn();
            LEASESTATUS = new DataGridViewTextBoxColumn();
            MONTHLYRENT = new DataGridViewTextBoxColumn();
            ENDDATE = new DataGridViewTextBoxColumn();
            STARTDATE = new DataGridViewTextBoxColumn();
            NUNIT = new DataGridViewTextBoxColumn();
            PROPERTY = new DataGridViewTextBoxColumn();
            TENANT = new DataGridViewTextBoxColumn();
            LEASEID = new DataGridViewTextBoxColumn();
            btnCreateLease = new Button();
            pnlLeases = new Panel();
            lblActiveLeases = new Label();
            lblActiveLeaseNum = new Label();
            lblExpiredLeasesNum = new Label();
            lblExpiredLeases = new Label();
            lblTerminatedLeasesNum = new Label();
            lblTerminatedLeases = new Label();
            lblExpectedRentDisplay = new Label();
            lblLatePaymentDisplay = new Label();
            lblOutstandingRentDisplay = new Label();
            lblCollectedRentDisplay = new Label();
            textBox1 = new TextBox();
            cbxStatus = new ComboBox();
            btnGenerateReceipts = new Button();
            dataGridView2 = new DataGridView();
            TENANT = new DataGridViewTextBoxColumn();
            PROPERTY = new DataGridViewTextBoxColumn();
            UNITS = new DataGridViewTextBoxColumn();
            RENTDUE = new DataGridViewTextBoxColumn();
            AMOUNTPAID = new DataGridViewTextBoxColumn();
            OUTSTANDINGS = new DataGridViewTextBoxColumn();
            PAYMENTDATE = new DataGridViewTextBoxColumn();
            RECEIPTN0 = new DataGridViewTextBoxColumn();
            STATUSES = new DataGridViewTextBoxColumn();
            pnlMainForm.SuspendLayout();
            pnlUserLoginInfo.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlDashBoard.SuspendLayout();
            pnlRentPayments.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnlTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlFilterBar.SuspendLayout();
            pnlRentalUnit.SuspendLayout();
            pnlAvailability.SuspendLayout();
            pnlOccupancy.SuspendLayout();
            pnlTotalUnits.SuspendLayout();
            pnlExpenses.SuspendLayout();
            pnlMaintenance.SuspendLayout();
            pnlActiveLeases.SuspendLayout();
            pnlExpiredLeases.SuspendLayout();
            pnlTerminatedLeases.SuspendLayout();
            pnlSearchLeases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeases).BeginInit();
            pnlLeases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            pnlMainForm.Margin = new Padding(3, 2, 3, 2);
            pnlMainForm.MaximumSize = new Size(210, 0);
            pnlMainForm.Name = "pnlMainForm";
            pnlMainForm.Size = new Size(192, 520);
            pnlMainForm.TabIndex = 0;
            pnlMainForm.Paint += pnlMainForm_Paint;
            // 
            // pnlUserLoginInfo
            // 
            pnlUserLoginInfo.Controls.Add(lblUserName);
            pnlUserLoginInfo.Controls.Add(btnLogOut);
            pnlUserLoginInfo.Controls.Add(lblRole);
            pnlUserLoginInfo.Dock = DockStyle.Bottom;
            pnlUserLoginInfo.Location = new Point(0, 460);
            pnlUserLoginInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserLoginInfo.MaximumSize = new Size(0, 60);
            pnlUserLoginInfo.Name = "pnlUserLoginInfo";
            pnlUserLoginInfo.Size = new Size(192, 60);
            pnlUserLoginInfo.TabIndex = 10;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = SystemColors.ButtonFace;
            lblUserName.Location = new Point(87, 6);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(38, 15);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "label1";
            lblUserName.Click += lblUserName_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(34, 29);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(82, 22);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.AliceBlue;
            lblRole.Location = new Point(19, 5);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(9, 358);
            btnMaintenance.Margin = new Padding(3, 2, 3, 2);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(184, 30);
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
            btnExpenses.Location = new Point(9, 318);
            btnExpenses.Margin = new Padding(3, 2, 3, 2);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(184, 30);
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
            btnRentPayments.Location = new Point(9, 278);
            btnRentPayments.Margin = new Padding(3, 2, 3, 2);
            btnRentPayments.Name = "btnRentPayments";
            btnRentPayments.Size = new Size(184, 30);
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
            btnLeases.Location = new Point(9, 237);
            btnLeases.Margin = new Padding(3, 2, 3, 2);
            btnLeases.Name = "btnLeases";
            btnLeases.Size = new Size(184, 30);
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
            btnTenants.Location = new Point(9, 196);
            btnTenants.Margin = new Padding(3, 2, 3, 2);
            btnTenants.Name = "btnTenants";
            btnTenants.Size = new Size(184, 30);
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
            btnRentalUnits.Location = new Point(9, 156);
            btnRentalUnits.Margin = new Padding(3, 2, 3, 2);
            btnRentalUnits.Name = "btnRentalUnits";
            btnRentalUnits.Size = new Size(184, 30);
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
            btnProperties.Location = new Point(9, 116);
            btnProperties.Margin = new Padding(3, 2, 3, 2);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(184, 30);
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
            btnDashboard.Location = new Point(9, 75);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 30);
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
            lblLogo.Location = new Point(19, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(148, 32);
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
            pnlContent.Location = new Point(184, 0);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1015, 520);
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
            pnlSearch.Location = new Point(26, 146);
            pnlSearch.Margin = new Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(924, 38);
            pnlSearch.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(835, 8);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(82, 22);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(750, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "", "Active", "", "Inactive" });
            cmbFilter.Location = new Point(329, 8);
            cmbFilter.Margin = new Padding(3, 2, 3, 2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(97, 23);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Location = new Point(20, 9);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(294, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search properties";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = Color.DarkBlue;
            btnAddProperty.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProperty.ForeColor = Color.White;
            btnAddProperty.Location = new Point(805, 90);
            btnAddProperty.Margin = new Padding(3, 2, 3, 2);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(144, 34);
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
            lblPropertyCount.Location = new Point(16, 58);
            lblPropertyCount.Name = "lblPropertyCount";
            lblPropertyCount.Size = new Size(154, 21);
            lblPropertyCount.TabIndex = 1;
            lblPropertyCount.Text = "4 Properties in total";
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProperties.Location = new Point(16, 27);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(133, 32);
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
            dgvProperties.Location = new Point(26, 232);
            dgvProperties.Margin = new Padding(3, 2, 3, 2);
            dgvProperties.MultiSelect = false;
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RowHeadersWidth = 51;
            dgvProperties.Size = new Size(923, 308);
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
            pnlDashBoard.Location = new Point(198, 0);
            pnlDashBoard.Margin = new Padding(3, 2, 3, 2);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(1009, 578);
            pnlDashBoard.TabIndex = 2;
            // 
            // lblDashboardHeader
            // 
            lblDashboardHeader.AutoSize = true;
            lblDashboardHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardHeader.Location = new Point(31, 33);
            lblDashboardHeader.Name = "lblDashboardHeader";
            lblDashboardHeader.Size = new Size(157, 37);
            lblDashboardHeader.TabIndex = 0;
            lblDashboardHeader.Text = "Dashboard";
            // 
            // pnlLeases
            // 
            pnlLeases.Controls.Add(lblLeasesTopic);
            pnlLeases.Location = new Point(192, 0);
            pnlLeases.Margin = new Padding(3, 2, 3, 2);
            pnlLeases.Name = "pnlLeases";
            pnlLeases.Size = new Size(1014, 520);
            pnlLeases.TabIndex = 1;
            pnlLeases.Visible = false;
            // 
            // lblLeasesTopic
            // 
            lblLeasesTopic.AutoSize = true;
            lblLeasesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeasesTopic.Location = new Point(26, 38);
            lblLeasesTopic.Name = "lblLeasesTopic";
            lblLeasesTopic.Size = new Size(100, 37);
            lblLeasesTopic.TabIndex = 0;
            lblLeasesTopic.Text = "Leases";
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
            pnlRentPayments.Location = new Point(192, 0);
            pnlRentPayments.Margin = new Padding(3, 2, 3, 2);
            pnlRentPayments.Name = "pnlRentPayments";
            pnlRentPayments.Size = new Size(1014, 520);
            pnlRentPayments.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnGenerateReceipts);
            panel5.Controls.Add(cbxStatus);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(8, 207);
            panel5.Name = "panel5";
            panel5.Size = new Size(987, 60);
            panel5.TabIndex = 5;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.Location = new Point(857, 28);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(138, 30);
            btnRecordPayment.TabIndex = 4;
            btnRecordPayment.Text = "Record Payment";
            btnRecordPayment.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblExpectedRentDisplay);
            panel4.Controls.Add(lblExpectedRent);
            panel4.Location = new Point(6, 81);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 3;
            // 
            // lblExpectedRent
            // 
            lblExpectedRent.AutoSize = true;
            lblExpectedRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedRent.Location = new Point(6, 8);
            lblExpectedRent.Name = "lblExpectedRent";
            lblExpectedRent.Size = new Size(139, 25);
            lblExpectedRent.TabIndex = 0;
            lblExpectedRent.Text = "Expected Rent";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblOutstandingRentDisplay);
            panel2.Controls.Add(lblOutstandingRent);
            panel2.Location = new Point(534, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 2;
            // 
            // lblOutstandingRent
            // 
            lblOutstandingRent.AutoSize = true;
            lblOutstandingRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstandingRent.Location = new Point(3, 8);
            lblOutstandingRent.Name = "lblOutstandingRent";
            lblOutstandingRent.Size = new Size(169, 25);
            lblOutstandingRent.TabIndex = 2;
            lblOutstandingRent.Text = "Outstanding Rent";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLatePaymentDisplay);
            panel3.Controls.Add(lblLatePayment);
            panel3.Location = new Point(795, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 2;
            // 
            // lblLatePayment
            // 
            lblLatePayment.AutoSize = true;
            lblLatePayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLatePayment.Location = new Point(3, 8);
            lblLatePayment.Name = "lblLatePayment";
            lblLatePayment.Size = new Size(132, 25);
            lblLatePayment.TabIndex = 1;
            lblLatePayment.Text = "Late Payment";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCollectedRentDisplay);
            panel1.Controls.Add(lblCollectedRent);
            panel1.Location = new Point(267, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // lblCollectedRent
            // 
            lblCollectedRent.AutoSize = true;
            lblCollectedRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectedRent.Location = new Point(4, 8);
            lblCollectedRent.Name = "lblCollectedRent";
            lblCollectedRent.Size = new Size(140, 25);
            lblCollectedRent.TabIndex = 3;
            lblCollectedRent.Text = "Collected Rent";
            // 
            // lblRentTopic
            // 
            lblRentTopic.AutoSize = true;
            lblRentTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentTopic.Location = new Point(18, 40);
            lblRentTopic.Name = "lblRentTopic";
            lblRentTopic.Size = new Size(208, 37);
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
            pnlTenants.Location = new Point(192, 0);
            pnlTenants.Margin = new Padding(3, 2, 3, 2);
            pnlTenants.Name = "pnlTenants";
            pnlTenants.Size = new Size(1014, 549);
            pnlTenants.TabIndex = 17;
            // 
            // btnAddTenants
            // 
            btnAddTenants.BackColor = Color.DarkBlue;
            btnAddTenants.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTenants.ForeColor = Color.White;
            btnAddTenants.Location = new Point(774, 45);
            btnAddTenants.Margin = new Padding(3, 2, 3, 2);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(155, 35);
            btnAddTenants.TabIndex = 4;
            btnAddTenants.Text = "+Add Tenants";
            btnAddTenants.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tenants, Contact, Properties, Unit, Lease_Status, Outstanding, Action });
            dataGridView1.Location = new Point(508, 4);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Location = new Point(31, 224);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(335, 545);
            dataGridView1.Size = new Size(812, 325);
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
            lblRegisteredTenants.Location = new Point(18, 48);
            lblRegisteredTenants.Name = "lblRegisteredTenants";
            lblRegisteredTenants.Size = new Size(0, 15);
            lblRegisteredTenants.TabIndex = 1;
            // 
            // lblTenants
            // 
            lblTenants.AutoSize = true;
            lblTenants.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenants.Location = new Point(18, 15);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(102, 32);
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
            pnlFilterBar.Location = new Point(28, 118);
            pnlFilterBar.Margin = new Padding(3, 2, 3, 2);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(901, 49);
            pnlFilterBar.TabIndex = 2;
            // 
            // cmbStatuses
            // 
            cmbStatuses.FlatStyle = FlatStyle.System;
            cmbStatuses.FormattingEnabled = true;
            cmbStatuses.Items.AddRange(new object[] { "All Statuses", "Active", "Expiring Soon" });
            cmbStatuses.Location = new Point(582, 13);
            cmbStatuses.Margin = new Padding(3, 2, 3, 2);
            cmbStatuses.Name = "cmbStatuses";
            cmbStatuses.Size = new Size(133, 23);
            cmbStatuses.TabIndex = 2;
            // 
            // cmbProperties
            // 
            cmbProperties.FlatStyle = FlatStyle.System;
            cmbProperties.FormattingEnabled = true;
            cmbProperties.Location = new Point(419, 13);
            cmbProperties.Margin = new Padding(3, 2, 3, 2);
            cmbProperties.Name = "cmbProperties";
            cmbProperties.Size = new Size(133, 23);
            cmbProperties.TabIndex = 1;
            // 
            // txtSearchTenants
            // 
            txtSearchTenants.Location = new Point(30, 14);
            txtSearchTenants.Margin = new Padding(3, 2, 3, 2);
            txtSearchTenants.Name = "txtSearchTenants";
            txtSearchTenants.PlaceholderText = "Search Tenants...";
            txtSearchTenants.Size = new Size(266, 23);
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
            pnlRentalUnit.Location = new Point(202, 0);
            pnlRentalUnit.Margin = new Padding(3, 2, 3, 2);
            pnlRentalUnit.Name = "pnlRentalUnit";
            pnlRentalUnit.Size = new Size(1004, 520);
            pnlRentalUnit.TabIndex = 5;
            // 
            // pnlAvailability
            // 
            pnlAvailability.Controls.Add(lblAvailableNum);
            pnlAvailability.Controls.Add(lblAvailable);
            pnlAvailability.Location = new Point(287, 84);
            pnlAvailability.Margin = new Padding(3, 2, 3, 2);
            pnlAvailability.Name = "pnlAvailability";
            pnlAvailability.Size = new Size(219, 94);
            pnlAvailability.TabIndex = 3;
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(12, 35);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 15);
            lblAvailableNum.TabIndex = 2;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(3, 8);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(55, 15);
            lblAvailable.TabIndex = 0;
            lblAvailable.Text = "Available";
            // 
            // pnlOccupancy
            // 
            pnlOccupancy.Controls.Add(lblOccupiedNum);
            pnlOccupancy.Controls.Add(lblOccupied);
            pnlOccupancy.Location = new Point(541, 86);
            pnlOccupancy.Margin = new Padding(3, 2, 3, 2);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Size = new Size(219, 94);
            pnlOccupancy.TabIndex = 3;
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(22, 40);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 15);
            lblOccupiedNum.TabIndex = 3;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(3, 6);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(58, 15);
            lblOccupied.TabIndex = 1;
            lblOccupied.Text = "Occupied";
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.Controls.Add(lblTotalUnitsNum);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Location = new Point(32, 84);
            pnlTotalUnits.Margin = new Padding(3, 2, 3, 2);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(219, 94);
            pnlTotalUnits.TabIndex = 2;
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(25, 34);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 15);
            lblTotalUnitsNum.TabIndex = 1;
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Location = new Point(18, 8);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(62, 15);
            lblTotalUnits.Size = new Size(63, 15);
            lblTotalUnits.TabIndex = 0;
            lblTotalUnits.Text = "Total Units";
            // 
            // btnAddUnit
            // 
            btnAddUnit.BackColor = Color.RoyalBlue;
            btnAddUnit.FlatStyle = FlatStyle.Flat;
            btnAddUnit.ForeColor = Color.White;
            btnAddUnit.Location = new Point(515, 31);
            btnAddUnit.Margin = new Padding(3, 2, 3, 2);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(136, 36);
            btnAddUnit.TabIndex = 1;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.ForeColor = SystemColors.ActiveCaptionText;
            lblRentalUnit.Location = new Point(31, 33);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(161, 37);
            lblRentalUnit.TabIndex = 0;
            lblRentalUnit.Text = "Rental Unit";
            // 
            // pnlExpenses
            // 
            pnlExpenses.Controls.Add(lblExpensesTopic);
            pnlExpenses.Location = new Point(192, 0);
            pnlExpenses.Margin = new Padding(3, 2, 3, 2);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(1014, 520);
            pnlExpenses.TabIndex = 1;
            // 
            // lblExpensesTopic
            // 
            lblExpensesTopic.AutoSize = true;
            lblExpensesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpensesTopic.Location = new Point(17, 40);
            lblExpensesTopic.Name = "lblExpensesTopic";
            lblExpensesTopic.Size = new Size(133, 37);
            lblExpensesTopic.TabIndex = 0;
            lblExpensesTopic.Text = "Expenses";
            // 
            // pnlMaintenance
            // 
            pnlMaintenance.Controls.Add(lblMaintenanceTopic);
            pnlMaintenance.Location = new Point(192, 0);
            pnlMaintenance.Margin = new Padding(3, 2, 3, 2);
            pnlMaintenance.Name = "pnlMaintenance";
            pnlMaintenance.Size = new Size(1014, 520);
            pnlMaintenance.TabIndex = 1;
            // 
            // lblMaintenanceTopic
            // 
            lblMaintenanceTopic.AutoSize = true;
            lblMaintenanceTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintenanceTopic.Location = new Point(24, 28);
            lblMaintenanceTopic.Name = "lblMaintenanceTopic";
            lblMaintenanceTopic.Size = new Size(183, 37);
            lblMaintenanceTopic.TabIndex = 0;
            lblMaintenanceTopic.Text = "Maintenance";
            // 
            // lblLeasesTopic
            // 
            lblLeasesTopic.AutoSize = true;
            lblLeasesTopic.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeasesTopic.Location = new Point(26, 38);
            lblLeasesTopic.Name = "lblLeasesTopic";
            lblLeasesTopic.Size = new Size(100, 37);
            lblLeasesTopic.TabIndex = 0;
            lblLeasesTopic.Text = "Leases";
            // 
            // pnlActiveLeases
            // 
            pnlActiveLeases.Controls.Add(lblActiveLeaseNum);
            pnlActiveLeases.Controls.Add(lblActiveLeases);
            pnlActiveLeases.Location = new Point(21, 110);
            pnlActiveLeases.Name = "pnlActiveLeases";
            pnlActiveLeases.Size = new Size(181, 64);
            pnlActiveLeases.TabIndex = 1;
            // 
            // pnlExpiredLeases
            // 
            pnlExpiredLeases.Controls.Add(lblExpiredLeases);
            pnlExpiredLeases.Controls.Add(lblExpiredLeasesNum);
            pnlExpiredLeases.Location = new Point(208, 109);
            pnlExpiredLeases.Name = "pnlExpiredLeases";
            pnlExpiredLeases.Size = new Size(180, 65);
            pnlExpiredLeases.TabIndex = 2;
            // 
            // pnlTerminatedLeases
            // 
            pnlTerminatedLeases.Controls.Add(lblTerminatedLeases);
            pnlTerminatedLeases.Controls.Add(lblTerminatedLeasesNum);
            pnlTerminatedLeases.Location = new Point(393, 110);
            pnlTerminatedLeases.Name = "pnlTerminatedLeases";
            pnlTerminatedLeases.Size = new Size(180, 65);
            pnlTerminatedLeases.TabIndex = 3;
            // 
            // pnlSearchLeases
            // 
            pnlSearchLeases.Controls.Add(cmbAllStatus);
            pnlSearchLeases.Controls.Add(txtSearchLeases);
            pnlSearchLeases.Location = new Point(20, 187);
            pnlSearchLeases.Name = "pnlSearchLeases";
            pnlSearchLeases.Size = new Size(943, 58);
            pnlSearchLeases.TabIndex = 4;
            // 
            // txtSearchLeases
            // 
            txtSearchLeases.Location = new Point(19, 16);
            txtSearchLeases.Name = "txtSearchLeases";
            txtSearchLeases.Size = new Size(349, 23);
            txtSearchLeases.TabIndex = 0;
            // 
            // cmbAllStatus
            // 
            cmbAllStatus.FormattingEnabled = true;
            cmbAllStatus.Items.AddRange(new object[] { "Active", "Expired", "Terminated" });
            cmbAllStatus.Location = new Point(388, 19);
            cmbAllStatus.Name = "cmbAllStatus";
            cmbAllStatus.Size = new Size(295, 23);
            cmbAllStatus.TabIndex = 1;
            // 
            // dgvLeases
            // 
            dgvLeases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeases.Columns.AddRange(new DataGridViewColumn[] { LEASEID, TENANT, PROPERTY, NUNIT, STARTDATE, ENDDATE, MONTHLYRENT, LEASESTATUS, LEASEACTIONS });
            dgvLeases.Location = new Point(19, 249);
            dgvLeases.Name = "dgvLeases";
            dgvLeases.Size = new Size(944, 268);
            dgvLeases.TabIndex = 5;
            // 
            // LEASEACTIONS
            // 
            LEASEACTIONS.HeaderText = "LEASE ACTIONS";
            LEASEACTIONS.Name = "LEASEACTIONS";
            // 
            // LEASESTATUS
            // 
            LEASESTATUS.HeaderText = "LEASE STATUS";
            LEASESTATUS.Name = "LEASESTATUS";
            // 
            // MONTHLYRENT
            // 
            MONTHLYRENT.HeaderText = "MONTHLY RENT";
            MONTHLYRENT.Name = "MONTHLYRENT";
            // 
            // ENDDATE
            // 
            ENDDATE.HeaderText = "END DATE";
            ENDDATE.Name = "ENDDATE";
            // 
            // STARTDATE
            // 
            STARTDATE.HeaderText = "START DATE";
            STARTDATE.Name = "STARTDATE";
            // 
            // NUNIT
            // 
            NUNIT.HeaderText = "Unit";
            NUNIT.Name = "NUNIT";
            // 
            // PROPERTY
            // 
            PROPERTY.HeaderText = "PROPERTY";
            PROPERTY.Name = "PROPERTY";
            // 
            // TENANT
            // 
            TENANT.HeaderText = "TENANT";
            TENANT.Name = "TENANT";
            // 
            // LEASEID
            // 
            LEASEID.HeaderText = "LEASE ID";
            LEASEID.Name = "LEASEID";
            // 
            // btnCreateLease
            // 
            btnCreateLease.Location = new Point(849, 39);
            btnCreateLease.Name = "btnCreateLease";
            btnCreateLease.Size = new Size(114, 33);
            btnCreateLease.TabIndex = 6;
            btnCreateLease.Text = "+ Create Lease";
            btnCreateLease.UseVisualStyleBackColor = true;
            // 
            // pnlLeases
            // 
            pnlLeases.Controls.Add(btnCreateLease);
            pnlLeases.Controls.Add(dgvLeases);
            pnlLeases.Controls.Add(pnlSearchLeases);
            pnlLeases.Controls.Add(pnlTerminatedLeases);
            pnlLeases.Controls.Add(pnlExpiredLeases);
            pnlLeases.Controls.Add(pnlActiveLeases);
            pnlLeases.Controls.Add(lblLeasesTopic);
            pnlLeases.Location = new Point(192, 0);
            pnlLeases.Margin = new Padding(3, 2, 3, 2);
            pnlLeases.Name = "pnlLeases";
            pnlLeases.Size = new Size(1014, 520);
            pnlLeases.TabIndex = 1;
            pnlLeases.Visible = false;
            // 
            // lblActiveLeases
            // 
            lblActiveLeases.AutoSize = true;
            lblActiveLeases.Location = new Point(80, 25);
            lblActiveLeases.Name = "lblActiveLeases";
            lblActiveLeases.Size = new Size(77, 15);
            lblActiveLeases.TabIndex = 0;
            lblActiveLeases.Text = "Active Leases";
            // 
            // lblActiveLeaseNum
            // 
            lblActiveLeaseNum.AutoSize = true;
            lblActiveLeaseNum.Location = new Point(18, 24);
            lblActiveLeaseNum.Name = "lblActiveLeaseNum";
            lblActiveLeaseNum.Size = new Size(0, 15);
            lblActiveLeaseNum.TabIndex = 1;
            // 
            // lblExpiredLeasesNum
            // 
            lblExpiredLeasesNum.AutoSize = true;
            lblExpiredLeasesNum.Location = new Point(12, 25);
            lblExpiredLeasesNum.Name = "lblExpiredLeasesNum";
            lblExpiredLeasesNum.Size = new Size(0, 15);
            lblExpiredLeasesNum.TabIndex = 0;
            // 
            // lblExpiredLeases
            // 
            lblExpiredLeases.AutoSize = true;
            lblExpiredLeases.Location = new Point(87, 25);
            lblExpiredLeases.Name = "lblExpiredLeases";
            lblExpiredLeases.Size = new Size(83, 15);
            lblExpiredLeases.TabIndex = 1;
            lblExpiredLeases.Text = "Expired Leases";
            // 
            // lblTerminatedLeasesNum
            // 
            lblTerminatedLeasesNum.AutoSize = true;
            lblTerminatedLeasesNum.Location = new Point(17, 23);
            lblTerminatedLeasesNum.Name = "lblTerminatedLeasesNum";
            lblTerminatedLeasesNum.Size = new Size(0, 15);
            lblTerminatedLeasesNum.TabIndex = 0;
            // 
            // lblTerminatedLeases
            // 
            lblTerminatedLeases.AutoSize = true;
            lblTerminatedLeases.Location = new Point(71, 27);
            lblTerminatedLeases.Name = "lblTerminatedLeases";
            lblTerminatedLeases.Size = new Size(103, 15);
            lblTerminatedLeases.TabIndex = 1;
            lblTerminatedLeases.Text = "Terminated Leases";
            // 
            // lblExpectedRentDisplay
            // 
            lblExpectedRentDisplay.AutoSize = true;
            lblExpectedRentDisplay.Location = new Point(10, 48);
            lblExpectedRentDisplay.Name = "lblExpectedRentDisplay";
            lblExpectedRentDisplay.Size = new Size(0, 15);
            lblExpectedRentDisplay.TabIndex = 1;
            // 
            // lblLatePaymentDisplay
            // 
            lblLatePaymentDisplay.AutoSize = true;
            lblLatePaymentDisplay.Location = new Point(10, 48);
            lblLatePaymentDisplay.Name = "lblLatePaymentDisplay";
            lblLatePaymentDisplay.Size = new Size(0, 15);
            lblLatePaymentDisplay.TabIndex = 2;
            // 
            // lblOutstandingRentDisplay
            // 
            lblOutstandingRentDisplay.AutoSize = true;
            lblOutstandingRentDisplay.Location = new Point(3, 48);
            lblOutstandingRentDisplay.Name = "lblOutstandingRentDisplay";
            lblOutstandingRentDisplay.Size = new Size(0, 15);
            lblOutstandingRentDisplay.TabIndex = 3;
            // 
            // lblCollectedRentDisplay
            // 
            lblCollectedRentDisplay.AutoSize = true;
            lblCollectedRentDisplay.Location = new Point(4, 48);
            lblCollectedRentDisplay.Name = "lblCollectedRentDisplay";
            lblCollectedRentDisplay.Size = new Size(0, 15);
            lblCollectedRentDisplay.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 0;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Paid", "Outstanding", "Late" });
            cbxStatus.Location = new Point(282, 17);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 23);
            cbxStatus.TabIndex = 1;
            // 
            // btnGenerateReceipts
            // 
            btnGenerateReceipts.BackColor = SystemColors.ActiveBorder;
            btnGenerateReceipts.Location = new Point(433, 3);
            btnGenerateReceipts.Name = "btnGenerateReceipts";
            btnGenerateReceipts.Size = new Size(118, 54);
            btnGenerateReceipts.TabIndex = 2;
            btnGenerateReceipts.Text = "Generate Receipts";
            btnGenerateReceipts.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { TENANT, PROPERTY, UNITS, RENTDUE, AMOUNTPAID, OUTSTANDINGS, PAYMENTDATE, RECEIPTN0, STATUSES });
            dataGridView2.Location = new Point(10, 318);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(903, 150);
            dataGridView2.TabIndex = 6;
            // 
            // TENANT
            // 
            TENANT.HeaderText = "TENANT";
            TENANT.Name = "TENANT";
            // 
            // PROPERTY
            // 
            PROPERTY.HeaderText = "PROPERTY";
            PROPERTY.Name = "PROPERTY";
            // 
            // UNITS
            // 
            UNITS.HeaderText = "UNIT";
            UNITS.Name = "UNITS";
            // 
            // RENTDUE
            // 
            RENTDUE.HeaderText = "RENT DUE";
            RENTDUE.Name = "RENTDUE";
            // 
            // AMOUNTPAID
            // 
            AMOUNTPAID.HeaderText = "AMOUNT PAID";
            AMOUNTPAID.Name = "AMOUNTPAID";
            // 
            // OUTSTANDINGS
            // 
            OUTSTANDINGS.HeaderText = "OUTSTANDING";
            OUTSTANDINGS.Name = "OUTSTANDINGS";
            // 
            // PAYMENTDATE
            // 
            PAYMENTDATE.HeaderText = "PAYMENT DUE";
            PAYMENTDATE.Name = "PAYMENTDATE";
            // 
            // RECEIPTN0
            // 
            RECEIPTN0.HeaderText = "RECEIPT N0";
            RECEIPTN0.Name = "RECEIPTN0";
            // 
            // STATUSES
            // 
            STATUSES.HeaderText = "STATUS";
            STATUSES.Name = "STATUSES";
            // 
            // Properties_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 520);
            Controls.Add(pnlMainForm);
            Controls.Add(pnlRentPayments);
            Controls.Add(pnlExpenses);
            Controls.Add(pnlMaintenance);
            Margin = new Padding(3, 2, 3, 2);
            Controls.Add(pnlLeases);
            Controls.Add(pnlContent);
            Controls.Add(pnlTenants);
            Controls.Add(pnlRentalUnit);
            Controls.Add(pnlDashBoard);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ComboBox cmbAllStatus;
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
        private DataGridViewTextBoxColumn TENANT;
        private DataGridViewTextBoxColumn PROPERTY;
        private DataGridViewTextBoxColumn UNITS;
        private DataGridViewTextBoxColumn RENTDUE;
        private DataGridViewTextBoxColumn AMOUNTPAID;
        private DataGridViewTextBoxColumn OUTSTANDINGS;
        private DataGridViewTextBoxColumn PAYMENTDATE;
        private DataGridViewTextBoxColumn RECEIPTN0;
        private DataGridViewTextBoxColumn STATUSES;
    }
}