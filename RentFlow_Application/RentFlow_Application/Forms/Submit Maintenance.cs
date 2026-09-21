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
    public partial class Submit_Maintenancefrm : Form
    {
        private string tenantName;
        private string propertyUnit;

        public Submit_Maintenancefrm(string tenantName, string propertyUnit)  
        {
            InitializeComponent();
            this.tenantName = tenantName;
            this.propertyUnit = propertyUnit;
        }

        public Submit_Maintenancefrm()
        {
            InitializeComponent();
            // Ensure fields have default non-null values when opened without parameters
            this.tenantName = string.Empty;
            this.propertyUnit = string.Empty;
        }

        List<MaintenanceRequest> maintenanceList = new List<MaintenanceRequest>();
        //public Submit_Maintenancefrm()
        //{
        //    InitializeComponent();
        //}

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {

            
           
            string issueCategory = cmbIssueCatagory.Text;
            string description = txtDescribtion.Text;
            string priority = cmbPritority.Text;

            // Validation
            if (cmbIssueCatagory.SelectedIndex == -1)
            {
                MessageBox.Show("Select an Issue", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Maintenance Description is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPritority.SelectedIndex == -1)
            {
                MessageBox.Show("Select Priority Level", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rnd = new Random();
            string requestId = "MTR" + rnd.Next(1000, 9999).ToString();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string status = "Open";
            

            // Create the object
            MaintenanceRequest newRequest = new MaintenanceRequest(
                requestId, tenantName, propertyUnit,
                issueCategory, description, priority,
                status, date);

            // Save to file
            string line = $"{newRequest.RequestId}|{newRequest.TenantName}|{newRequest.PropertyUnit}|" +
                          $"{newRequest.IssueDescription}|{newRequest.IssuePriority}|{newRequest.Status}|{newRequest.Date}";

            File.AppendAllText("maintenance.txt", line + Environment.NewLine);

            MessageBox.Show($"Request submitted!\nReference: {requestId}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
          
            
            
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you Sure you want to cancel?", "Cancel",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
            }
            
        }
    }
}
