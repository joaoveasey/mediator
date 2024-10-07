using mediator_app4_mediatr_and_cqrs_2.Persistence;
using MediatR;

namespace mediator_app4_mediatr_and_cqrs_2.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly ApplicationFourDbContext _context;

        public AddProductCommandHandler(ApplicationFourDbContext context)
        {
            _context = context;
        }

        public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();

            _context.Products.Add(product);

            return Task.CompletedTask; 
        }
    }
}
