using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
        }
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

