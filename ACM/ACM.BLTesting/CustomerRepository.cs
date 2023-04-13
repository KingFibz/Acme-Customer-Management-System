using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository : EntityBase
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int CustomerId)
        {
            Customer customer = new Customer();

            if (CustomerId == 1)
            {
                customer.EmailAddress = "fbaggins@gmail.com";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerID(CustomerId).ToList();
            }
            return customer;
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