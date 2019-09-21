using System.Threading.Tasks;

using Sample.Responses;

namespace Sample.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerById(string id);
    } 
}