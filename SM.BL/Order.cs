using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        //Retrieve
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        //save
        public bool Save()
        {
            return true;
        }

        //validate
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }         
           
    }
}

