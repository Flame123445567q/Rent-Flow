namespace RentFlow_Application.Forms
{
    partial class AdminDashboardForm
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
            btnAdminDashboard = new Button();
            lblLogo = new Label();
            //lblUserName = new Label();
            pnlMain = new Panel();
            pnlAuditLog = new Panel();
            lblAuditLogTitle = new Label();
            pnlUserManagement = new Panel();
            lblUserManagementTitle = new Label();
            pnlCard5 = new Panel();
            lblCard5Title = new Label();
            pnlCard4 = new Panel();
            lblCard4Title = new Label();
            pnlCard3 = new Panel();
            lblCard3Title = new Label();
            pnlCard2 = new Panel();
            lblCard2Title = new Label();
            pnlCard1 = new Panel();
            lblCard1Title = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnAdminLogout = new Button();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlAuditLog.SuspendLayout();
            pnlUserManagement.SuspendLayout();
            pnlCard5.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 24, 39);
            pnlSidebar.Controls.Add(btnAdminLogout);
            pnlSidebar.Controls.Add(btnAdminDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 825);
            pnlSidebar.TabIndex = 1;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = Color.FromArgb(37, 99, 235);
            btnAdminDashboard.FlatStyle = FlatStyle.Flat;
            btnAdminDashboard.ForeColor = Color.White;
            btnAdminDashboard.Location = new Point(10, 70);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(200, 35);
            btnAdminDashboard.TabIndex = 0;
            btnAdminDashboard.Text = "Admin Dashboard";
            btnAdminDashboard.UseVisualStyleBackColor = false;
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
            // lblUserName
            // 
           
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(249, 250, 251);
            pnlMain.Controls.Add(pnlAuditLog);
            pnlMain.Controls.Add(pnlUserManagement);
            pnlMain.Controls.Add(pnlCard5);
            pnlMain.Controls.Add(pnlCard4);
            pnlMain.Controls.Add(pnlCard3);
            pnlMain.Controls.Add(pnlCard2);
            pnlMain.Controls.Add(pnlCard1);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(txtSearch);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(220, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1504, 825);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlAuditLog
            // 
            pnlAuditLog.BackColor = Color.White;
            pnlAuditLog.BorderStyle = BorderStyle.FixedSingle;
            pnlAuditLog.Controls.Add(lblAuditLogTitle);
            pnlAuditLog.Location = new Point(890, 220);
            pnlAuditLog.Name = "pnlAuditLog";
            pnlAuditLog.Size = new Size(560, 400);
            pnlAuditLog.TabIndex = 0;
            // 
            // lblAuditLogTitle
            // 
            lblAuditLogTitle.AutoSize = true;
            lblAuditLogTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAuditLogTitle.Location = new Point(10, 10);
            lblAuditLogTitle.Name = "lblAuditLogTitle";
            lblAuditLogTitle.Size = new Size(104, 28);
            lblAuditLogTitle.TabIndex = 0;
            lblAuditLogTitle.Text = "Audit Log";
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.BackColor = Color.White;
            pnlUserManagement.BorderStyle = BorderStyle.FixedSingle;
            pnlUserManagement.Controls.Add(lblUserManagementTitle);
            pnlUserManagement.Location = new Point(20, 220);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Size = new Size(850, 400);
            pnlUserManagement.TabIndex = 1;
            // 
            // lblUserManagementTitle
            // 
            lblUserManagementTitle.AutoSize = true;
            lblUserManagementTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserManagementTitle.Location = new Point(10, 10);
            lblUserManagementTitle.Name = "lblUserManagementTitle";
            lblUserManagementTitle.Size = new Size(185, 28);
            lblUserManagementTitle.TabIndex = 0;
            lblUserManagementTitle.Text = "User Management";
            // 
            // pnlCard5
            // 
            pnlCard5.BackColor = Color.White;
            pnlCard5.BorderStyle = BorderStyle.FixedSingle;
            pnlCard5.Controls.Add(lblCard5Title);
            pnlCard5.Location = new Point(1180, 115);
            pnlCard5.Name = "pnlCard5";
            pnlCard5.Size = new Size(270, 80);
            pnlCard5.TabIndex = 2;
            // 
            // lblCard5Title
            // 
            lblCard5Title.AutoSize = true;
            lblCard5Title.ForeColor = Color.Gray;
            lblCard5Title.Location = new Point(10, 15);
            lblCard5Title.Name = "lblCard5Title";
            lblCard5Title.Size = new Size(125, 25);
            lblCard5Title.TabIndex = 0;
            lblCard5Title.Text = "System Health";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.BorderStyle = BorderStyle.FixedSingle;
            pnlCard4.Controls.Add(lblCard4Title);
            pnlCard4.Location = new Point(890, 115);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(270, 80);
            pnlCard4.TabIndex = 3;
            // 
            // lblCard4Title
            // 
            lblCard4Title.AutoSize = true;
            lblCard4Title.ForeColor = Color.Gray;
            lblCard4Title.Location = new Point(10, 15);
            lblCard4Title.Name = "lblCard4Title";
            lblCard4Title.Size = new Size(92, 25);
            lblCard4Title.TabIndex = 0;
            lblCard4Title.Text = "Properties";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.BorderStyle = BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(lblCard3Title);
            pnlCard3.Location = new Point(600, 115);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(270, 80);
            pnlCard3.TabIndex = 4;
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.ForeColor = Color.Gray;
            lblCard3Title.Location = new Point(10, 15);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(71, 25);
            lblCard3Title.TabIndex = 0;
            lblCard3Title.Text = "Tenants";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblCard2Title);
            pnlCard2.Location = new Point(310, 115);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(270, 80);
            pnlCard2.TabIndex = 5;
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.ForeColor = Color.Gray;
            lblCard2Title.Location = new Point(10, 15);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(90, 25);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "Landlords";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblCard1Title);
            pnlCard1.Location = new Point(20, 115);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(270, 80);
            pnlCard1.TabIndex = 6;
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.ForeColor = Color.Gray;
            lblCard1Title.Location = new Point(10, 15);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(97, 25);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "Total Users";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(20, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(371, 25);
            lblSubtitle.TabIndex = 7;
            lblSubtitle.Text = "System administration and user management";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 38);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Admin Dashboard";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 31);
            txtSearch.TabIndex = 9;
            txtSearch.Text = "Search for properties, tenants...";
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.BackColor = Color.Red;
            btnAdminLogout.Location = new Point(45, 743);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(129, 41);
            btnAdminLogout.TabIndex = 1;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // AdminDashboardForm
            // 
            ClientSize = new Size(1724, 825);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlAuditLog.ResumeLayout(false);
            pnlAuditLog.PerformLayout();
            pnlUserManagement.ResumeLayout(false);
            pnlUserManagement.PerformLayout();
            pnlCard5.ResumeLayout(false);
            pnlCard5.PerformLayout();
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
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Panel pnlCard5;
        private System.Windows.Forms.Label lblCard5Title;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Label lblUserManagementTitle;
        private System.Windows.Forms.Panel pnlAuditLog;
        private System.Windows.Forms.Label lblAuditLogTitle;
        private Button btnAdminLogout;
    }
}