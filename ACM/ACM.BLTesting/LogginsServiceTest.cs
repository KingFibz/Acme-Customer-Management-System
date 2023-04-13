using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItem = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItem.Add((ILoggable)customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };

            changedItem.Add(product);

            LoggingService.WriteToFile(changedItem);
        }
    }
}