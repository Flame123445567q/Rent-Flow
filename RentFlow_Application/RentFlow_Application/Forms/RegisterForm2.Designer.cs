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
            label1.Location = new Point(461, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(362, 64);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(648, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Your RentFlow🏢 Account";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = SystemColors.ButtonFace;
            lblSlogan.Location = new Point(461, 135);
            lblSlogan.Margin = new Padding(4, 0, 4, 0);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(432, 32);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Start managing your properties today.";
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoles.Location = new Point(388, 202);
            lblRoles.Margin = new Padding(4, 0, 4, 0);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(123, 30);
            lblRoles.TabIndex = 3;
            lblRoles.Text = "Register as ";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "Landlord", "Tenant", "Admin" });
            cmbRoles.Location = new Point(585, 220);
            cmbRoles.Margin = new Padding(4, 4, 4, 4);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(406, 33);
            cmbRoles.TabIndex = 4;
            // 
            // lblFull_Name
            // 
            lblFull_Name.AutoSize = true;
            lblFull_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblFull_Name.Location = new Point(396, 271);
            lblFull_Name.Margin = new Padding(4, 0, 4, 0);
            lblFull_Name.Name = "lblFull_Name";
            lblFull_Name.Size = new Size(113, 30);
            lblFull_Name.TabIndex = 5;
            lblFull_Name.Text = "Full Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblSurname.Location = new Point(406, 340);
            lblSurname.Margin = new Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(104, 30);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblEmail.Location = new Point(362, 478);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(148, 30);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblPhoneNumber.Location = new Point(351, 546);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(158, 30);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblPassword.Location = new Point(408, 615);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(104, 30);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblConfirmPassword.Location = new Point(322, 684);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(187, 30);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.Navy;
            btnRegisterAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAccount.ForeColor = SystemColors.ButtonFace;
            btnRegisterAccount.Location = new Point(322, 772);
            btnRegisterAccount.Margin = new Padding(4, 4, 4, 4);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(670, 75);
            btnRegisterAccount.TabIndex = 12;
            btnRegisterAccount.Text = "Register Account";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIDNumber.Location = new Point(384, 409);
            lblIDNumber.Margin = new Padding(4, 0, 4, 0);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(126, 30);
            lblIDNumber.TabIndex = 13;
            lblIDNumber.Text = "ID Number ";
            // 
            // txtFull_Name
            // 
            txtFull_Name.Location = new Point(585, 294);
            txtFull_Name.Margin = new Padding(4, 4, 4, 4);
            txtFull_Name.Name = "txtFull_Name";
            txtFull_Name.PlaceholderText = "First Name";
            txtFull_Name.Size = new Size(406, 31);
            txtFull_Name.TabIndex = 14;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(585, 359);
            txtSurname.Margin = new Padding(4, 4, 4, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Last Name";
            txtSurname.Size = new Size(406, 31);
            txtSurname.TabIndex = 15;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(585, 425);
            txtIDNumber.Margin = new Padding(4, 4, 4, 4);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PlaceholderText = "South African ID";
            txtIDNumber.Size = new Size(406, 31);
            txtIDNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(585, 490);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "you@example.com";
            txtEmail.Size = new Size(406, 31);
            txtEmail.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(585, 560);
            txtPhoneNumber.Margin = new Padding(4, 4, 4, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "eg.+27 82 123 4567";
            txtPhoneNumber.Size = new Size(406, 31);
            txtPhoneNumber.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(585, 629);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password(6 or more characters)";
            txtPassword.Size = new Size(406, 31);
            txtPassword.TabIndex = 19;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(585, 698);
            txtConfirmPassword.Margin = new Padding(4, 4, 4, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(406, 31);
            txtConfirmPassword.TabIndex = 20;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1250, 889);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += RegisterForm2_Load;
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