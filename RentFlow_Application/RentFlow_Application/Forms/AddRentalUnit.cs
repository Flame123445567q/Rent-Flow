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
    public partial class AddRentalUnit : Form
    {

        public RentalUnits? NewUnit { get; private set; }

        public AddRentalUnit()
        {
            InitializeComponent();
        }

        private void AddRentalUnit_Load(object sender, EventArgs e)
        {
            cmbAvailability.SelectedIndex = 0;
            cmbOccupancy.SelectedIndex = 0;
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitNumber.Text))
            {
                MessageBox.Show("Please enter the unit number");
                return;
            }

            if (!int.TryParse(txtPropertyID.Text, out int propertyID))
            {
                MessageBox.Show("Please enter a valid property ID");
                return;
            }

            if (!decimal.TryParse(txtRentalAmount.Text, out decimal rentalAmount))
            {
                MessageBox.Show("Please enter a valid rental amount");
                return;
            }

            if (rentalAmount < 0)
            {
                MessageBox.Show("Please enter a valid amount. Rental amount cannot be a negative amount");
                return;
            }

            RentalUnits unit = new RentalUnits();
            unit.SetUnitNumber(txtUnitNumber.Text);
            unit.SetPropertyID(propertyID);
            unit.SetRentalAmount(rentalAmount);
            unit.SetAvailability(cmbAvailability.Text);
            unit.SetOccupancy(cmbOccupancy.Text);

            NewUnit = unit;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClearUnit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
