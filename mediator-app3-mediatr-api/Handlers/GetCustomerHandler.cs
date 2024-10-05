using mediator_app3_mediatr_api.Handlers.Request;
using mediator_app3_mediatr_api.Models;
using mediator_app3_mediatr_api.Repositories;
using mediator_app3_mediatr_api.Services;
using MediatR;

namespace mediator_app3_mediatr_api.Handlers
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, Customer>
    {
        private readonly IValidationService _validationService;
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerHandler(IValidationService validationService, ICustomerRepository customerRepository)
        {
            _validationService = validationService;
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            _validationService.Validate<Guid>(request.CustomerId);
            return await _customerRepository.GetCustomer(request.CustomerId);
        }
    }
}
