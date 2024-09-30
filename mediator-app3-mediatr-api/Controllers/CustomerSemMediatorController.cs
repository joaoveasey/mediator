using mediator_app3_mediatr_api.Models;
using mediator_app3_mediatr_api.Repositories;
using mediator_app3_mediatr_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace mediator_app3_mediatr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSemMediatorController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IValidationService _validationService;

        public CustomerSemMediatorController(ICustomerRepository customerRepository, IValidationService validationService)
        {
            _customerRepository = customerRepository;
            _validationService = validationService;
        }

        [HttpGet("get-customer/{customerId:Guid}")]
        public async Task<Customer> GetCustomer(Guid customerId)
        {
            _validationService.Validate<Guid>(customerId);

            return await _customerRepository.GetCustommer(customerId);
        }

        [HttpPost("create-customer")]
        public async Task<Guid> CreateCustomer([FromBody] Customer newCustomer)
        {
            _validationService.Validate<Customer>(newCustomer);

            var customer = new Customer
            {
                Name = newCustomer.Name
            };

            return await _customerRepository.CreateCustomer(customer);
        }
    }
}
