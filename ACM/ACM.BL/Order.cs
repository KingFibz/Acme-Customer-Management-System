using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() =>
            $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";





        public override string ToString() => $"{OrderDate.Value.Date} ({OrderID})";

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
