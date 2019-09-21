using Sample.Entities;

namespace Sample.Repositories
{
    public interface ICustomerRepository
    {
        Task<CustomerEntity> GetCustomerById(string id);
    }
}