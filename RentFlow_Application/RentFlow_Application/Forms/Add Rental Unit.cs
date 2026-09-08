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
        // Ensure the combo box exists if designer field is missing
        private ComboBox cmbAvailabilityStatus;

        public AddRentalUnit()
        {
            InitializeComponent();

            // If the designer did not create cmbAvailabilityStatus, create a minimal one so code compiles.
            if (cmbAvailabilityStatus == null)
            {
                cmbAvailabilityStatus = new ComboBox();
                cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
                // Place it out of the way; designer should normally position controls.
                cmbAvailabilityStatus.Location = new Point(10, 10);
                this.Controls.Add(cmbAvailabilityStatus);
            }
        }

        private void AddRentalUnit_Load(object sender, EventArgs e)
        {
            // Ensure there is at least one item before setting SelectedIndex to avoid runtime error
            if (cmbAvailabilityStatus.Items.Count > 0)
            {
                cmbAvailabilityStatus.SelectedIndex = 0;
            }

        }

        private void btnSaveUnits_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitNumber.Text))

            {
                MessageBox.Show("Please Enter a Unit Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!decimal.TryParse(txtRentalAmount.Text, out decimal rentalAmount))
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
            if (cmbAvailability != null)
            {
                cmbAvailability.Items.Add(unit);
            }
            else
            {
                cmbAvailabilityStatus.Items.Add(unit);
            }

            NewUnit = unit;

            DialogResult = DialogResult.OK;

            Close();


            string rentalUnit = $"Property Id: { (txtPropertyID != null ? txtPropertyID.Text : string.Empty) }" + Environment.NewLine +
                                $"Rental Amount: {rentalAmount}" + Environment.NewLine;

            // Append to a file named rental.txt in the app folder
            File.AppendAllText("rental.txt", rentalUnit);

            MessageBox.Show("Rental Unit Added Successfully", "Saving Untis", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            // Designer expects btnSaveUnit_Click; forward to existing handler if present.
            try
            {
                btnSaveUnits_Click(sender, e);
            }
            catch (Exception)
            {
                // If the original method is missing, do nothing to avoid crashing the designer.
            }
        }

        private void btnClearUnit_Click(object sender, EventArgs e)
        {
            // Clear the form fields that exist in the designer file.
            if (txtUnitNumber != null) txtUnitNumber.Text = string.Empty;
            if (txtPropertyID != null) txtPropertyID.Text = string.Empty;
            if (txtRentalAmount != null) txtRentalAmount.Text = string.Empty;
            if (cmbAvailability != null) cmbAvailability.SelectedIndex = -1;
            if (cmbOccupancy != null) cmbOccupancy.SelectedIndex = -1;
        }

    }    

}
