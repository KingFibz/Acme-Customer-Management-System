namespace Acme.CommonTest
{
    internal class Customer
    {
        private int v;

        public Customer(int v)
        {
            this.v = v;
        }

        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object AddressList { get; set; }
    }
}