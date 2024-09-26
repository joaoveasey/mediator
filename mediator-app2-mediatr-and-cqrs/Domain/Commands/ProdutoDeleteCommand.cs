using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Domain.Commands;

public class ProdutoDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}
