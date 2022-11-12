using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using BusinessLogic;

namespace MarvelDatabase.BusinessLogic
{
    public class ActiveUser : UserData
    {
        public ActiveUser(){}
        public bool FindActiveUser()
        {
            var userData = new UserData();

            var isActive = true;
            if(!Convert.ToBoolean(userData.FirstName)) isActive = false;
            
            if(!Convert.ToBoolean(userData.LastName)) isActive = false;

            if(!Convert.ToBoolean(userData.EmailAddress)) isActive = false;
            
            if(!Convert.ToBoolean(userData.Username)) isActive = false;
            
            if(!Convert.ToBoolean(userData.Password)) isActive = false;
            
            return isActive;

        }

    }
}