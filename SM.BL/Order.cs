using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SM.BL.cs;
using SM.COM.cs;

namespace SM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() =>
             $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {EntityState.ToString()}";

        public override string ToString() =>
            $"{OrderDate.Value.Date} ({OrderId})";

        //validate
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        
    }
}

