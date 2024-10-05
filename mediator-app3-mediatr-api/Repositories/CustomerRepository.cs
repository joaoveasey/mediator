using mediator_app3_mediatr_api.Models;
using System.Reflection.Metadata.Ecma335;

namespace mediator_app3_mediatr_api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Guid> CreateCustomer(Customer customer)
        {
            return Guid.NewGuid();
        }

        public async Task<Customer> GetCustomer(Guid customerId)
        {
            Customer customer = new Customer
            {
                CustomerId = customerId,
                Name = "João"
            };

            return customer;
        }
    }
}
