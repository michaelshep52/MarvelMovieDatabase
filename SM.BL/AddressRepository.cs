using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SM.BL.cs
{
    public class AddressRepository
    { 
        public Address Retrieve(int addressId)
        {
            //code that retrieves.
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street1 = "Panda Lane";
                address.Street2 = "Parker row";
                address.City = "Hazard";
                address.State = "Kentucky";
                address.Country = "USA";
                address.PostalCode = "105";
            }
            return address;
        }
        //to retrieve all address at one time
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                Street1 = "Panda Lane",
                Street2 = "Parker row",
                City = "Hazard",
                State = "Kentucky",
                Country = "USA",
                PostalCode = "105"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                Street1 = "Park corn",
                Street2 = "Prey ley",
                City = "Core",
                State = "Texas",
                Country = "USA",
                PostalCode = "18"
            };
            addressList.Add(address);

            return addressList;
        
        
           
        }

        //Save
        public bool save(Address address)
        {
            // code that saves defined customer
            return true;
        }
    }
}

