using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;

namespace BusinessLogic
{
    public class UserData
    {
        public UserData(): this(0)
        {

        }
        public UserData(int userId)
        {
            UserId = userId;
        }
        
        public int UserId { get; private set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
   
        public UserData(int UserId, string Username, string Password, string EmailAddress, string FirstName, string LastName)
        {
            this.UserId = UserId;
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void getUserInfo()
        {
            Console.WriteLine($"Your Account information: {FirstName} {LastName} {EmailAddress} {Username}");
        }

        public bool ValidateData()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) throw new ArgumentNullException("First name is required.");
            if (string.IsNullOrWhiteSpace(LastName)) throw new ArgumentNullException("Last name is required.");
            if (string.IsNullOrWhiteSpace(EmailAddress)) throw new ArgumentNullException("EmailAddress is required.");
            if (string.IsNullOrWhiteSpace(Username)) throw new ArgumentNullException("Username is required.");
            if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentNullException("Password is required.");

            return isValid;

        }
        private bool ValidateUsername(string username, string password)
        {
            const int MinUsernameLength = 10; if (username.Length < MinUsernameLength) return false;
            const int MinPasswordLength = 6; if (password.Length < MinPasswordLength) return false;
            const int MaxUsernameLength = 20; if (username.Length > MaxUsernameLength) return false;
            const int MaxPasswordLength = 25; if (password.Length > MaxPasswordLength) return false;

            bool ContainsLettersNumbers = username.All(char.IsLetterOrDigit) | password.All(char.IsLetterOrDigit);
            if (!ContainsLettersNumbers) return false;


            if (ContainsInappropriateWords(username, password)) return false;

            return ValidateUsername(username, password);
        }

        private bool ContainsInappropriateWords(string username, string password)
        {
            string[] inappropriateWords = { "Dick", "Ass", "Retard", "Cunt", "Shitty" };
            throw new ArgumentException("Username can not contain inappropriate words.");
        }
        
    }
}

