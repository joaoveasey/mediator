using mediator_app4_mediatr_and_cqrs_2.Entities;
using mediator_app4_mediatr_and_cqrs_2.Models;
using MediatR;

namespace mediator_app4_mediatr_and_cqrs_2.Commands.AddProduct
{
    public class AddProductWithResultCommand : IRequest<CustomResult<string>>
    {
        public string Title { get; set; }
        public decimal Description { get; set; }

        public Product ToEntity()
            => new(Title, Description);
    }
}
