using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTesting
{
    [TestClass]
    public class CustomerRepositoryTest : EntityBase
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange the date
            var customerRepository = new CustomerRepository();
            var expected = new Customer()
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            // -- Act
            var actual = customerRepository.Retrieve(1);
            
            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
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

