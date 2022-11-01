using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;

namespace BusinessLogic
{
    public class UserAccount
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string? ChangePassword { get; set; }

        private List<UserAccount> _userAccount { get; set; }
        public void AddUserAccount(UserAccount userAccount)
        {
            _userAccount.Add(userAccount);
        }
    

    }
}