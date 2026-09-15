using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            this.Load += AdminDashboardForm_Load;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                LoginForm login = new LoginForm();
                login.Show();
            }
        }
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
           
        }
        }
    }

