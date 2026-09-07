using System;
using System.Drawing;
using System.Windows.Forms;
using RentFlow_Application.Classes;

namespace RentFlow_Application.Forms
{
    public partial class LoginForm : Form
    {
        // Stores which role button was clicked (default = Landlord)
        private string selectedRole = "Landlord";

        public LoginForm()
        {
            InitializeComponent();

            //  Load users from the file when the form opens
            RegisterForm2.RegisteredUser = FileManager.LoadUsers();

            // Set default placeholder text
            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
        }

        // ============================================================
        // ROLE BUTTON CLICKS
        // ============================================================

        private void btnLandlord_Click(object sender, EventArgs e)
        {
            selectedRole = "Landlord";

            // Highlight Landlord button
            btnLandLord.BackColor = Color.Blue;
            btnLandLord.ForeColor = Color.White;

            // Reset others
            btnTenant.BackColor = Color.White;
            btnTenant.ForeColor = Color.Black;
            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Black;

            // Update placeholder text
            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            selectedRole = "Tenant";

            // Highlight Tenant button
            btnTenant.BackColor = Color.Blue;
            btnTenant.ForeColor = Color.White;

            // Reset others
            btnLandLord.BackColor = Color.White;
            btnLandLord.ForeColor = Color.Black;
            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Black;

            // Update placeholder text
            txtUsername.PlaceholderText = "tenant@rentFlow.co.za";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";

            // Highlight Admin button
            btnAdmin.BackColor = Color.Blue;
            btnAdmin.ForeColor = Color.White;

            // Reset others
            btnLandLord.BackColor = Color.White;
            btnLandLord.ForeColor = Color.Black;
            btnTenant.BackColor = Color.White;
            btnTenant.ForeColor = Color.Black;

            // Update placeholder text
            txtUsername.PlaceholderText = "admin@rentFlow.co.za";
        }

        // ============================================================
        // SIGN-IN BUTTON (Full functionality!)
        // ============================================================

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // 1. Get the values from the form
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 2. VALIDATION: Check if fields are empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. VALIDATION: Check if a role was selected
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role (LandLord, Tenant, or Admin).", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. SEARCH FOR THE USER IN THE LIST
            foreach (User user in RegisterForm2.RegisteredUser)
            {
                // Check if email, password, AND role match
                if (user.Email.ToLower() == email.ToLower() &&
                    user.Password == password &&
                    user.Role == selectedRole)
                {
                    // ✅ LOGIN SUCCESSFUL!
                    MessageBox.Show($"Welcome {user.FullName} {user.Surname}!\n" +
                                    $"Role: {user.Role}",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Open the Main Form (Dashboard)
                    Properties_Form mainForm = new Properties_Form();
                    mainForm.Show();
                    this.Hide();  // Hide the Login form
                    return;
                }
            }

            // 5. If we get here, no user matched
            MessageBox.Show("Invalid email, password, or role. Please try again.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ============================================================
        // CREATE ACCOUNT BUTTON
        // ============================================================

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Registration form
            RegisterForm2 registerForm = new RegisterForm2();

            // Show the Registration form (Login stays open in the background)
            registerForm.Show();
        }

        // ============================================================
        // FORGOT PASSWORD (Optional - just shows a message)
        // ============================================================

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your system administrator to reset your password.",
                            "Forgot Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // ============================================================
        // REMEMBER ME (Optional - just shows a message for now)
        // ============================================================

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            // This is just a placeholder. You can implement cookie-based
            // remember-me functionality later.
        }
    }
}