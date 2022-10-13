using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using SM.BL.cs;
using SM.COM.cs;

namespace SM.BL
{
    public class Customer : EntityBase, ILoggable
    {

        public Customer(): this(0)  //default contructor (ctor)
        {

        }
        public Customer(int customerId) //overload contructor.
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set;}//Fetch snippet (propg)
        public List<Address> AddressList { get; set; }
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
        public object EntityState { get; private set; }

        /* public string Log()
         {
             var LogString = CustomerId + ": " +
                             FullName + " " +
                             "Email: " + EmailAddress + " " +
                             "Status: " + EntityState.ToString();
             return LogString;
         }
                                OR Written:*/
        public string Log() =>
             $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";


        public override string ToString() => FullName;

        //Validate
        public override bool Validate() //Validated customer data.
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
         
        }

    }
}

