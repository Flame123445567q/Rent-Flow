using System;
using System.Collections.Generic;
using System.Text;




namespace RentFlow_Application.Classes
{
    public class User
    {
        // Properties
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        // Parameterless constructor (required for object initializer)
        public User() { }

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
    }
}