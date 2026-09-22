using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using RentFlow_Application.Classes;
using RentFlow_Application;



namespace RentFlow_Application.Forms
{
    public partial class Forgot_Password : Form
    {
        List<User> RegisteredUser;
        User founderUser;
        string generatedOTP = "";
        public Forgot_Password()
        {
            InitializeComponent();
            RegisteredUser = FileManager.LoadUsers();
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            lblOTP.Visible = false;
            txtOTP.Visible = false;
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string id = txtIDNumber.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            lblNewPassword.Visible = true;
            txtNewPassword.Visible = true;
            lblConfirmPassword.Visible = true;
            txtConfirmPassword.Visible = true;
            lblOTP.Visible = true;
            txtOTP.Visible = true;

            if (id == "" || phone == "")
            {
                MessageBox.Show("Enter ID and Phone Number", "Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            founderUser = null;
            foreach (User A_user in RegisteredUser)
            {
                if (A_user.GetIDNumber() == id && A_user.GetPhoneNumber() == phone)
                {
                    founderUser = A_user;
                    break;
                }
            }
            if (founderUser == null)
            {
                MessageBox.Show("No user is found with that ID and phone , please check your ID number and Phone Number", "Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random number = new Random();
            generatedOTP = number.Next(1000, 9999).ToString();

            MessageBox.Show($"RentFlow OTP for {founderUser.GetName()}\n Your OTP is: {generatedOTP}\n Sent to : {phone}", "OTP sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            
            if (founderUser == null)
            {
                MessageBox.Show("First click send OTP");
                return;

            }
            if (txtOTP.Text.Trim() != generatedOTP)
            {
                MessageBox.Show("Wrong OTP , Enter code: " + generatedOTP);
                return;

            }
            if (txtNewPassword.Text.Trim().Length < 4)
            {
                MessageBox.Show("New password must be atleast 4 characters");
                return;
            }

            founderUser.SetPassword(txtNewPassword.Text.Trim());

            FileManager.SaveUsers(RegisteredUser);

            MessageBox.Show("Password changed successfully! You can login now.", "Changed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
