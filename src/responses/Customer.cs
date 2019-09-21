using Sample.Entities;

namespace Sample.Responses
{
    public class Customer
    {
        public Customer()
        {

        }
        public static Customer CreateCustomerFromCustomerEntity(UserEntity userEntity)
        {
            Customer customer = new Customer();
            return customer;
        }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}