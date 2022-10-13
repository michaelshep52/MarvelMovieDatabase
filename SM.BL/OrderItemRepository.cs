using System;
using SM.BL;

namespace SM.BL.cs
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves.
            OrderItem orderItem = new OrderItem(orderItemId);

            if (orderItemId == 1)
            {
              // orderItem.MovieId = "2";
               // orderItem.PurchasePrice = "19.99";
               // orderItem.Quantity = "1";
            }
            return orderItem;
        }

       
        //save order item
        public bool Save()
        {
            return true;
        }
    }
}
