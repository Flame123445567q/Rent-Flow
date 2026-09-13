namespace RentFlow_Application.Forms
{
    partial class TenantDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnMyDashBoard = new Button();
            lblLogo = new Label();
            pnlMain = new Panel();
            panel1 = new Panel();
            pnlPaymentHistory = new Panel();
            pnlLeaseDetails = new Panel();
            btnMaintenance = new Button();
            pnlCard4 = new Panel();
            lblOutstandingBalance = new Label();
            pnlCard3 = new Panel();
            lblLeaseExpire = new Label();
            pnlCard2 = new Panel();
            lblCurrentUnit = new Label();
            pnlCard1 = new Panel();
            lblTenantCurrentProperty = new Label();
            lblMyDashboard = new Label();
            txtSearch = new TextBox();
            lblLeaseDetailsTitle = new Label();
            lblPaymentHistoryTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 24, 39);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnMyDashBoard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 825);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(15, 761);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(172, 39);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyDashBoard
            // 
            btnMyDashBoard.BackColor = Color.FromArgb(37, 99, 235);
            btnMyDashBoard.FlatStyle = FlatStyle.Flat;
            btnMyDashBoard.ForeColor = Color.White;
            btnMyDashBoard.Location = new Point(10, 70);
            btnMyDashBoard.Name = "btnMyDashBoard";
            btnMyDashBoard.Size = new Size(200, 35);
            btnMyDashBoard.TabIndex = 0;
            btnMyDashBoard.Text = "My DashBoard";
            btnMyDashBoard.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(15, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(116, 32);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Rentflow";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(249, 250, 251);
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(pnlPaymentHistory);
            pnlMain.Controls.Add(pnlLeaseDetails);
            pnlMain.Controls.Add(btnMaintenance);
            pnlMain.Controls.Add(pnlCard4);
            pnlMain.Controls.Add(pnlCard3);
            pnlMain.Controls.Add(pnlCard2);
            pnlMain.Controls.Add(pnlCard1);
            pnlMain.Controls.Add(lblMyDashboard);
            pnlMain.Controls.Add(txtSearch);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(220, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1504, 825);
            pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(740, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 350);
            panel1.TabIndex = 2;
            // 
            // pnlPaymentHistory
            // 
            pnlPaymentHistory.BackColor = Color.White;
            pnlPaymentHistory.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentHistory.Location = new Point(20, 600);
            pnlPaymentHistory.Name = "pnlPaymentHistory";
            pnlPaymentHistory.Size = new Size(1440, 200);
            pnlPaymentHistory.TabIndex = 0;
            // 
            // pnlLeaseDetails
            // 
            pnlLeaseDetails.BackColor = Color.White;
            pnlLeaseDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlLeaseDetails.Location = new Point(20, 235);
            pnlLeaseDetails.Name = "pnlLeaseDetails";
            pnlLeaseDetails.Size = new Size(700, 350);
            pnlLeaseDetails.TabIndex = 1;
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.FromArgb(37, 99, 235);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(20, 183);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(210, 39);
            btnMaintenance.TabIndex = 2;
            btnMaintenance.Text = "Submit Maintenance Request";
            btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.BorderStyle = BorderStyle.FixedSingle;
            pnlCard4.Controls.Add(lblOutstandingBalance);
            pnlCard4.Location = new Point(1100, 95);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(340, 70);
            pnlCard4.TabIndex = 5;
            // 
            // lblOutstandingBalance
            // 
            lblOutstandingBalance.AutoSize = true;
            lblOutstandingBalance.Location = new Point(3, 11);
            lblOutstandingBalance.Name = "lblOutstandingBalance";
            lblOutstandingBalance.Size = new Size(175, 25);
            lblOutstandingBalance.TabIndex = 12;
            lblOutstandingBalance.Text = "Outstanding Balance";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.BorderStyle = BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(lblLeaseExpire);
            pnlCard3.Location = new Point(740, 95);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(340, 70);
            pnlCard3.TabIndex = 6;
            // 
            // lblLeaseExpire
            // 
            lblLeaseExpire.AutoSize = true;
            lblLeaseExpire.Location = new Point(3, 11);
            lblLeaseExpire.Name = "lblLeaseExpire";
            lblLeaseExpire.Size = new Size(107, 25);
            lblLeaseExpire.TabIndex = 13;
            lblLeaseExpire.Text = "Lease Expire";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblCurrentUnit);
            pnlCard2.Location = new Point(380, 95);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(340, 70);
            pnlCard2.TabIndex = 7;
            // 
            // lblCurrentUnit
            // 
            lblCurrentUnit.AutoSize = true;
            lblCurrentUnit.Location = new Point(3, 11);
            lblCurrentUnit.Name = "lblCurrentUnit";
            lblCurrentUnit.Size = new Size(107, 25);
            lblCurrentUnit.TabIndex = 14;
            lblCurrentUnit.Text = "Current Unit";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblTenantCurrentProperty);
            pnlCard1.Location = new Point(20, 95);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(340, 70);
            pnlCard1.TabIndex = 8;
            // 
            // lblTenantCurrentProperty
            // 
            lblTenantCurrentProperty.AutoSize = true;
            lblTenantCurrentProperty.Location = new Point(3, 11);
            lblTenantCurrentProperty.Name = "lblTenantCurrentProperty";
            lblTenantCurrentProperty.Size = new Size(143, 25);
            lblTenantCurrentProperty.TabIndex = 11;
            lblTenantCurrentProperty.Text = "Current Property";
            // 
            // lblMyDashboard
            // 
            lblMyDashboard.AutoSize = true;
            lblMyDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMyDashboard.Location = new Point(20, 55);
            lblMyDashboard.Name = "lblMyDashboard";
            lblMyDashboard.Size = new Size(209, 38);
            lblMyDashboard.TabIndex = 9;
            lblMyDashboard.Text = "My Dashboard";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 31);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Search for properties, tenants...";
            // 
            // lblLeaseDetailsTitle
            // 
            lblLeaseDetailsTitle.AutoSize = true;
            lblLeaseDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLeaseDetailsTitle.Location = new Point(10, 10);
            lblLeaseDetailsTitle.Name = "lblLeaseDetailsTitle";
            lblLeaseDetailsTitle.Size = new Size(100, 23);
            lblLeaseDetailsTitle.TabIndex = 0;
            lblLeaseDetailsTitle.Text = "Lease Details";
            // 
            // lblPaymentHistoryTitle
            // 
            lblPaymentHistoryTitle.Location = new Point(0, 0);
            lblPaymentHistoryTitle.Name = "lblPaymentHistoryTitle";
            lblPaymentHistoryTitle.Size = new Size(100, 23);
            lblPaymentHistoryTitle.TabIndex = 0;
            // 
            // TenantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1724, 825);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "TenantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMyDashBoard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblMyDashboard;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Panel pnlLeaseDetails;
        private System.Windows.Forms.Label lblLeaseDetailsTitle;
        private System.Windows.Forms.Panel pnlPaymentHistory;
        private System.Windows.Forms.Label lblPaymentHistoryTitle;
        private Panel panel1;
        private Label lblOutstandingBalance;
        private Label lblLeaseExpire;
        private Label lblCurrentUnit;
        private Label lblTenantCurrentProperty;
        private Button btnLogout;
    }
}