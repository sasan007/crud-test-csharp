using Mc2.CrudTest.Presentation.Server.Domain.Customer;

namespace Mc2.CrudTest.Presentation.Server.Application.Customers
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerByIdAsync(int customerId);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<int> CreateCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(int customerId);
    }
}
