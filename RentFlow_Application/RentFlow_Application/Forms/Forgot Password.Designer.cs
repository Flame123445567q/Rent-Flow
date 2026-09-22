namespace RentFlow_Application.Forms
{
    partial class Forgot_Password
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
            lblIDNumber = new Label();
            lblPhoneNumber = new Label();
            lblOTP = new Label();
            lblNewPassword = new Label();
            txtIDNumber = new TextBox();
            txtNewPassword = new TextBox();
            txtOTP = new TextBox();
            txtPhoneNumber = new TextBox();
            btnReset = new Button();
            btnSendOTP = new Button();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Location = new Point(10, 7);
            lblIDNumber.Margin = new Padding(2, 0, 2, 0);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(169, 20);
            lblIDNumber.TabIndex = 0;
            lblIDNumber.Text = "Enter ID your ID number";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(10, 58);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(177, 20);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "Enter your phone number";
            // 
            // lblOTP
            // 
            lblOTP.AutoSize = true;
            lblOTP.Location = new Point(10, 104);
            lblOTP.Margin = new Padding(2, 0, 2, 0);
            lblOTP.Name = "lblOTP";
            lblOTP.Size = new Size(77, 20);
            lblOTP.TabIndex = 2;
            lblOTP.Text = "Enter OTP ";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(10, 153);
            lblNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(148, 20);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Create new Password";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(197, 10);
            txtIDNumber.Margin = new Padding(2);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(260, 27);
            txtIDNumber.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(197, 148);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(260, 27);
            txtNewPassword.TabIndex = 5;
            // 
            // txtOTP
            // 
            txtOTP.Location = new Point(197, 99);
            txtOTP.Margin = new Padding(2);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(260, 27);
            txtOTP.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(197, 56);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(260, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.BackColor = Color.FromArgb(37, 99, 235);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(178, 301);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(158, 50);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset New Password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BackColor = Color.FromArgb(37, 99, 235);
            btnSendOTP.FlatAppearance.BorderSize = 0;
            btnSendOTP.FlatStyle = FlatStyle.Flat;
            btnSendOTP.ForeColor = Color.White;
            btnSendOTP.Location = new Point(10, 301);
            btnSendOTP.Margin = new Padding(2);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(122, 49);
            btnSendOTP.TabIndex = 9;
            btnSendOTP.Text = "Send OTP";
            btnSendOTP.UseVisualStyleBackColor = false;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(10, 197);
            lblConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(197, 192);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(260, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 360);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(btnSendOTP);
            Controls.Add(btnReset);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtOTP);
            Controls.Add(txtNewPassword);
            Controls.Add(txtIDNumber);
            Controls.Add(lblNewPassword);
            Controls.Add(lblOTP);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblIDNumber);
            Margin = new Padding(2);
            Name = "Forgot_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot_Password";
            Load += Forgot_Password_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDNumber;
        private Label lblPhoneNumber;
        private Label lblOTP;
        private Label lblNewPassword;
        private TextBox txtIDNumber;
        private TextBox txtNewPassword;
        private TextBox txtOTP;
        private TextBox txtPhoneNumber;
        private Button btnReset;
        private Button btnSendOTP;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
    }
}