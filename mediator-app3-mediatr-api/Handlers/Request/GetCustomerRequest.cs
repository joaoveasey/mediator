using mediator_app3_mediatr_api.Models;
using MediatR;

namespace mediator_app3_mediatr_api.Handlers.Request
{
    public class GetCustomerRequest : IRequest<Customer>
    {
        public Guid CustomerId { get; set; }
    }
}
