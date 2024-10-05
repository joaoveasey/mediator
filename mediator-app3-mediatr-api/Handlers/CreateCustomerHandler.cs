using mediator_app3_mediatr_api.Handlers.Request;
using mediator_app3_mediatr_api.Models;
using mediator_app3_mediatr_api.Repositories;
using mediator_app3_mediatr_api.Services;
using MediatR;

namespace mediator_app3_mediatr_api.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, Guid>
    {
        private readonly IValidationService _validationService;
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerHandler(IValidationService validationService, ICustomerRepository customerRepository)
        {
            _validationService = validationService;
            _customerRepository = customerRepository;
        }

        public async Task<Guid> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            _validationService.Validate<Customer>(request.Customer);
            return await _customerRepository.CreateCustomer(request.Customer);
        }
    }
}
