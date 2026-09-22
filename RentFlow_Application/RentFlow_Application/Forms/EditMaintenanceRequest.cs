using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class EditMaintenanceRequest : Form
    {
        private string requestId;
        public EditMaintenanceRequest()
        {
            InitializeComponent();
            this.requestId = requestId;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you Sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
         
            if (!File.Exists("maintenance.txt")) return;

            string newStatus = "";
            if (rdoPending.Checked)
            {

                newStatus = "Pending";
            }
            else if (rdoResolved.Checked)
            {

                newStatus = "Resolved";
            }

            if (newStatus =="" && !rdoRemove.Checked)
            {
                MessageBox.Show("Please select a status request", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines("maintenance.txt");
            List<string> updated = new List<string>();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length < 8)
                {
                    updated.Add(line);
                    continue;
                }

                if (parts[0] == requestId)
                {
                    if (rdoRemove.Checked)
                    {
                        continue;
                    }

                    parts[6] = newStatus;
                    updated.Add(string.Join("|", parts));
                }
                else
                {
                    updated.Add(line);
                }
            }

            File.WriteAllLines("maintenance.txt", updated);

            if (rdoRemove.Checked)
            {
                MessageBox.Show("Request " + requestId + " removed.", "Success");
            }
            else
            {
                MessageBox.Show("Request " + requestId + " updated to " + newStatus + ".", "Success");
            }

            
            this.Close();

        }
    }
}
