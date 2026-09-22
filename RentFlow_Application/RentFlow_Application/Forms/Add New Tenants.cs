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
    public partial class Add_New_Tenants : Form
    {
        // Caller should set this before showing the form so saved tenant gets a unique ID
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int NextTenantID { get; set; } = 0;

        public Add_New_Tenants()
        {
            InitializeComponent();
            // wire up the save button handler from code in case designer didn't
            btnSaveTenant.Click += btnSaveTenant_Click_1;
            // Populate Assigned Property combobox from Properties.txt in app folder
            try
            {
                string propsPath = Path.Combine(Application.StartupPath, "Properties.txt");
                if (File.Exists(propsPath))
                {
                    cmbAssignedProperty.Items.Clear();
                    string[] lines = File.ReadAllLines(propsPath);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            cmbAssignedProperty.Items.Add(line.Trim());
                    }
                }
            }
            catch
            {
                // ignore errors loading properties file
            }
        }

        private void btnSaveTenant_Click_1(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the tenant's first and last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIDNumber.Text))
            {
                errorProvider1.SetError(txtIDNumber, "ID Number is required");
                return;
            }
            else if (txtIDNumber.Text.Length != 13)
            {
                errorProvider1.SetError(txtIDNumber, "ID Number must be 13 Digits");
                return;
            }
            
                foreach (char ID in txtIDNumber.Text)
                {
                    if (!char.IsDigit(ID))
                    {
                        errorProvider1.SetError(txtIDNumber, "ID Number must be Numbers");
                        return;
                       
                    }
                }
            if (cmbAssignedProperty.SelectedIndex == -1)
            {
                MessageBox.Show("Assign Property to Tenant", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbAssignedUnit.SelectedIndex==-1)
            {
                MessageBox.Show("Assign a Unit to Tenant", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // default lease status and outstanding
            string leaseStatus = "Active";
            string outstanding = "R5000";

            // Prepare tenant record and persist
            try
            {
                string filePath = "Tenants.txt";
                // ensure unique id provided by caller

                string first = txtFirstName.Text.Trim();
                string last = txtLastName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                string email = txtEmailAddress.Text.Trim();
                string idnum = txtIDNumber.Text.Trim();
                string property = cmbAssignedProperty.Text;
                string unit = cmbAssignedUnit.Text;
                string fullName = first + " " + last;
                // write as space-separated values (no spaces inside values)
                

                string line = fullName + "|" + phone + "|" + email + "|" + idnum + "|" + property + "|" + unit + "|" + leaseStatus + "|" + outstanding;
                File.AppendAllText(filePath,line + Environment.NewLine);

                MessageBox.Show("Tenant saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // signal caller to reload tenants and close
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save tenant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
