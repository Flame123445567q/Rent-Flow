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
        public EditMaintenanceRequest()
        {
            InitializeComponent();
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
    }
}
