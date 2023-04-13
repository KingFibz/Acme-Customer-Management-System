using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BLTesting
{
    public class ProductRepository : EntityBase
    {
        public Product Retrieve(int ProductID)
        {
            Product product = new Product();

            if (ProductID == 1)
            {
                product.ProductName = "Ski Mask";
                product.ProductDescription = "Whether you're on a trip to the Mountains or to the Bank - this mask will come in handly!";
                product.CurrentPrice = 15.99M;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
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
