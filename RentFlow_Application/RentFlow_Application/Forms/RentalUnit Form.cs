using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.Design;

namespace RentFlow_Application.Forms
{
    public partial class RentalUnit_Form : Form
    {

        private List<RentalUnits> rentalUnits = new List<RentalUnits>();
        public RentalUnit_Form()
        {
            InitializeComponent();

        }
        private void RentalUnit_Form_Load(object sender, EventArgs e)
        {
            LoadSampleUnits();
            DisplayUnits();
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadSampleUnits()
        {
            RentalUnits unit1 = new RentalUnits();

            unit1.SetUnitID(1);
            unit1.SetPropertyID(100);
            unit1.SetUnitNumber("101");
            unit1.SetRentalAmount(8500);
            unit1.SetAvailability("Available");
            unit1.SetOccupancy("Occupied");

            rentalUnits.Add(unit1);


            RentalUnits unit2 = new RentalUnits();

            unit2.SetUnitID(2);
            unit2.SetPropertyID(100);
            unit2.SetUnitNumber("102");
            unit2.SetRentalAmount(8000);
            unit2.SetAvailability("Available");
            unit2.SetOccupancy("Vacant");

            rentalUnits.Add(unit2);


            RentalUnits unit3 = new RentalUnits();

            unit3.SetUnitID(3);
            unit3.SetPropertyID(200);
            unit3.SetUnitNumber("201");
            unit3.SetRentalAmount(9700);
            unit3.SetAvailability("Available");
            unit3.SetOccupancy("Occupied");

            rentalUnits.Add(unit3);


            RentalUnits unit4 = new RentalUnits();

            unit4.SetUnitID(4);
            unit4.SetPropertyID(200);
            unit4.SetUnitNumber("202");
            unit4.SetRentalAmount(9500);
            unit4.SetAvailability("Available");
            unit4.SetOccupancy("Vacant");

            rentalUnits.Add(unit4);


            RentalUnits unit5 = new RentalUnits();

            unit5.SetUnitID(5);
            unit5.SetPropertyID(200);
            unit5.SetUnitNumber("301");
            unit5.SetRentalAmount(9000);
            unit5.SetAvailability("Available");
            unit5.SetOccupancy("Vacant");

            rentalUnits.Add(unit5);
        }

        private void DisplayUnits()
        {
            dvgRentalUnits.Rows.Clear();

            foreach (RentalUnits unit in rentalUnits)
            {
                dvgRentalUnits.Rows.Add(unit.GetUnitID(),
                    unit.GetUnitNumber(),
                    unit.GetPropertyID(),
                    unit.GetRentalAmount().ToString("C2"),
                    unit.GetAvailability(),
                    unit.GetOccupancy()

                );
            }

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            int totalUnits = rentalUnits.Count;

            int availableUnits = rentalUnits.Count(
                unit => unit.GetAvailability() == "Available"
            );

            int occupiedUnits = rentalUnits.Count(
                unit => unit.GetOccupancy() == "Occupied"
            );

            lblTotalUnitsNum.Text = totalUnits.ToString();
            lblAvailableNum.Text = availableUnits.ToString();
            lblOccupiedNum.Text = occupiedUnits.ToString();
        }


        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            AddRentalUnit addForm = new AddRentalUnit();

            if(addForm.ShowDialog() == DialogResult.OK)
            {
                RentalUnits newUnit = addForm.NewUnit;
                newUnit.SetUnitID(GetNextUnitID());
                rentalUnits.Add(newUnit);

                DisplayUnits();
            }
        }

        private int GetNextUnitID()
        {
            if (rentalUnits.Count == 0)
            {
                return 1;
            }

            return rentalUnits.Max(unit => unit.GetUnitID()) + 1;
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dvgRentalUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a unit to edit");
                return;
            }

            int unitID = Convert.ToInt32(dvgRentalUnits.SelectedRows[0].Cells[0].Value);
            RentalUnits? selectedUnit = rentalUnits.FirstOrDefault(unit => unit.GetUnitID() == unitID);

            if (selectedUnit == null)
            {
                MessageBox.Show("Unit not found");
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterUnits();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterUnits();
        }

        private void FilterUnits()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string searchBy = cmbFilter.Text;

            dvgRentalUnits.Rows.Clear();

            foreach (RentalUnits unit in rentalUnits)
            {
                bool match = false;

                if (searchBy == "All")
                {
                    match = unit.GetOccupancy().ToLower().Contains(searchText) ||
                unit.GetPropertyID().ToString().Contains(searchText) ||
                unit.GetAvailability().ToLower().Contains(searchText);
               
                }
                else if (searchBy == "Unit Number")
                {
                    match = unit.GetUnitNumber().ToLower().Contains(searchText);
                }
                else if (searchBy == "Property")
                {
                    match = unit.GetPropertyID()
                                .ToString()
                                .Contains(searchText);
                }
                else if (searchBy == "Status")
                {
                    match =
                        unit.GetAvailability().ToLower().Contains(searchText) ||
                        unit.GetOccupancy().ToLower().Contains(searchText);
                }

                if (match)
                {
                    dvgRentalUnits.Rows.Add(unit.GetUnitID(), unit.GetUnitNumber(), unit.GetPropertyID(), unit.GetRentalAmount().ToString("C2"), unit.GetAvailability(), unit.GetOccupancy());
                }
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilter.SelectedIndex = 0;
            DisplayUnits();
        }
    }
}
