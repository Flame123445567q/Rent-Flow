using System.Windows.Forms;
using System.IO;

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
            Panel[] all = new Panel[] { panel1};
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
            ShowOnly();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            // show the maintenance panel area (panel1)
            ShowOnly(panel1);
            // Read tenant name + property/unit from tenants.txt
            string tenantName = "";
            string propertyUnit = "";

            if (File.Exists("tenants.txt"))
            {
                string[] lines = File.ReadAllLines("tenants.txt");
                if (lines.Length > 0)
                {
                    string lastLine = lines[lines.Length - 1];
                    string[] parts = lastLine.Split('|');

                    // Adjust indexes if needed — based on your file format:
                    // 0=Id  1=FullName  2=Phone  3=Email  4=ID  5=PropertyUnit  ...
                    tenantName = parts[0];
                    propertyUnit = parts[4];
                }
            }

            Submit_Maintenancefrm form = new Submit_Maintenancefrm(tenantName, propertyUnit);
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}