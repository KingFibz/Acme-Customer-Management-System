using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BLTesting
{
    public class OrderRepository : EntityBase
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);

            if (orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;

        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }

                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}