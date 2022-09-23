using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BL
{
    public class Customer
    {
        public Customer() //default contructor (ctor)
        {

        }
        public Customer(int customerId) //overload contructor.
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set;}//Fetch snippet (propg)
        
        public string EmailAddress { get; set; } //fetched from snippets (prop)

        public string FirstName { get; set; }  //Here are two different ways

        private string _lastName;       //(backing field) //To write the same code.
        public string LastName          //Declaring property
        {       
            get                          //if you want to make it a write only you leave this out.
            {
                return _lastName;
            }
            set                          //if you want a read only leave set out.
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }



        //Validate
        public bool Validate() //Validated customer data.
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}

