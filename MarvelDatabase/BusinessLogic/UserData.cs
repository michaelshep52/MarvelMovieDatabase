using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;

namespace BusinessLogic
{
    public class UserData
    {
        public UserData()
        {

        }
        private string _FirstName;
        private string _LastName;
        private string _EmailAddress;
        private string _Username;
        private string _Password;
        public UserData(string FirstName, string LastName, string EmailAddress, string Username, string Password)
        {
        _FirstName = FirstName;
        _LastName = LastName;
        _EmailAddress = EmailAddress;
        _Username = Username;
        _Password = Password;
        }
        public string GetFirstName()
        {
            return _FirstName;
        }
        public void SetFirstName(string FirstName)
        {
            _FirstName = FirstName;
        }
        public string GetLastName()
        {
            return _LastName;
        }
        public void SetLastName(string LastName)
        {
            _LastName = LastName;
        }
        public string GetEmailAddress()
        {
            return _EmailAddress;
        }
        public void SetEmailAddress(string EmailAddress)
        {
            _EmailAddress = EmailAddress;
        }
        public string GetUsername()
        {
            return _Username;
        }
        public void SetUsername(string Username)
        {
            _Username = Username;
        }
        public string GetPassword()
        {
            return _Password;
        }
        public void SetPassword(string Password)
        {
            _Password = Password;
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
            
            if(string.IsNullOrWhiteSpace(_FirstName)) isValid = false;
            if(string.IsNullOrWhiteSpace(_LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(_EmailAddress)) isValid = false;
            if(string.IsNullOrWhiteSpace(_Username)) isValid = false;
            if(string.IsNullOrWhiteSpace(_Password)) isValid = false;
            return isValid;
        }
    }
}

