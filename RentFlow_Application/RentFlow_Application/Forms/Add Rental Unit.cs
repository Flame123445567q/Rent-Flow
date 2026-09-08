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
    public partial class AddRentalUnit : Form

    {
        public RentalUnits? NewUnit { get; private set; }
        public AddRentalUnit()
        {
            InitializeComponent();
        }

        private void AddRentalUnit_Load(object sender, EventArgs e)
        {
            cmbAvailabilityStatus.SelectedIndex = 0;
            cmbAvailabilityStatus.SelectedIndex = 0;

        }

        private void btnSaveUnits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitNumber.Text))

            {
                MessageBox.Show("Please Enter a Unit Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!decimal.TryParse(txtMonthlyRent.Text, out decimal rentalAmount))
            {
                MessageBox.Show("Please enter the valid rental amount", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rentalAmount < 5000 && rentalAmount > 5000)
            {
                MessageBox.Show("rental Anmonut must exacly 5000");
            }

            RentalUnits unit = new RentalUnits();
            unit.SetUnitNumber(txtUnitNumber.Text);
            unit.SetRentalAmount(rentalAmount);
            cmbAvailabilityStatus.Items.Add(unit);

            NewUnit = unit;

            DialogResult = DialogResult.OK;

            Close();


            string rentalUnit = $"Prperty Id: {propertyID}" + Environment.NewLine +
                                $"Rental Amount: {rentalAmount}" + Environment.NewLine;

            File.AppendAllText(rentalUnit, "rental.txt");

            MessageBox.Show("Rental Unit Added Successfully", "Saving Untis", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }    

}
