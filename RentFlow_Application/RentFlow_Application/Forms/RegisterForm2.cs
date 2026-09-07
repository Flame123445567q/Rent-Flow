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
        // The list that holds all registered users in memory
        public static List<User> RegisteredUser = new List<User>();

        public RegisterForm2()
        {
            InitializeComponent();

            // 🔥 LOAD existing users from the file when the form opens
            RegisteredUser = FileManager.LoadUsers();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            // Get all the values from the form
            string fullName = txtFull_Name.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            bool isValid = true;

            // ============================================================
            // VALIDATION
            // ============================================================

            // Full Name validation
            if (string.IsNullOrWhiteSpace(fullName))
            {
                errorProvider1.SetError(txtFull_Name, "Full Name is required");
                isValid = false;
            }
            else if (fullName.Length < 2)
            {
                errorProvider1.SetError(txtFull_Name, "Name must be more than two characters");
                isValid = false;
            }

            // Surname validation
            if (string.IsNullOrWhiteSpace(surname))
            {
                errorProvider1.SetError(txtSurname, "Surname is required");
                isValid = false;
            }

            // ID Number validation
            if (string.IsNullOrWhiteSpace(idNumber))
            {
                errorProvider1.SetError(txtIDNumber, "ID Number is required");
                isValid = false;
            }
            else if (idNumber.Length != 13)
            {
                errorProvider1.SetError(txtIDNumber, "ID Number must be 13 Digits");
                isValid = false;
            }
            else
            {
                foreach (char ID in idNumber)
                {
                    if (!char.IsDigit(ID))
                    {
                        errorProvider1.SetError(txtIDNumber, "ID Number must be Numbers");
                        isValid = false;
                        break;
                    }
                }
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Email is required");
                isValid = false;
            }
            else if (!email.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Invalid Email.");
                isValid = false;
            }

            // Phone Number validation
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone Number is required");
                isValid = false;
            }
            else if (phoneNumber.Length != 10)
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone Number must be 10 digits");
                isValid = false;
            }
            else
            {
                foreach (char phoneNum in phoneNumber)
                {
                    if (!char.IsDigit(phoneNum))
                    {
                        errorProvider1.SetError(txtPhoneNumber, "Phone Number must be digits only");
                        isValid = false;
                        break;
                    }
                }
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtPassword, "Password is required");
                isValid = false;
            }
            else if (password.Length < 6)
            {
                errorProvider1.SetError(txtPassword, "Password must be more than 6 characters");
                isValid = false;
            }

            // Confirm Password validation
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password is required");
                isValid = false;
            }
            else if (password != confirmPassword)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match");
                isValid = false;
            }

            // Role selection validation
            if (cmbRoles.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRoles, "Select a role");
                isValid = false;
            }

            // ============================================================
            // IF VALIDATION FAILS, SHOW ERROR AND EXIT
            // ============================================================
            if (!isValid)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================================================
            // 🔥🔥🔥 VALIDATION PASSED – SAVE THE USER 🔥🔥🔥
            // ============================================================

            // STEP 1: Check for duplicate email
            foreach (User existingUser in RegisteredUser)
            {
                if (existingUser.Email.ToLower() == email.ToLower())
                {
                    MessageBox.Show("An account with this email already exists.", "Duplicate",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // STEP 2: Create the new user
            User newUser = new User
            {
                Role = cmbRoles.SelectedItem?.ToString() ?? "Landlord",
                FullName = fullName ?? "Unknown",
                Surname = surname ?? "Unknown",
                IDNumber = idNumber ?? "0000000000000",
                Email = email ?? "unknown@email.com",
                PhoneNumber = phoneNumber ?? "0000000000",
                Password = password ?? "default"
            };

            // STEP 3: Add to the list (with safety check!)
            if (RegisteredUser == null)
            {
                RegisteredUser = new List<User>();
            }
            RegisteredUser.Add(newUser);

            // STEP 4: Save to file (with safety check!)
            if (RegisteredUser != null && RegisteredUser.Count > 0)
            {
                FileManager.SaveUsers(RegisteredUser);
            }

            // STEP 5: Clear the form
            txtFull_Name.Clear();
            txtSurname.Clear();
            txtIDNumber.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRoles.SelectedIndex = -1;
            cmbRoles.Focus();

            // STEP 6: Clear error messages
            errorProvider1.Clear();

            // STEP 7: Show success message
            MessageBox.Show($"Account successfully registered for {fullName} {surname}!",
                            "Registration Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}