using System.Threading.Tasks;
using Sample.Repositories;
using Sample.Entities;
using Sample.Responses;

namespace Sample.Services
{
    public class CustomerService : ICus
    {
        private readonly ICustomerRepository customerRepository;
        public UserService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        Task<Customer> GetCustomerById(string id)
        {
            return Customer.CreateCustomerFromCustomerEntity(await this.customerRepository.GetCustomerById(id));
        }
    }
}