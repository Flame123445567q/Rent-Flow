using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RentFlow_Application.Classes;

namespace RentFlow_Application
{
    public partial class RegisterForm2 : Form
    {
       public static List<User> RegisteredUser = new List<User>();
        public RegisterForm2()
        {
            InitializeComponent();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            string userRole = cmbRoles.SelectedItem.ToString();
            string fullName = txtFull_Name.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber= txtPhoneNumber.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                errorProvider1.SetError(txtFull_Name,"Full Name is required");
                isValid = false;
            }
            else if (fullName.Length < 2)
            {
                errorProvider1.SetError(txtFull_Name, "Name must be more than two characters");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                errorProvider1.SetError(txtSurname, "Surname is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(idNumber))
            {
                errorProvider1.SetError(txtIDNumber, "ID Number is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Email is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone Number is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtPassword, "Password is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password");
                isValid = false;
            }
            if (cmbRoles.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRoles, "Select a role");
                isValid = false;
            }

            if (isValid= false)
            {
                MessageBox.Show("Please fill in all fields.", "Validation error",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
