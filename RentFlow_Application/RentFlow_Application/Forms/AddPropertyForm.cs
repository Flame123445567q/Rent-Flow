using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Drawing.Text;
namespace RentFlow_Application.Forms
{
    public partial class AddPropertyForm : Form
    {
        public AddPropertyForm()
        {
            InitializeComponent();
        }

        private void lblTenant_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveProperty_Click(object sender, EventArgs e)
        {
            string propertyName = txtPropName.Text.Trim();
            string streetAddress = txtStreetAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();

            //Check if any field is empty
            if (propertyName == "")
            {
                MessageBox.Show("Please enter the property name.");
                return;
            }

            if (streetAddress == "")
            {
                MessageBox.Show("Please enter the street address.");
                return;
            }

            if (city == "")
            {
                MessageBox.Show("Please enter the city.");
                return;
            }

            if (province == "")
            {
                MessageBox.Show("Please enter the province.");
                return;
            }

            if (postalCode == "")
            {
                MessageBox.Show("Please enter the postal code.");
                return;
            }
            MessageBox.Show("Property saved successfully!");


            txtPropertyName.Clear();
            txtStreetAddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();

            txtPropertyName.Focus();

            string profile = $"Property name: {propertyName}" + Environment.NewLine +
                             $"City: {city}" + Environment.NewLine +
                             $"Province: {province}" + Environment.NewLine +
                             $"Postal Code: {postalCode}" + Environment.NewLine;



            File.AppendAllText(profile, "property.txt" + Environment.NewLine);

            MessageBox.Show("Property saved Successfully");

            this.Close();



        }

        private void AddPropertyForm_Load(object sender, EventArgs e)
        {

        }
    }

}
