using Mc2.CrudTest.Presentation.Server.Domain.Customer;

namespace Mc2.CrudTest.Presentation.Server.Application.Customers
{
    public class CustomerService : ICustomerService
    {
        public Task<int> CreateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
