using mediator_app3_mediatr_api.Models;

namespace mediator_app3_mediatr_api.Repositories
{
    public interface ICustomerRepository
    {
        public Task<Customer> GetCustomer(Guid customerId);
        public Task<Guid> CreateCustomer(Customer customer);
    }
}
