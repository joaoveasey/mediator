using mediator_app3_mediatr_api.Models;

namespace mediator_app3_mediatr_api.Repositories
{
    public interface ICustomerRepository
    {
        public Task<Customer> GetCustommer(Guid customerId);
        public Task<Guid> CreateCustomer(Customer customer);
    }
}
