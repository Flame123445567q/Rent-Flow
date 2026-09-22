using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
            else
            {
                foreach (char ID in txtIDNumber.Text)
                {
                    if (!char.IsDigit(ID))
                    {
                        errorProvider1.SetError(txtIDNumber, "ID Number must be Numbers");
                        return;
                        break;
                    }
                }
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

            // save into application folder to avoid unexpected working-directory issues
            string filePath = Path.Combine(Application.StartupPath ?? ".", "Tenants.txt");
            try
            {
                File.AppendAllText(filePath, line + Environment.NewLine);
                MessageBox.Show($"Tenant saved to {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // try to log error to an application log and show friendly message
                try
                {
                    string logPath = Path.Combine(Application.StartupPath ?? ".", "error.log");
                    File.AppendAllText(logPath, DateTime.Now.ToString("s") + " - Failed to save tenant: " + ex + Environment.NewLine);
                }
                catch { }

                MessageBox.Show($"Failed to save tenant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveTenant_Click_1(object sender, EventArgs e)
        {
            Tenant newTenant = new Tenant();
            newTenant.SetTenantID(DataStore.TenantsList.Count + 1);
            newTenant.SetFirstName(txtFirstName.Text.Trim());
            newTenant.SetLastName(txtLastName.Text.Trim());
            newTenant.SetPhoneNumber(txtPhoneNumber.Text.Trim());
            newTenant.SetEmailAddress(txtEmailAddress.Text.Trim());
            newTenant.SetIDNumber(txtIDNumber.Text.Trim());
            newTenant.SetAssignedProperty(cmbAssignedProperty.Text);
            newTenant.SetAssignedUnit(cmbAssignedUnit.Text);

            DataStore.TenantsList.Add(newTenant);
            DataStore.SaveTenants();

            this.Close(); // close popup, MainFo

        }

        private void Add_New_Tenants_Load(object sender, EventArgs e)
        {
            cmbAssignedProperty.DataSource = null;
            cmbAssignedProperty.DataSource = DataStore.Properties
                .Select(p => p.GetPropertyName())
                .ToList();
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
