//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using HealthcareManagementSystem.Utilities;
using System.Security.Cryptography;
using HealthcareManagementSystem.DAL;

namespace HealthcareManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.IsSuperUser = false;
        }

        public User(int id, string firstname, string lastname, string cin, DateTime selectedDate, string password, bool superUser,
                        string phoneNumber, string role, string city)
        {
            this.IdUser = id;
            this.Fisrtname = firstname;
            this.Lastname = lastname;
            this.CIN = cin;
            this.DateOfBirth = selectedDate;
            this.HashedPassword = password;
            this.IsSuperUser = superUser;
            this.PhoneNumber = phoneNumber;
            this.Role = role;
            this.City = CityDAO.GetCityByName(city);
        }

        public User(string firstname, string lastname, string cin, DateTime selectedDate, string password, bool superUser, 
                        string phoneNumber, string role, string city)
        {
            this.Fisrtname = firstname;
            this.Lastname = lastname;
            this.CIN = cin;
            this.DateOfBirth = selectedDate;
            this.HashedPassword = password;
            this.IsSuperUser = superUser;
            this.PhoneNumber = phoneNumber;
            this.Role = role;
            this.City = CityDAO.GetCityByName(city);
        }

        public int IdUser { get; set; }
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public bool IsSuperUser { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public string HashedPassword { get; set; }
        public string Password
        {
            set { HashedPassword = PasswordUtilities.ComputeHash(value, new MD5CryptoServiceProvider()); }
        }
        public string CIN { get; set; }
    
        public virtual City City { get; set; }
    }
}
