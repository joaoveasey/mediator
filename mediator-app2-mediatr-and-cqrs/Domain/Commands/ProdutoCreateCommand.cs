using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Domain.Commands;

public class ProdutoCreateCommand : IRequest<string>
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
