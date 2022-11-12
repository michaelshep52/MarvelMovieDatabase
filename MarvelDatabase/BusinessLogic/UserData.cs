using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;

namespace BusinessLogic
{
    public class UserData
    {
        public string? FirstName { get; set;}
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        
        public UserData() { }

        public UserData(string firstName, string lastName, string emailAddress, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Username = username;
            Password = password;
        }
         public override string ToString()
        {
            string us = $"Name: {FirstName} {LastName} " +
                $"\nEmailAddress: {EmailAddress} " +
                $"\nUsername: {Username} " +
                $"\nPassword: {Password} ";
            return us;
        }
        public UserData Retrieve() 
        {
            return new UserData();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true; 
            
            if(string.IsNullOrWhiteSpace(FirstName))
            {
                Console.WriteLine("First name is required to continue!");
                isValid = false;
            } 
            if(string.IsNullOrWhiteSpace(LastName)) 
            {
                Console.WriteLine("Last name is required to continue!");
                isValid = false;
            } 
            if(string.IsNullOrWhiteSpace(EmailAddress)) 
            {
                Console.WriteLine("EmailAddress is required to continue!");
                isValid = false;
            } 
            if(string.IsNullOrWhiteSpace(Username)) 
            {
                Console.WriteLine("Username is required to continue!");
                isValid = false;
            } 
            if(string.IsNullOrWhiteSpace(Password)) 
            {
                Console.WriteLine("Password is required to continue!");
                isValid = false;
            } 
            return isValid;
            
        }
        public bool CredentialCheck()
        {
            var hasCreds = true;

            if (string.IsNullOrWhiteSpace(Username)) throw new ArgumentNullException("Username is required.");
                const int MinUsernameLength = 5; if (Username.Length < MinUsernameLength) throw new ArgumentNullException("Username must contain at least 5 letters!");
                const int MaxUsernameLength = 15; if (Username.Length > MaxUsernameLength) throw new ArgumentNullException("Username can't contain over 20 letters!");
            if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentNullException("Password is required.");
                    const int MinPasswordLength = 5; if (Password.Length < MinPasswordLength) throw new ArgumentNullException("Password must contain at least 6 letters!");
                    const int MaxPasswordLength = 15; if (Password.Length > MaxPasswordLength) throw new ArgumentNullException("Password can't contain over 25 letters!");
            return hasCreds;
    

        }
    }
}

