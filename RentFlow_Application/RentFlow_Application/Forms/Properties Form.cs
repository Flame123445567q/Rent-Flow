using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class Properties_Form : Form
    {
        private List<Property> properties = new List<Property>();
        private int nextPropertyID = 1;
        public Properties_Form()
        {
            InitializeComponent();
            Property property1 = new Property();
            property1.SetAddress("Durban");
            property1.SetPropertyType("Apartment");
            property1.SetRentalAmount(8500);
            property1.SetStatus("Active");

            Property property2 = new Property();
            property2.SetPropertyID(2);
            property2.SetPropertyName("Green Valley");
            property2.SetAddress("Johannesburg");
            property2.SetPropertyType("House");
            property2.SetRentalAmount(12000);
            property2.SetStatus("Active");

            Property property3 = new Property();
            property3.SetPropertyID(3);
            property3.SetPropertyName("Ocean View");
            property3.SetAddress("Cape Town");
            property3.SetPropertyType("Apartment");
            property3.SetRentalAmount(9500);
            property3.SetStatus("Inactive");

            properties.Add(property1);
            properties.Add(property2);
            properties.Add(property3);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            string propertyName = Microsoft.VisualBasic.Interaction.InputBox("Enter property name:", "Add Property");

            if (propertyName == "")
            {
                return;
            }

            string address = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter property address:",
                "Add Property");

            if (address == "")
            {
                return;
            }

            string propertyType = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter property type:",
                "Add Property");

            if (propertyType == "")
            {
                return;
            }

            string rentalText = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter rental amount:",
                "Add Property");

            decimal rentalAmount;

            if (!decimal.TryParse(rentalText, out rentalAmount))
            {
                MessageBox.Show("Please enter a valid rental amount.");
                return;
            }

            Property property = new Property();

            property.SetPropertyID(nextPropertyID);
            property.SetPropertyName(propertyName);
            property.SetAddress(address);
            property.SetPropertyType(propertyType);
            property.SetRentalAmount(rentalAmount);
            property.SetStatus("Active");

            properties.Add(property);

            nextPropertyID++;

            UpdateGrid();
            UpdateStatistics();

            MessageBox.Show("Property added successfully.");
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
            UpdateGrid();
            UpdateStatistics();
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
            pnlContent.BringToFront();

            btnProperties.BackColor = Color.White;
            btnProperties.BackColor = Color.Black;


        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            pnlTenants.BringToFront();

            btnTenants.BackColor = Color.White;
            btnTenants.BackColor = Color.Black;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}