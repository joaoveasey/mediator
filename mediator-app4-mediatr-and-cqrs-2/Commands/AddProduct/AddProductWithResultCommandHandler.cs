using mediator_app4_mediatr_and_cqrs_2.Models;
using mediator_app4_mediatr_and_cqrs_2.Persistence;
using MediatR;

namespace mediator_app4_mediatr_and_cqrs_2.Commands.AddProduct
{
    public class AddProductWithResultCommandHandler : IRequestHandler<AddProductWithResultCommand, CustomResult<string>>
    {
        private readonly ApplicationFourDbContext _context;

        public AddProductWithResultCommandHandler(ApplicationFourDbContext context)
        {
            _context = context;
        }

        public Task<CustomResult<string>> Handle(AddProductWithResultCommand request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();

            _context.Products.Add(product);

            var result = new CustomResult<string>(data: product.Title);

            return Task.FromResult(result); 
        }
    }
}
