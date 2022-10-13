using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.BL.cs;

namespace SM.BL
{
    public class CustomerRepository 
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        //Retrieve

        public Customer Retrieve(int customerId)
        {
                                                            //code that retrieves defined customer.
            Customer customer = new Customer(customerId);

            if (customerId ==1)
            {
                customer.EmailAddress = "mshepherd@got.you";
                customer.FirstName = "Michael";
                customer.LastName = "Shepherd";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        

        //Save
        public bool save(Customer customer)
        {
                                                        // code that saves defined customer
            return true;
        }
    }
}

