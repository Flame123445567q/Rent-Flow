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
            pnlPaymentDue = new RoundedPanel();
            lblDueDate = new Label();
            lblAmountValue = new Label();
            lblAmountDueTag = new Label();
            btnMakePayment = new Button();
            lblNextPayment = new Label();
            pnlLeaseD = new RoundedPanel();
            lblLeaseDetails = new Label();
            roundedPanel4 = new RoundedPanel();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            roundedPanel3 = new RoundedPanel();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            roundedPanel2 = new RoundedPanel();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            lblGreetings = new Label();
            roundedPanel1 = new RoundedPanel();
            lblValue1 = new Label();
            label1 = new Label();
            pnlIcon1 = new Panel();
            lblIcon = new Label();
            btnMaintenance = new Button();
            lblMyDashboard = new Label();
            lblLeaseDetailsTitle = new Label();
            lblPaymentHistoryTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlPaymentDue.SuspendLayout();
            pnlLeaseD.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            pnlIcon1.SuspendLayout();
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
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(176, 753);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(11, 696);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(138, 31);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "\u23fb Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyDashBoard
            // 
            btnMyDashBoard.BackColor = Color.FromArgb(37, 99, 235);
            btnMyDashBoard.FlatAppearance.BorderSize = 0;
            btnMyDashBoard.FlatStyle = FlatStyle.Flat;
            btnMyDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyDashBoard.ForeColor = Color.Silver;
            btnMyDashBoard.Location = new Point(11, 76);
            btnMyDashBoard.Margin = new Padding(2);
            btnMyDashBoard.Name = "btnMyDashBoard";
            btnMyDashBoard.Size = new Size(160, 45);
            btnMyDashBoard.TabIndex = 0;
            btnMyDashBoard.Text = "My DashBoard";
            btnMyDashBoard.UseVisualStyleBackColor = false;
            btnMyDashBoard.Click += btnMyDashBoard_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(26, 21);
            lblLogo.Margin = new Padding(2, 0, 2, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(111, 31);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Rentflow";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(249, 250, 251);
            pnlMain.Controls.Add(pnlPaymentDue);
            pnlMain.Controls.Add(pnlLeaseD);
            pnlMain.Controls.Add(roundedPanel4);
            pnlMain.Controls.Add(roundedPanel3);
            pnlMain.Controls.Add(roundedPanel2);
            pnlMain.Controls.Add(lblGreetings);
            pnlMain.Controls.Add(roundedPanel1);
            pnlMain.Controls.Add(btnMaintenance);
            pnlMain.Controls.Add(lblMyDashboard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(176, 0);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1206, 753);
            pnlMain.TabIndex = 0;
            // 
            // pnlPaymentDue
            // 
            pnlPaymentDue.BackColor = Color.White;
            pnlPaymentDue.Controls.Add(lblDueDate);
            pnlPaymentDue.Controls.Add(lblAmountValue);
            pnlPaymentDue.Controls.Add(lblAmountDueTag);
            pnlPaymentDue.Controls.Add(btnMakePayment);
            pnlPaymentDue.Controls.Add(lblNextPayment);
            pnlPaymentDue.Location = new Point(606, 324);
            pnlPaymentDue.Name = "pnlPaymentDue";
            pnlPaymentDue.Size = new Size(588, 333);
            pnlPaymentDue.TabIndex = 14;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.White;
            lblDueDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblDueDate.Location = new Point(207, 196);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(176, 20);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due by 1 Novemver 2027";
            // 
            // lblAmountValue
            // 
            lblAmountValue.AutoSize = true;
            lblAmountValue.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountValue.ForeColor = Color.Black;
            lblAmountValue.Location = new Point(219, 120);
            lblAmountValue.Name = "lblAmountValue";
            lblAmountValue.Size = new Size(152, 62);
            lblAmountValue.TabIndex = 4;
            lblAmountValue.Text = "R0.00";
            // 
            // lblAmountDueTag
            // 
            lblAmountDueTag.AutoSize = true;
            lblAmountDueTag.BackColor = Color.White;
            lblAmountDueTag.ForeColor = Color.FromArgb(100, 116, 139);
            lblAmountDueTag.Location = new Point(247, 67);
            lblAmountDueTag.Name = "lblAmountDueTag";
            lblAmountDueTag.Size = new Size(105, 20);
            lblAmountDueTag.TabIndex = 3;
            lblAmountDueTag.Text = "\tAMOUNT DUE";
            // 
            // btnMakePayment
            // 
            btnMakePayment.BackColor = Color.FromArgb(37, 99, 235);
            btnMakePayment.Cursor = Cursors.Hand;
            btnMakePayment.FlatAppearance.BorderSize = 0;
            btnMakePayment.FlatStyle = FlatStyle.Flat;
            btnMakePayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMakePayment.ForeColor = Color.White;
            btnMakePayment.Location = new Point(89, 247);
            btnMakePayment.Margin = new Padding(2);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(453, 40);
            btnMakePayment.TabIndex = 3;
            btnMakePayment.Text = "💳 Make a Payment";
            btnMakePayment.UseVisualStyleBackColor = false;
            // 
            // lblNextPayment
            // 
            lblNextPayment.AutoSize = true;
            lblNextPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNextPayment.Location = new Point(11, 15);
            lblNextPayment.Name = "lblNextPayment";
            lblNextPayment.Size = new Size(147, 28);
            lblNextPayment.TabIndex = 0;
            lblNextPayment.Text = "Next Payment";
            // 
            // pnlLeaseD
            // 
            pnlLeaseD.BackColor = Color.White;
            pnlLeaseD.Controls.Add(lblLeaseDetails);
            pnlLeaseD.Location = new Point(32, 324);
            pnlLeaseD.Name = "pnlLeaseD";
            pnlLeaseD.Size = new Size(540, 333);
            pnlLeaseD.TabIndex = 13;
            // 
            // lblLeaseDetails
            // 
            lblLeaseDetails.AutoSize = true;
            lblLeaseDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaseDetails.Location = new Point(11, 15);
            lblLeaseDetails.Name = "lblLeaseDetails";
            lblLeaseDetails.Size = new Size(136, 28);
            lblLeaseDetails.TabIndex = 0;
            lblLeaseDetails.Text = "Lease Details";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(label8);
            roundedPanel4.Controls.Add(label9);
            roundedPanel4.Controls.Add(panel3);
            roundedPanel4.Location = new Point(932, 133);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(260, 90);
            roundedPanel4.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(71, 45);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 2;
            label8.Text = "R0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = Color.FromArgb(100, 116, 139);
            label9.Location = new Point(71, 20);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 1;
            label9.Text = "Outstanding Balance";
            label9.Click += label9_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(209, 250, 229);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(15, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 50);
            panel3.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(16, 185, 129);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 41);
            label10.TabIndex = 0;
            label10.Text = "💰";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.Controls.Add(label5);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Controls.Add(panel2);
            roundedPanel3.Location = new Point(642, 133);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(260, 90);
            roundedPanel3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(71, 45);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 2;
            label5.Text = "31 December 2027";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.FromArgb(100, 116, 139);
            label6.Location = new Point(71, 20);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 1;
            label6.Text = "Lease Expires";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 215, 170);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(15, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 50);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(234, 88, 12);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 41);
            label7.TabIndex = 0;
            label7.Text = "📅";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(panel1);
            roundedPanel2.Location = new Point(362, 133);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(260, 90);
            roundedPanel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(71, 45);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Unit 101";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(71, 20);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Current Unit";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 233, 254);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(15, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(139, 92, 246);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 41);
            label4.TabIndex = 0;
            label4.Text = "🚪";
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.BackColor = Color.White;
            lblGreetings.ForeColor = Color.FromArgb(100, 116, 139);
            lblGreetings.Location = new Point(28, 89);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(369, 20);
            lblGreetings.TabIndex = 3;
            lblGreetings.Text = "Welcome back, Amahle. Here is your account overview";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(lblValue1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(pnlIcon1);
            roundedPanel1.Location = new Point(28, 133);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(311, 90);
            roundedPanel1.TabIndex = 10;
            // 
            // lblValue1
            // 
            lblValue1.AutoSize = true;
            lblValue1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValue1.ForeColor = Color.Black;
            lblValue1.Location = new Point(71, 45);
            lblValue1.Name = "lblValue1";
            lblValue1.Size = new Size(201, 25);
            lblValue1.TabIndex = 2;
            lblValue1.Text = "Greenview Residences";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(71, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Current Property";
            // 
            // pnlIcon1
            // 
            pnlIcon1.BackColor = Color.FromArgb(219, 234, 254);
            pnlIcon1.Controls.Add(lblIcon);
            pnlIcon1.Location = new Point(15, 20);
            pnlIcon1.Name = "pnlIcon1";
            pnlIcon1.Size = new Size(50, 50);
            pnlIcon1.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.BackColor = Color.Transparent;
            lblIcon.Dock = DockStyle.Fill;
            lblIcon.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(59, 41);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "🏢";
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.FromArgb(37, 99, 235);
            btnMaintenance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(332, 692);
            btnMaintenance.Margin = new Padding(2);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(531, 50);
            btnMaintenance.TabIndex = 2;
            btnMaintenance.Text = "🔧 Submit Maintenance Request";
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // lblMyDashboard
            // 
            lblMyDashboard.AutoSize = true;
            lblMyDashboard.FlatStyle = FlatStyle.Flat;
            lblMyDashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyDashboard.Location = new Point(16, 44);
            lblMyDashboard.Margin = new Padding(2, 0, 2, 0);
            lblMyDashboard.Name = "lblMyDashboard";
            lblMyDashboard.Padding = new Padding(20, 0, 0, 0);
            lblMyDashboard.Size = new Size(229, 38);
            lblMyDashboard.TabIndex = 9;
            lblMyDashboard.Text = "My Dashboard";
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Margin = new Padding(2);
            Name = "TenantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlPaymentDue.ResumeLayout(false);
            pnlPaymentDue.PerformLayout();
            pnlLeaseD.ResumeLayout(false);
            pnlLeaseD.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            pnlIcon1.ResumeLayout(false);
            pnlIcon1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMyDashBoard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMyDashboard;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lblLeaseDetailsTitle;
        private System.Windows.Forms.Label lblPaymentHistoryTitle;
        private Button btnLogout;
        private RoundedPanel roundedPanel1;
        private Label label1;
        private Panel pnlIcon1;
        private Label lblIcon;
        private Label lblGreetings;
        private Label lblValue1;
        private RoundedPanel roundedPanel3;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private RoundedPanel roundedPanel2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private RoundedPanel roundedPanel4;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private RoundedPanel pnlLeaseD;
        private Label lblLeaseDetails;
        private RoundedPanel pnlPaymentDue;
        private Label lblNextPayment;
        private Button btnMakePayment;
        private Label lblAmountValue;
        private Label lblAmountDueTag;
        private Label lblDueDate;
    }
}