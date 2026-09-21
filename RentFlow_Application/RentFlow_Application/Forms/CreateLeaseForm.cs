using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RentFlow_Application.Forms
{
    public partial class CreateLeaseForm : Form
    {
        public CreateLeaseForm()
        {
            InitializeComponent();
        }

        private void CreateLeaseForm_Load(object sender, EventArgs e)
        {
            cmbTenant.DataSource = DataStore.Users
             .Where(u => u.Role == "Tenant")
            .Select(u => u.FullName + " " + u.Surname).ToList();



            cmbProperty.DataSource = null;
            cmbProperty.DataSource = DataStore.Properties
                .Select(p => p.GetPropertyName())
                .ToList();

            //cmbRentalUnit.DataSource = DataStore.RentalUnitslist
            // .Select(r => r.ToString()).ToList();




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // 1. Validate
            if (string.IsNullOrWhiteSpace(cmbTenant.Text))
            {
                MessageBox.Show("Select a tenant");
                return;
            }
            if (!decimal.TryParse(txtMonthlyRent.Text, out decimal rent))
            {
                MessageBox.Show("Enter a valid monthly rent, e.g. 8500");
                return;
            }

            // 2. Create lease object
            Lease newLease = new Lease
            {
                Tenant = cmbTenant.Text,
                Property = cmbProperty.Text,
                RentalUnit = cmbRentalUnit.Text,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value,
                MonthlyRent = rent,
                Status = cmbStatus.Text



            };

            // 3. Add to memory + save to file
            DataStore.theLeases.Add(newLease);
            DataStore.SaveLeases();
            File.AppendAllText("Leases.txt",
            $"{newLease.Tenant},{newLease.Property},{newLease.RentalUnit},{newLease.StartDate},{newLease.EndDate},{newLease.MonthlyRent},{newLease.Status}{Environment.NewLine}");

            MessageBox.Show("Lease created!");
            this.Close(); // close the popup

            

        }    
    }











}
    

