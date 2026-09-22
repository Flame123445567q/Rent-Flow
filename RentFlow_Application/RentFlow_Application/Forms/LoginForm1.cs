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
        // Which role the user selected (Landlord, Tenant, Admin)
        private string selectedRole = null;
        // Local cached list of registered users (kept for compatibility with designer and other code)
        private List<User> RegisteredUser;

        public LoginForm()
        {
            InitializeComponent();

            // Populate the shared RegisteredUser list using helper
            RegisterForm2.RegisteredUser = FileManager.LoadUsers();
            RegisteredUser = RegisterForm2.RegisteredUser;

            // Ensure UI starts with clean role visuals
            ResetRoleButtonsVisuals();

            txtUsername.PlaceholderText = "Enter your email address";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Attempt to prefill remembered credentials if remember.txt exists
            try
            {
                string rememberPath = Path.Combine(Application.StartupPath ?? ".", "remember.txt");
                if (File.Exists(rememberPath))
                {
                    string[] lines = File.ReadAllLines(rememberPath);
                    if (lines.Length >= 2)
                    {
                        txtUsername.Text = lines[0];
                        txtPassword.Text = lines[1];
                        chkRemberMe.Checked = true;
                    }
                }
            }
            catch { }
        }

        // Visual helpers
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

        // Role clicks -- set role and update visuals + placeholder
        private void btnLandlord_Click(object sender, EventArgs e)
        {
            selectedRole = "Landlord";
            ResetRoleButtonsVisuals();

            btnLandLord.BackColor = Color.Blue;
            btnLandLord.ForeColor = Color.White;
            btnLandLord.FlatAppearance.BorderSize = 2;
            btnLandLord.FlatAppearance.BorderColor = Color.Blue;

            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            selectedRole = "Tenant";
            ResetRoleButtonsVisuals();

            btnTenant.BackColor = Color.Blue;
            btnTenant.ForeColor = Color.White;
            btnTenant.FlatAppearance.BorderSize = 2;
            btnTenant.FlatAppearance.BorderColor = Color.Blue;

            txtUsername.PlaceholderText = "tenant@rentFlow.co.za";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            ResetRoleButtonsVisuals();

            btnAdmin.BackColor = Color.Blue;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatAppearance.BorderColor = Color.Blue;

            txtUsername.PlaceholderText = "admin@rentFlow.co.za";
        }

        // Sign in button handler - validates and then dispatches by role
        private void btnSigningIn_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text.Trim() ?? string.Empty;
            string password = txtPassword.Text ?? string.Empty;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                ShowRoleSelectionError();
                MessageBox.Show("Please select a role (LandLord, Tenant, or Admin).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRole == "Tenant")
            {
                AuthenticateTenant(email, password);
                return;
            }

            AuthenticateAdminOrLandlord(email, password, selectedRole);
        }

        // Tenant authentication: email must match a registered tenant and password == ID number
        private void AuthenticateTenant(string email, string password)
        {
            string tenantsPath = Path.Combine(Application.StartupPath ?? ".", "Tenants.txt");

            if (!File.Exists(tenantsPath))
            {
                MessageBox.Show("You are not a registered Tenant.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(tenantsPath);
            foreach (var raw in lines)
            {
                if (string.IsNullOrWhiteSpace(raw)) continue;
                string[] parts = raw.Split();
                if (parts.Length < 6) continue; // malformed line

                string tenantEmail = parts[4];
                string tenantIdNumber = parts[5];

                if (string.Equals(tenantEmail, email, StringComparison.OrdinalIgnoreCase) && tenantIdNumber == password)
                {
                    string first = parts.Length > 1 ? parts[1].Replace('_', ' ') : string.Empty;
                    string last = parts.Length > 2 ? parts[2].Replace('_', ' ') : string.Empty;

                    MessageBox.Show($"Welcome {first} {last}!\nRole: Tenant", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HandleRememberMe(email, password);

                    DataStore.LoggedInEmail = tenantEmail;
                    DataStore.LoggedInRole = "Tenant";
                    DataStore.LoggedInName = (first + " " + last).Trim();

                    var tenantForm = new TenantDashboardForm();
                    tenantForm.Show();
                    this.Hide();
                    return;
                }
                MessageBox.Show("Invalid tenant credentials. Ensure you are a registered tenant and your password is your ID number.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        // Admin / Landlord authentication against the RegisteredUser list
        private void AuthenticateAdminOrLandlord(string email, string password, string role)
        {
            var users = RegisterForm2.RegisteredUser ?? new List<User>();

            foreach (var user in users)
            {
                if (string.Equals(user.Email, email, StringComparison.OrdinalIgnoreCase)
                    && user.Password == password
                    && user.Role == role)
                {
                    MessageBox.Show($"Welcome {user.FullName} {user.Surname}!\nRole: {user.Role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HandleRememberMe(email, password);

                    DataStore.LoggedInEmail = user.Email;
                    DataStore.LoggedInRole = user.Role;
                    DataStore.LoggedInName = user.FullName + " " + user.Surname;

                    if (role == "Admin")
                    {
                        var adminForm = new AdminDashboardForm();
                        adminForm.Show();
                        this.Hide();
                        return;
                    }

                    if (role == "Landlord")
                    {
                        var propForm = new Properties_Form();
                        propForm.Show();
                        this.Hide();
                        lblUsername.Text = $"{user.FullName} {user.Surname}\nRole:{user.Role}";
                        return;
                    }
                }
            }

            MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Remember-me helper
        private void HandleRememberMe(string email, string password)
        {
            try
            {
                string rememberPath = Path.Combine(Application.StartupPath ?? ".", "remember.txt");
                if (chkRemberMe.Checked)
                {
                    File.WriteAllLines(rememberPath, new string[] { email, password });
                }
                else
                {
                    if (File.Exists(rememberPath)) File.Delete(rememberPath);
                }
            }
            catch { }
        }

        // Designer-wired handlers (simple defaults so designer references compile)
        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {

            RegisterForm2 reg = new RegisterForm2();
            reg.ShowDialog();

        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password form = new Forgot_Password();
            form.ShowDialog();
            //MessageBox.Show("Please contact support to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
