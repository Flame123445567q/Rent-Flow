namespace RentFlow_Application.Forms
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
        }
        // Put this at top inside your Form class
        string selectedRole = "Landlord";

        private void btnLandlord_Click(object sender, EventArgs e)
        {

            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
            selectedRole = "Landlord";
            btnLandLord.BackColor = Color.Blue;
            btnLandLord.ForeColor = Color.White;

            btnTenant.BackColor = Color.White;
            btnTenant.ForeColor = Color.Black;

            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Black;

            txtUsername.PlaceholderText = "landlord@rentFlow.co.za";
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            selectedRole = "Tenant";
            btnTenant.BackColor = Color.Blue;
            btnTenant.ForeColor = Color.White;

            btnLandLord.BackColor = Color.White;
            btnLandLord.ForeColor = Color.Black;

            btnAdmin.BackColor = Color.White;
            btnAdmin.ForeColor = Color.Black;

            txtUsername.PlaceholderText = "tenant@rentFlow.co.za";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            btnAdmin.BackColor = Color.Blue;
            btnAdmin.ForeColor = Color.White;

            btnLandLord.BackColor = Color.White;
            btnLandLord.ForeColor = Color.Black;

            btnTenant.BackColor = Color.White;
            btnTenant.ForeColor = Color.Black;

            txtUsername.PlaceholderText = "admin@rentFlow.co.za";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logging in as: " + selectedRole);
        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Registration form
            RegisterForm2 registerForm = new RegisterForm2();

            // Show the Registration form
            registerForm.Show();

            // Optional: Hide the Login form so the user doesn't see it behind
            this.Hide();
        }
    }
}
