namespace RentFlow_Application
{
    partial class RegisterForm2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblTitle = new Label();
            lblSlogan = new Label();
            lblRoles = new Label();
            cmbRoles = new ComboBox();
            lblFull_Name = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            btnRegisterAccount = new Button();
            lblIDNumber = new Label();
            txtFull_Name = new TextBox();
            txtSurname = new TextBox();
            txtIDNumber = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 51);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(290, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(552, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Your RentFlow🏢 Account";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = SystemColors.ButtonFace;
            lblSlogan.Location = new Point(369, 108);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(359, 28);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Start managing your properties today.";
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoles.Location = new Point(310, 162);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(101, 25);
            lblRoles.TabIndex = 3;
            lblRoles.Text = "Register as ";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "Landlord", "Tenant", "Admin" });
            cmbRoles.Location = new Point(468, 176);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(326, 28);
            cmbRoles.TabIndex = 4;
            // 
            // lblFull_Name
            // 
            lblFull_Name.AutoSize = true;
            lblFull_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblFull_Name.Location = new Point(317, 217);
            lblFull_Name.Name = "lblFull_Name";
            lblFull_Name.Size = new Size(94, 25);
            lblFull_Name.TabIndex = 5;
            lblFull_Name.Text = "Full Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblSurname.Location = new Point(325, 272);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(86, 25);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblEmail.Location = new Point(290, 382);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(121, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblPhoneNumber.Location = new Point(281, 437);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(130, 25);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblPassword.Location = new Point(326, 492);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 25);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblConfirmPassword.Location = new Point(258, 547);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(153, 25);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.FromArgb(49, 87, 212);
            btnRegisterAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAccount.ForeColor = SystemColors.ButtonFace;
            btnRegisterAccount.Location = new Point(258, 617);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(536, 60);
            btnRegisterAccount.TabIndex = 12;
            btnRegisterAccount.Text = "Register Account";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(307, 327);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(104, 25);
            lblIDNumber.TabIndex = 13;
            lblIDNumber.Text = "ID Number ";
            // 
            // txtFull_Name
            // 
            txtFull_Name.Location = new Point(468, 235);
            txtFull_Name.Name = "txtFull_Name";
            txtFull_Name.PlaceholderText = "First Name";
            txtFull_Name.Size = new Size(326, 27);
            txtFull_Name.TabIndex = 14;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(468, 287);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Last Name";
            txtSurname.Size = new Size(326, 27);
            txtSurname.TabIndex = 15;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(468, 340);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PlaceholderText = "South African ID";
            txtIDNumber.Size = new Size(326, 27);
            txtIDNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(468, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "you@example.com";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(468, 448);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "eg.+27 82 123 4567";
            txtPhoneNumber.Size = new Size(326, 27);
            txtPhoneNumber.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(468, 503);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password(6 or more characters)";
            txtPassword.Size = new Size(326, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(468, 558);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(326, 27);
            txtConfirmPassword.TabIndex = 20;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 87, 212);
            ClientSize = new Size(1000, 711);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtIDNumber);
            Controls.Add(txtSurname);
            Controls.Add(txtFull_Name);
            Controls.Add(lblIDNumber);
            Controls.Add(btnRegisterAccount);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblSurname);
            Controls.Add(lblFull_Name);
            Controls.Add(cmbRoles);
            Controls.Add(lblRoles);
            Controls.Add(lblSlogan);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "RegisterForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private Label lblSlogan;
        private Label lblRoles;
        private ComboBox cmbRoles;
        private Label lblFull_Name;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Button btnRegisterAccount;
        private Label lblIDNumber;
        private TextBox txtFull_Name;
        private TextBox txtSurname;
        private TextBox txtIDNumber;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ErrorProvider errorProvider1;
    }
}