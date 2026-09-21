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
    public partial class AddPropertyForm : Form
    {
        // Caller should set this before showing the form so saved property gets a unique ID
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int NextPropertyID { get; set; } = 0;

        public AddPropertyForm()
        {
            InitializeComponent();
        }

        private void btnSaveProperty_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtPropertyName.Text))
            {
                MessageBox.Show("Please enter a property name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStreetAddress.Text))
            {
                MessageBox.Show("Please enter the street address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare tokens replacing spaces with underscores so the Properties loader (which splits on whitespace) can parse fields
            string nameToken = txtPropertyName.Text.Trim().Replace(' ', '_');
            string addressToken = txtStreetAddress.Text.Trim().Replace(' ', '_');
            string cityToken = (txtCity != null ? txtCity.Text.Trim().Replace(' ', '_') : string.Empty);
            string provinceToken = (txtProvince != null ? txtProvince.Text.Trim().Replace(' ', '_') : string.Empty);
            string postalToken = (txtPostalCode != null ? txtPostalCode.Text.Trim().Replace(' ', '_') : string.Empty);

            // Compose a 6-field line: id name address type rentalAmount status
            string propertyType = "None"; // placeholder so loader sees 6 tokens
            string rentalAmount = "0";
            string status = "Active";

            string idToken = (NextPropertyID > 0) ? NextPropertyID.ToString() : "0";
            string line = string.Join(' ', new string[] { idToken, nameToken, addressToken, propertyType, rentalAmount, status });

            try
            {
                File.AppendAllText("Properties.txt", line + Environment.NewLine);
                MessageBox.Show("Property saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save property: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
