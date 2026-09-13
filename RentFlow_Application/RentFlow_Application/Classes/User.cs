using System;
using System.Collections.Generic;
using System.Text;




namespace RentFlow_Application.Classes
{
    public class User
    {
        // Properties
        private string Role;
        private string FullName;
        private string Surname;
        private string IDNumber;
        private string Email;
        private string PhoneNumber;
        private string Password;

        // Parameterless constructor (required for object initializer)
       

        // Full constructor (optional)
        public User(string role, string fullName, string surname, string idNumber,
                    string email, string phoneNumber, string password)
        {
            Role = role;
            FullName = fullName;
            Surname = surname;
            IDNumber = idNumber;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
        
        public string GetRole()
        {
            return Role;
        }
        public string GetName()
        {
            return FullName;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetIDNumber()
        {
            return IDNumber;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
    }
}