using Sample.Entities;

namespace Sample.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<CustomerEntity> GetCustomerById(string id)
        {
            return new CustomerEntity();
        }
    }
}