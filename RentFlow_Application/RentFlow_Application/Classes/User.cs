using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    public class User
    {
        // Private backing fields 
        private string role;
        private string fullName;
        private string surname;
        private string idNumber;
        private string email;
        private string phoneNumber;
        private string password;

        // Public properties that expose the values (code elsewhere expects these names)
        public string Role { get => role; set => role = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string IDNumber { get => idNumber; set => idNumber = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }

        // Parameterless constructor (required for object initializer)
        public User() { }

        // Full constructor (optional)
        public User(string role, string fullName, string surname, string idNumber,
                    string email, string phoneNumber, string password)
        {
            this.role = role;
            this.fullName = fullName;
            this.surname = surname;
            this.idNumber = idNumber;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.password = password;
        }

        // Getter methods (kept for compatibility)
        public string GetRole() => role;
        public string GetName() => fullName;
        public string GetSurname() => surname;
        public string GetIDNumber() => idNumber;
        public string GetEmail() => email;
        public string GetPhoneNumber() => phoneNumber;
        public string GetPassword() => password;
        public void SetPassword(string newPassword) => password = newPassword;
    }
}
