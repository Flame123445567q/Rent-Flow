using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RentFlow_Application.Forms
{
    public partial class Properties_Form : Form
    {



        private List<Property> properties = new List<Property>();
        private List<Tenant> tenants = new List<Tenant>();
        private int nextPropertyID = 1;
        private int nextTenantID = 1;
        public Properties_Form()
        {
            InitializeComponent();
            //Property property1 = new Property();
            //property1.SetAddress("Durban");
            //property1.SetPropertyType("Apartment");
            //property1.SetRentalAmount(8500);
            //property1.SetStatus("Active");

            //Property property2 = new Property();
            //property2.SetPropertyID(2);
            //property2.SetPropertyName("Green Valley");
            //property2.SetAddress("Johannesburg");
            //property2.SetPropertyType("House");
            //property2.SetRentalAmount(12000);
            //property2.SetStatus("Active");

            //Property property3 = new Property();
            //property3.SetPropertyID(3);
            //property3.SetPropertyName("Ocean View");
            //property3.SetAddress("Cape Town");
            //property3.SetPropertyType("Apartment");
            //property3.SetRentalAmount(9500);
            //property3.SetStatus("Inactive");

            //properties.Add(property1);
            //properties.Add(property2);
            //properties.Add(property3);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {

            AddPropertyForm frm = new AddPropertyForm();
            // provide unique ID to the add form
            frm.NextPropertyID = nextPropertyID;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // reload properties from file and refresh views
                properties.Clear();
                LoadProperties();
                UpdateGrid();
                UpdateStatistics();
                return;
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.ToLower();

            dgvProperties.Rows.Clear();

            foreach (Property property in properties)
            {
                if (property.GetPropertyName().ToLower().Contains(searchText) ||
                    property.GetAddress().ToLower().Contains(searchText) ||
                    property.GetPropertyType().ToLower().Contains(searchText))
                {
                    dgvProperties.Rows.Add(
                        property.GetPropertyID(),
                        property.GetPropertyName(),
                        property.GetAddress(),
                        property.GetPropertyType(),
                        property.GetRentalAmount().ToString("C"),
                        property.GetStatus());
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilter.Text;

            dgvProperties.Rows.Clear();

            foreach (Property property in properties)
            {
                if (selectedStatus == "All" ||
                    property.GetStatus() == selectedStatus)
                {
                    dgvProperties.Rows.Add(
                        property.GetPropertyID(),
                        property.GetPropertyName(),
                        property.GetAddress(),
                        property.GetPropertyType(),
                        property.GetRentalAmount().ToString("C"),
                        property.GetStatus()
                    );
                }
            }
        }

        private void Properties_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // Ensure panels dock and only the dashboard shows initially
            SetupContentPanels();

            UpdateGrid();
            UpdateStatistics();
            LoadProperties();
            // load tenants into tenant grid

            DataStore.LoadTenants();
            UpdateTenantsGrid();

            // show dashboard by default
            ShowPanel(pnlDashBoard);

            DataStore.LoadLeases();
            RefreshLeaseGrid();

            DataStore.LoadExpenses();
            RefreshExpensesGrid();

            dgvAddTenants.AutoGenerateColumns = false;
            RefreshTenantsGrid();

            cmbProperties.DataSource = null;
            cmbProperties.DataSource = DataStore.Properties
                .Select(p => p.GetPropertyName())
                .ToList();

            


            _lastCount = DataStore.theMaintenance.Count;

        }

        // configure content panels so they fill the remaining area to the right of the left nav
        private void SetupContentPanels()
        {
            try
            {
                // The left navigation (pnlMainForm) remains DockStyle.Left from designer
                // Make the content panels fill the rest of the form and start hidden
                foreach (var panel in new[] { pnlContent, pnlDashBoard, pnlTenants, pnlRentalUnit, pnlLeases, pnlRentPayments, pnlExpenses, pnlMaintenance })
                {
                    if (panel != null)
                    {
                        panel.Dock = DockStyle.Fill;
                        panel.Visible = false;
                    }
                }
            }
            catch { }
        }

        // Show only the specified panel and hide the others
        private void ShowPanel(Panel toShow)
        {
            try
            {
                var panels = new[] { pnlContent, pnlDashBoard, pnlTenants, pnlRentalUnit, pnlLeases, pnlRentPayments, pnlExpenses, pnlMaintenance };
                foreach (var p in panels)
                {
                    if (p == null) continue;
                    p.Visible = (p == toShow);
                    if (p.Visible)
                    {
                        p.BringToFront();
                    }
                }
            }
            catch { }
        }

        private void btnAddTenants_Click(object sender, EventArgs e)
        {
            // show add-tenant dialog and reload tenants if saved
            // Patch placeholder: no functional change
            Add_New_Tenants frm = new Add_New_Tenants();
            frm.NextTenantID = nextTenantID;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                tenants.Clear();
                LoadTenants();
                UpdateTenantsGrid();
                return;
            }
        }

        private void LoadTenants()
        {
            string filePath = Path.Combine(Application.StartupPath ?? ".", "Tenants.txt");

            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split();
                // expected: id first last phone email idnumber property unit
                if (data.Length >= 8)
                {
                    Tenant t = new Tenant();
                    t.SetTenantID(Convert.ToInt32(data[0]));
                    t.SetFirstName(data[1]);
                    t.SetLastName(data[2]);
                    t.SetPhoneNumber(data[3]);
                    t.SetEmailAddress(data[4]);
                    t.SetIDNumber(data[5]);
                    t.SetAssignedProperty(data[6]);
                    t.SetAssignedUnit(data[7]);

                    tenants.Add(t);

                    if (t.GetTenantID() >= nextTenantID)
                        nextTenantID = t.GetTenantID() + 1;
                }
            }
        }

        private void UpdateTenantsGrid()
        {
            if (dgvAddTenants == null)
                return;

            dgvAddTenants.Rows.Clear();

            foreach (Tenant t in tenants)
            {
                dgvAddTenants.Rows.Add(
                    t.GetFirstName() + " " + t.GetLastName(),
                    t.GetPhoneNumber(),
                    t.GetAssignedProperty(),
                    t.GetAssignedUnit(),
                    "", // Lease status placeholder
                    ""  // Outstanding placeholder
                );
            }
        }

        private void LoadProperties()
        {
            string filePath = "Properties.txt";

            if (!File.Exists(filePath))
            {
                return;
            }
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] data = line.Split();

                if (data.Length == 6)
                {
                    Property property = new Property();

                    property.SetPropertyID(Convert.ToInt32(data[0]));
                    // ensure nextPropertyID tracks the max seen id
                    property.SetPropertyName(data[1]);
                    property.SetAddress(data[2]);
                    property.SetPropertyType(data[3]);
                    property.SetRentalAmount(Convert.ToDecimal(data[4]));
                    property.SetStatus(data[5]);

                    properties.Add(property);


                    if (property.GetPropertyID() >= nextPropertyID)
                    {
                        nextPropertyID = property.GetPropertyID() + 1;
                    }




                }
            }

        }



        private void UpdateGrid()
        {
            dgvProperties.Rows.Clear();

            foreach (Property property in properties)
            {
                dgvProperties.Rows.Add(
                    property.GetPropertyID(),
                    property.GetPropertyName(),
                    property.GetAddress(),
                    property.GetPropertyType(),
                    property.GetRentalAmount().ToString("C"),
                    property.GetStatus()
                );
            }
        }
        private void UpdateStatistics()
        {
            int totalProperties = properties.Count;

            int activeProperties = properties.Count(p =>
                p.GetStatus() == "Active");

            int inactiveProperties = properties.Count(p =>
                p.GetStatus() == "Inactive");


            lblPropertyCount.Text =
                properties.Count + " properties";
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlContent);
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTenants);
        }

        private void btnRentalUnits_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlRentalUnit);
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            AddRentalUnit frm = new AddRentalUnit();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDashBoard ?? pnlContent);
        }

        private void lblLogoIcon_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm cover = new LoginForm();

                cover.Show();
                this.Close();

            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pnlLeases_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLeases_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlLeases);
            RefreshLeaseGrid();
        }

        private void btnRentPayments_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlRentPayments);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlExpenses);

            dgvExpensesRecords.AutoGenerateColumns = false;

            DataStore.LoadAll(); // reloads maintenance.txt

            // Show the SAME maintenance requests in expenses grid
            dgvExpensesRecords.DataSource = null;
            dgvExpensesRecords.DataSource = DataStore.theMaintenance;

            _lastCount = DataStore.theMaintenance.Count; // stop popup repeating

            LoadExpensesGrid();



        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            DataStore.LoadAll();
            ShowPanel(pnlMaintenance);
            LoadMaintenanceRequests();
            _lastCount = DataStore.theMaintenance.Count;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateLease_Click(object sender, EventArgs e)
        {
            CreateLeaseForm form = new CreateLeaseForm();
            form.ShowDialog();
            RefreshLeaseGrid();





        }

        private void btnAddTenants_Click_1(object sender, EventArgs e)
        {
            Add_New_Tenants tenant = new Add_New_Tenants();

            tenant.ShowDialog();


            RefreshTenantsGrid();
        }

        private void RefreshLeaseGrid()
        {
            dgvLeases.AutoGenerateColumns = true;



            dgvLeases.Columns[0].DataPropertyName = "Tenant";
            dgvLeases.Columns[1].DataPropertyName = "Property";
            dgvLeases.Columns[2].DataPropertyName = "RentalUnit";
            dgvLeases.Columns[3].DataPropertyName = "StartDate";
            dgvLeases.Columns[4].DataPropertyName = "EndDate";
            dgvLeases.Columns[5].DataPropertyName = "MonthlyRent";
            dgvLeases.Columns[6].DataPropertyName = "Status";

            dgvLeases.DataSource = null;


            dgvLeases.DataSource = DataStore.theLeases;


            lblTotalLeases.Text = DataStore.theLeases.Count.ToString();
            lblTotalActiveLeases.Text = DataStore.theLeases.Count(l => l.Status == "Active").ToString();
            lblTotalExpiredLeases.Text = DataStore.theLeases.Count(l => l.Status == "Expired").ToString();
            lblTotalTeminatedLeases.Text = DataStore.theLeases.Count(l => l.Status == "Terminated").ToString();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpense expense = new AddExpense();
            expense.ShowDialog();
            RefreshExpensesGrid();

            
        }

        private void LoadMaintenanceRequests()
        {
            dgvExpensesRecords.DataSource = null;
            dgvExpensesRecords.DataSource = DataStore.theMaintenance.ToList();
        }
        private int _lastCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //DataStore.theMaintenance.Add(new MaintenanceRequest { Issue = "Leaking tap", Status = "Pending", TenantName = "Test", DateReported = DateTime.Now });
            //LoadMaintenanceRequests();
           
            DataStore.LoadAll();

            int currentCount = DataStore.theMaintenance.Count;

            if (currentCount > _lastCount)
            {
                // Only show when NEW request arrives
                _lastCount = currentCount;
                var latest = DataStore.theMaintenance.Last();

                MessageBox.Show(
                    $"New maintenance request!\n\nNow you can add expense.\n\nTenant: {latest.TenantName}\nIssue: {latest.Issue}",
                    "Maintenance Request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadMaintenanceRequests();
            }

          

        }

        private void LoadExpensesGrid()
        {
            dgvExpensesRecords.Columns.Clear();
            dgvExpensesRecords.AutoGenerateColumns = true;
            dgvExpensesRecords.DataSource = null;
            dgvExpensesRecords.DataSource = DataStore.theExpenses.ToList();

            UpdateExpenseCounts();
        }

        private void RefreshExpensesGrid()
        {
            LoadExpensesGrid();
        }

        private void UpdateExpenseCounts()
        {
            lblTotalMaintenance.Text = DataStore.theExpenses.Count(e => e.Category == "Maintenance").ToString();
            lblTotalInsurance.Text = DataStore.theExpenses.Count(e => e.Category == "Insurance").ToString();
            lblTotalSecurity.Text = DataStore.theExpenses.Count(e => e.Category == "Security").ToString();
            lblTotalUtilities.Text = DataStore.theExpenses.Count(e => e.Category == "Utilities").ToString();
        }

        public void RefreshTenantsGrid()
        {
            dgvAddTenants.Rows.Clear();

            foreach (var t in DataStore.TenantsList)
            {
                dgvAddTenants.Rows.Add(
                    t.GetFirstName() + " " + t.GetLastName(), // Tenants column
                    t.GetPhoneNumber(),                         // Contact column
                    t.GetAssignedProperty(),                    // Properties column
                    t.GetAssignedUnit(),                        // Unit column
                    "Active",                                   // Lease_Status column
                    "R0",                                       // Outstanding column
                    "Edit | Delete"                             // Action column
                );
       }    }
    }
}