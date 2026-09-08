using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class Add_New_Tenants : Form
    {
        // Caller should set this before showing the form so saved tenant gets a unique ID
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int NextTenantID { get; set; } = 0;

        public Add_New_Tenants()
        {
            InitializeComponent();
            // wire up the save button handler from code in case designer didn't
            btnSaveTenant.Click += btnSaveTenant_Click;
        }

        private void btnSaveTenant_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the tenant's first and last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string first = txtFirstName.Text.Trim().Replace(' ', '_');
            string last = txtLastName.Text.Trim().Replace(' ', '_');
            string phone = (txtPhoneNumber != null ? txtPhoneNumber.Text.Trim().Replace(' ', '_') : string.Empty);
            string email = (txtEmailAddress != null ? txtEmailAddress.Text.Trim().Replace(' ', '_') : string.Empty);
            string idnum = (txtIDNumber != null ? txtIDNumber.Text.Trim().Replace(' ', '_') : string.Empty);
            string property = (cmbAssignedProperty != null && cmbAssignedProperty.Text != null ? cmbAssignedProperty.Text.Trim().Replace(' ', '_') : string.Empty);
            string unit = (cmbAssignedUnit != null && cmbAssignedUnit.Text != null ? cmbAssignedUnit.Text.Trim().Replace(' ', '_') : string.Empty);

            string idToken = (NextTenantID > 0) ? NextTenantID.ToString() : "0";
            string line = string.Join(' ', new string[] { idToken, first, last, phone, email, idnum, property, unit });

            try
            {
                File.AppendAllText("Tenants.txt", line + Environment.NewLine);
                MessageBox.Show("Tenant saved to Tenants.txt.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
