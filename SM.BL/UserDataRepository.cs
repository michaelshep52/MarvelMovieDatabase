using System;
namespace SM.BL.cs
{
    public class UserDataRepository
    {

    public UserData Retrieve(int UserId)
    {
        UserData userData = new UserData(UserId);
            if (UserId == 1)
            {
                userData.EmailAddress = "mshepherd@got.you";
                userData.FirstName = "Michael";
                userData.LastName = "Shepherd";
                userData.Username = "Getradaway76";
                userData.Password = "Fallout76!";
            }
        return userData;
    }


    //Save
    public bool save(UserData userData)
    {
        
        return true;
    }
}
}

