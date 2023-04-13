using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTesting
{
    [TestClass]
    public class ProductRepositoryTest : EntityBase
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.99M,
                ProductDescription = "Whether you're on a trip to the Mountains or to the Bank - this mask will come in handly!",
                ProductName = "Ski Mask"
            };
            var actual = productRepository.Retrieve(1);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
        [TestMethod()]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 12M,
                ProductDescription = "Assorted size set of 4 bright red mini sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(true, actual);
        }
        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted size set of 4 bright red mini sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(false, actual);
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


