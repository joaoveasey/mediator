using mediator_app3_mediatr_api.Handlers.Request;
using mediator_app3_mediatr_api.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mediator_app3_mediatr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerComMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerComMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-customer/{customerId: Guid}")]
        public async Task<Customer> GetCustomer(Guid customerId) =>
            await _mediator.Send(new GetCustomerRequest { CustomerId = customerId });

        [HttpPost("create-customer")]
        public async Task<Guid> CreateCustomer(Customer customer) => 
            await _mediator.Send(new CreateCustomerRequest { Customer = customer });
    }
}