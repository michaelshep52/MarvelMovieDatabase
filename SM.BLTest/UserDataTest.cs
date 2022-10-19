using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;
using SM.BL;
using SM.BL.cs;

namespace SM.BLTest
{
    public class UserDataTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            UserData userData = new UserData();
            userData.FirstName = "Michael";        
            userData.LastName = "Shepherd";         

            string expected = "Shepherd, Michael";

            //--Act
            String actual = userData.FullName;

            //-- Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestMethod]
        public void ValideUserName()
        {
            //--Arrange
            UserData userData = new UserData();
            userData.Username = "Mikeboyshep";


            string expected = "Mikeboyshep";

            //--Act
            String actual = userData.Username;

            //-- Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestMethod]
        public void InvalideUserName()
        {
            //--Arrange
            UserData userData = new UserData();
            userData.Username = "kissass";


            string expected = "kissass";

            //--Act
            String actual = userData.Username;

            //-- Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        private class TestClassAttribute : Attribute
        {
        }

        private class TestMethodAttribute : Attribute
        {
        }
    }
}
