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
            pnlFilterBar = new Panel();
            cmbStatuses = new ComboBox();
            cmbProperties = new ComboBox();
            txtSearchTenants = new TextBox();
            lblRegisteredTenants = new Label();
            lblTenants = new Label();
            pnlRentalUnit = new Panel();
            lblRentalUnit = new Label();
            btnAddUnit = new Button();
            pnlTotalUnits = new Panel();
            pnlAvailability = new Panel();
            pnlOccupancy = new Panel();
            lblTotalUnits = new Label();
            lblAvailable = new Label();
            lblOccupied = new Label();
            lblTotalUnitsNum = new Label();
            lblAvailableNum = new Label();
            lblOccupiedNum = new Label();
            pnlMainForm.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlSearch.SuspendLayout();
            pnlTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlFilterBar.SuspendLayout();
            pnlRentalUnit.SuspendLayout();
            pnlTotalUnits.SuspendLayout();
            pnlAvailability.SuspendLayout();
            pnlOccupancy.SuspendLayout();
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
            pnlContent.Location = new Point(260, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1119, 732);
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
            // pnlTenants
            // 
            pnlTenants.Controls.Add(btnAddTenants);
            pnlTenants.Controls.Add(dataGridView1);
            pnlTenants.Controls.Add(pnlFilterBar);
            pnlTenants.Controls.Add(lblRegisteredTenants);
            pnlTenants.Controls.Add(lblTenants);
            pnlTenants.Location = new Point(260, 0);
            pnlTenants.Name = "pnlTenants";
            pnlTenants.Size = new Size(1119, 732);
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
            // pnlRentalUnit
            // 
            pnlRentalUnit.Controls.Add(pnlAvailability);
            pnlRentalUnit.Controls.Add(pnlOccupancy);
            pnlRentalUnit.Controls.Add(pnlTotalUnits);
            pnlRentalUnit.Controls.Add(btnAddUnit);
            pnlRentalUnit.Controls.Add(lblRentalUnit);
            pnlRentalUnit.Location = new Point(260, 0);
            pnlRentalUnit.Name = "pnlRentalUnit";
            pnlRentalUnit.Size = new Size(1119, 732);
            pnlRentalUnit.TabIndex = 5;
            // 
            // lblRentalUnit
            // 
            lblRentalUnit.AutoSize = true;
            lblRentalUnit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalUnit.ForeColor = Color.RoyalBlue;
            lblRentalUnit.Location = new Point(35, 44);
            lblRentalUnit.Name = "lblRentalUnit";
            lblRentalUnit.Size = new Size(199, 46);
            lblRentalUnit.TabIndex = 0;
            lblRentalUnit.Text = "Rental Unit";
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
            btnAddUnit.Click += button2_Click;
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
            // pnlAvailability
            // 
            pnlAvailability.Controls.Add(lblAvailableNum);
            pnlAvailability.Controls.Add(lblAvailable);
            pnlAvailability.Location = new Point(328, 112);
            pnlAvailability.Name = "pnlAvailability";
            pnlAvailability.Size = new Size(250, 125);
            pnlAvailability.TabIndex = 3;
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
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Location = new Point(20, 10);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(79, 20);
            lblTotalUnits.TabIndex = 0;
            lblTotalUnits.Text = "Total Units";
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
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(3, 8);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(72, 20);
            lblOccupied.TabIndex = 1;
            lblOccupied.Text = "Occupied";
            // 
            // lblTotalUnitsNum
            // 
            lblTotalUnitsNum.AutoSize = true;
            lblTotalUnitsNum.Location = new Point(29, 45);
            lblTotalUnitsNum.Name = "lblTotalUnitsNum";
            lblTotalUnitsNum.Size = new Size(0, 20);
            lblTotalUnitsNum.TabIndex = 1;
            // 
            // lblAvailableNum
            // 
            lblAvailableNum.AutoSize = true;
            lblAvailableNum.Location = new Point(14, 47);
            lblAvailableNum.Name = "lblAvailableNum";
            lblAvailableNum.Size = new Size(0, 20);
            lblAvailableNum.TabIndex = 2;
            // 
            // lblOccupiedNum
            // 
            lblOccupiedNum.AutoSize = true;
            lblOccupiedNum.Location = new Point(25, 54);
            lblOccupiedNum.Name = "lblOccupiedNum";
            lblOccupiedNum.Size = new Size(0, 20);
            lblOccupiedNum.TabIndex = 3;
            // 
            // Properties_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 732);
            Controls.Add(pnlRentalUnit);
            Controls.Add(pnlTenants);
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
            pnlTenants.ResumeLayout(false);
            pnlTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlFilterBar.ResumeLayout(false);
            pnlFilterBar.PerformLayout();
            pnlRentalUnit.ResumeLayout(false);
            pnlRentalUnit.PerformLayout();
            pnlTotalUnits.ResumeLayout(false);
            pnlTotalUnits.PerformLayout();
            pnlAvailability.ResumeLayout(false);
            pnlAvailability.PerformLayout();
            pnlOccupancy.ResumeLayout(false);
            pnlOccupancy.PerformLayout();
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
    }
}