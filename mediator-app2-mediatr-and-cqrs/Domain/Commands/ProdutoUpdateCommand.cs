using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Domain.Commands;

public class ProdutoUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
