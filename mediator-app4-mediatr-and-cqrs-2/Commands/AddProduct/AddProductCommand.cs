using mediator_app4_mediatr_and_cqrs_2.Entities;
using MediatR;

namespace mediator_app4_mediatr_and_cqrs_2.Commands.AddProduct
{
    public class AddProductCommand : IRequest
    {
        public string Title { get; set; }
        public decimal Description { get; set; }

        public Product ToEntity()
            => new(Title, Description);
    }
}
