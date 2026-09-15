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
            // Default to dashboard view
            try
            {
                btnMyDashBoard_Click(this, EventArgs.Empty);
            }
            catch { }
        }

        private void ShowOnly(params Panel[] panelsToShow)
        {
            // list of main panels to manage
            Panel[] all = new Panel[] { panel1, pnlLeaseDetails, pnlPaymentHistory, pnlCard1, pnlCard2, pnlCard3, pnlCard4 };
            foreach (var p in all)
            {
                if (p != null) p.Visible = false;
            }
            foreach (var p in panelsToShow)
            {
                if (p != null) p.Visible = true;
            }
        }

        private void btnMyDashBoard_Click(object sender, EventArgs e)
        {
            // show lease details, payment history and summary cards
            ShowOnly(pnlLeaseDetails, pnlPaymentHistory, pnlCard1, pnlCard2, pnlCard3, pnlCard4);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            // show the maintenance panel area (panel1)
            ShowOnly(panel1);
        }
    }
}