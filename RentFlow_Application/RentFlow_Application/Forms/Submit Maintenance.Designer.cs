namespace RentFlow_Application.Forms
{
    partial class Submit_Maintenancefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaintenanceRequest = new Label();
            lblIssueCategory = new Label();
            lblDescription = new Label();
            lblPriority = new Label();
            cmbIssueCatagory = new ComboBox();
            txtDescribtion = new TextBox();
            cmbPritority = new ComboBox();
            btnSubmitRequest = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMaintenanceRequest
            // 
            lblMaintenanceRequest.AutoSize = true;
            lblMaintenanceRequest.FlatStyle = FlatStyle.Flat;
            lblMaintenanceRequest.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintenanceRequest.Location = new Point(12, 31);
            lblMaintenanceRequest.Margin = new Padding(2, 0, 2, 0);
            lblMaintenanceRequest.Name = "lblMaintenanceRequest";
            lblMaintenanceRequest.Padding = new Padding(20, 0, 0, 0);
            lblMaintenanceRequest.Size = new Size(422, 38);
            lblMaintenanceRequest.TabIndex = 10;
            lblMaintenanceRequest.Text = "Submit Maintenance Request";
            // 
            // lblIssueCategory
            // 
            lblIssueCategory.AutoSize = true;
            lblIssueCategory.BackColor = Color.Transparent;
            lblIssueCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueCategory.ForeColor = Color.DimGray;
            lblIssueCategory.Location = new Point(41, 90);
            lblIssueCategory.Name = "lblIssueCategory";
            lblIssueCategory.Size = new Size(124, 23);
            lblIssueCategory.TabIndex = 11;
            lblIssueCategory.Text = "Issue Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(41, 184);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            lblDescription.Click += lblDescription_Click;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.BackColor = Color.Transparent;
            lblPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.DimGray;
            lblPriority.Location = new Point(41, 433);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(65, 23);
            lblPriority.TabIndex = 13;
            lblPriority.Text = "Priority";
            // 
            // cmbIssueCatagory
            // 
            cmbIssueCatagory.FormattingEnabled = true;
            cmbIssueCatagory.Items.AddRange(new object[] { "Plumbing", "Electrical", "Appliances", "Structural", "Other", "" });
            cmbIssueCatagory.Location = new Point(41, 126);
            cmbIssueCatagory.Name = "cmbIssueCatagory";
            cmbIssueCatagory.Size = new Size(418, 28);
            cmbIssueCatagory.TabIndex = 14;
            // 
            // txtDescribtion
            // 
            txtDescribtion.Location = new Point(41, 221);
            txtDescribtion.Multiline = true;
            txtDescribtion.Name = "txtDescribtion";
            txtDescribtion.PlaceholderText = "Describe the issue in detail..";
            txtDescribtion.Size = new Size(418, 186);
            txtDescribtion.TabIndex = 15;
            // 
            // cmbPritority
            // 
            cmbPritority.FormattingEnabled = true;
            cmbPritority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPritority.Location = new Point(41, 479);
            cmbPritority.Name = "cmbPritority";
            cmbPritority.Size = new Size(418, 28);
            cmbPritority.TabIndex = 16;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.FromArgb(37, 99, 235);
            btnSubmitRequest.Cursor = Cursors.Hand;
            btnSubmitRequest.FlatAppearance.BorderSize = 0;
            btnSubmitRequest.FlatStyle = FlatStyle.Flat;
            btnSubmitRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(41, 550);
            btnSubmitRequest.Margin = new Padding(2);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(307, 40);
            btnSubmitRequest.TabIndex = 17;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(365, 550);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 40);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Submit_Maintenancefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 630);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitRequest);
            Controls.Add(cmbPritority);
            Controls.Add(txtDescribtion);
            Controls.Add(cmbIssueCatagory);
            Controls.Add(lblPriority);
            Controls.Add(lblDescription);
            Controls.Add(lblIssueCategory);
            Controls.Add(lblMaintenanceRequest);
            Name = "Submit_Maintenancefrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submit_Maintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintenanceRequest;
        private Label lblIssueCategory;
        private Label lblDescription;
        private Label lblPriority;
        private ComboBox cmbIssueCatagory;
        private TextBox txtDescribtion;
        private ComboBox cmbPritority;
        private Button btnSubmitRequest;
        private Button btnCancel;
    }
}