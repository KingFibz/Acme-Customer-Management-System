using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTesting
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins" + ", " + "Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual( expected, actual );    
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual );
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        }
        [TestMethod]
        public void Validate()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@habbiton.me"
            };

            var expected = true;
            var actual = customer.Validate();

            Assert.AreEqual(expected, true);
        }
        [TestMethod]
        public void isNotValid()
        {
            var customer = new Customer
            {
                EmailAddress = "bhoggins@gmail.com"
            };
            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }



}