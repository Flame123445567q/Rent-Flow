using System;
using System.Drawing;
using System.Windows.Forms;
using RentFlow_Application.Classes;
using System.Collections.Generic;
using RentFlow_Application;
using System.IO;


namespace RentFlow_Application.Forms
{
    public partial class LoginForm : Form
    {
        // Stores which role button was clicked. No default: user must choose one.
        private string selectedRole = null;
        List<User> RegisteredUser;

        public LoginForm()
        {
            InitializeComponent();

            //  Load users from the file when the form opens
            RegisterForm2.RegisteredUser = FileManager.LoadUsers();
            // No default role selected; ensure UI reflects unselected state
            ResetRoleButtonsVisuals();

            // Generic placeholder text
            txtUsername.PlaceholderText = "Enter your email";
        }

        // Reset all role buttons to unselected visual state
        private void ResetRoleButtonsVisuals()
        {
            try
            {
                foreach (var btn in new[] { btnLandLord, btnTenant, btnAdmin })
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
            catch { }
        }

        // Mark role buttons with a red border to indicate the user must select one
        private void ShowRoleSelectionError()
        {
            try
            {
                foreach (var btn in new[] { btnLandLord, btnTenant, btnAdmin })
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.BorderColor = Color.Red;
                }
            }
            catch { }
        }

        // ============================================================
        // ROLE BUTTON CLICKS
        // ============================================================

        private void btnLandlord_Click(object sender, EventArgs e)
        {
            selectedRole = "Landlord";

            // Visuals
            ResetRoleButtonsVisuals();
            btnLandLord.BackColor = Color.Blue;
            btnLandLord.ForeColor = Color.White;
            btnLandLord.FlatAppearance.BorderSize = 2;
            btnLandLord.FlatAppearance.BorderColor = Color.Blue;

            // Update placeholder text
            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            selectedRole = "Tenant";

            // Visuals
            ResetRoleButtonsVisuals();
            btnTenant.BackColor = Color.Blue;
            btnTenant.ForeColor = Color.White;
            btnTenant.FlatAppearance.BorderSize = 2;
            btnTenant.FlatAppearance.BorderColor = Color.Blue;

            // Update placeholder text
            txtUsername.PlaceholderText = "tenant@rentFlow.co.za";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";

            // Visuals
            ResetRoleButtonsVisuals();
            btnAdmin.BackColor = Color.Blue;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatAppearance.BorderColor = Color.Blue;

            // Update placeholder text
            txtUsername.PlaceholderText = "admin@rentFlow.co.za";
        }

        // ============================================================
        // SIGN-IN BUTTON (Full functionality!)
        // ============================================================

        private void btnSigningIn_Click(object sender, EventArgs e)
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
                // visually indicate required selection
                ShowRoleSelectionError();
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

                     
                    string rememberPath = Path.Combine(Application.StartupPath, "remember.txt");

                    if (chkRemberMe.Checked)
                    {
                        File.WriteAllLines(rememberPath, new string[] { txtUsername.Text.Trim(), txtPassword.Text.Trim() });
                    }
                    else
                    {
                        if (File.Exists(rememberPath))
                        {
                            File.Delete(rememberPath);
                        }
                    }

                    // Open the Main Form (Dashboard)
                    DataStore.LoggedInEmail = user.Email;
                    DataStore.LoggedInRole = selectedRole;
                    DataStore.LoggedInName = user.FullName + " " + user.Surname;

                    if (selectedRole == "Tenant")
                    {
                        TenantDashboardForm tenantForm = new TenantDashboardForm();
                        tenantForm.Show();
                        this.Hide();
                        return;
                    }
                    else if (selectedRole == "Admin")
                    {
                        AdminDashboardForm adminForm = new AdminDashboardForm();
                        adminForm.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        Properties_Form LandlordForm = new Properties_Form();
                        LandlordForm.Show();
                        this.Hide();
                        return;
                    }

                }
            }

            // 5. If we get here, no user matched
            MessageBox.Show("Invalid email, password, or role. Please try again.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

            string path = Path.Combine(Application.StartupPath, "remember.txt");

            if (chkRemberMe.Checked)
            {
                File.WriteAllLines(path, new string[] { txtUsername.Text.Trim(), txtPassword.Text.Trim() });
            }
            else
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
          
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

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password forgotForm = new Forgot_Password();
            forgotForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RegisteredUser = FileManager.LoadUsers();

            string path = Path.Combine(Application.StartupPath, "remember.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines("remember.txt");

                if (lines.Length >= 2)
                {
                    txtUsername.Text = lines[0];
                    txtPassword.Text = lines[1];
                    chkRemberMe.Checked = true;
                }
            }
        }
    }
}
