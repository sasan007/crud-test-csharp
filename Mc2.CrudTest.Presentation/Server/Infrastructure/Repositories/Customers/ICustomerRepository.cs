using Mc2.CrudTest.Presentation.Server.Domain.Customer;

namespace Mc2.CrudTest.Presentation.Server.Infrastructure.Repositories.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerByIdAsync(int customerId);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<int> CreateCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(int customerId);
    }
}
