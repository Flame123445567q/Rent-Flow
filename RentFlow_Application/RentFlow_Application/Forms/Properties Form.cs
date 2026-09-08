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
        private int nextPropertyID = 1;
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

            UpdateGrid();
            UpdateStatistics();

            AddPropertyForm frm = new AddPropertyForm();
            frm.ShowDialog();


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
            LoadProperties();


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
                    property.SetPropertyName(data[1]);
                    property.SetAddress(data[2]);
                    property.SetPropertyType(data[3]);
                    property.SetRentalAmount(Convert.ToDecimal(data[4]));
                    property.SetStatus(data[5]);

                    properties.Add(property);
                   

                    if(property.GetPropertyID() >= nextPropertyID)
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
            pnlContent.BringToFront();
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            pnlTenants.BringToFront();
        }

        private void btnRentalUnits_Click(object sender, EventArgs e)
        {
            pnlRentalUnits.BringToFront();
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
            pnlDashBoard.BringToFront();
        }

      
    }
}