using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class TenantDashboardForm : Form
    {
        public TenantDashboardForm()
        {
            InitializeComponent();
            this.Load += TenantDashboardForm_Load;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void TenantDashboardForm_Load(object sender, EventArgs e)
        {
        //    try

        //    {
        //        if (lblUserName != null)
        //        {
        //            lblUserName.Text = $"{DataStore.LoggedInRole}: {DataStore.LoggedInName}";
        //        }
        //    }
        //    catch { }
        //}
        }
    }
}