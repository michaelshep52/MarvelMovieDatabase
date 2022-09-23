using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace SM.BL
{
    public class Address
    {
        public Address()
        {
        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
       

        //Validate address
        public bool Validate() //Validated customer data.
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Street1)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (PostalCode == null) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }
    }
}

