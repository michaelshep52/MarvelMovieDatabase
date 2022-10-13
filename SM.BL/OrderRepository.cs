using System;
using System.Collections.Generic;
using System.Linq;
using SM.BL;

namespace SM.BL.cs
{
    public class OrderRepository
    {
        //Retrieve

        public Order Retrieve(int orderId)
        {
            //code that retrieves defined customer.
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                //Use current year in hard code data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            // Code that saves the passed in order
            return true;
        }
    }
}   
