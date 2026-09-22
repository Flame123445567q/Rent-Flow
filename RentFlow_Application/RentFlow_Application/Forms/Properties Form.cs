using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
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
            LoadMaintenanceGrid();
            LoadProperties();
            LoadTenants();

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
                        property.GetRentalAmount().ToString(),
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
            // Ensure panels dock and only the dashboard shows initially
            SetupContentPanels();

            UpdateGrid();
            UpdateStatistics();
            LoadProperties();
            LoadMaintenanceGrid();
            // load tenants into tenant grid
            LoadTenants();
            //UpdateTenantsGrid();
            // show dashboard by default
            ShowPanel(pnlDashBoard);
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

       

        private void LoadTenants()
        {
            dgvTenants.Rows.Clear();
            tenants.Clear();

            string filePath = "Tenants.txt";

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

                string[] parts = line.Split('|');

                if (parts.Length < 8)
                {
                    continue;
                }

                string fullName = parts[0];   // "Kea Maya"
                string phone = parts[1];
                string email = parts[2];
                string idnum = parts[3];
                string property = parts[4];
                string unit = parts[5];
                string status = parts[6];
                string outstanding = parts[7];

                // split the full name into first + last (for the Tenant class)
                string[] nameParts = fullName.Split(' ');
                string first = nameParts[0];
                string last = nameParts.Length > 1 ? nameParts[1] : "";

                Tenant t = new Tenant();
                t.SetFirstName(first);
                t.SetLastName(last);
                t.SetPhoneNumber(phone);
                t.SetEmailAddress(email);
                t.SetIDNumber(idnum);
                t.SetAssignedProperty(property);
                t.SetAssignedUnit(unit);
                t.SetLeaseStatus(status);
                t.SetOutstanding(outstanding);

                tenants.Add(t);

                // ADD THE ROW TO THE GRID
                dgvTenants.Rows.Add(
                    fullName,
                    phone,
                    property,
                    unit,
                    status,
                    outstanding
                );
            }

            lblTenatsCount.Text = tenants.Count + " Registered Tenants";
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
                    property.GetRentalAmount().ToString(),
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
        }

        private void btnRentPayments_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlRentPayments);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlExpenses);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMaintenance);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a Request to Edit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EditMaintenanceRequest form = new EditMaintenanceRequest();
            form.ShowDialog();
            LoadMaintenanceGrid();
        }

        private void dgvMaintenanceRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMaintenanceGrid()
        {
            dgvMaintenanceRecords.Rows.Clear();

            if (!File.Exists("maintenance.txt")) return;

            int open = 0, pending = 0, resolved = 0;

            foreach (string line in File.ReadAllLines("maintenance.txt"))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length < 8)
                {
                    continue;
                }

                if (parts[6] == "Open")
                {
                    open++;
                }

                else if (parts[6] == "Pending") 
                {
                    pending++;
                } 
                else if (parts[6] == "Resolved")
                {
                    resolved++;
                }
                dgvMaintenanceRecords.Rows.Add(
                    parts[0],   // RequestId
                    parts[1],   // TenantName
                    parts[2],   // PropertyUnit
                    parts[3],   // Category
                    parts[5],   // Priority
                    parts[6],   // Status
                    parts[7]    // Date
                );
            }

            lblOpen.Text = open.ToString();
            lblPending.Text = pending.ToString();
            lblResolved.Text = resolved.ToString();
        }
        private void btnAddTenants_Click_1(object sender, EventArgs e)
        {
            Add_New_Tenants form = new Add_New_Tenants();
            form.ShowDialog();
            tenants.Clear();
            LoadTenants();
        }

        private void pnlMaintenance_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}