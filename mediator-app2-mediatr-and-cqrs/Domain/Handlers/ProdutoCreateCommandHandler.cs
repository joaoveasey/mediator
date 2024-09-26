using mediator_app2_mediatr_and_cqrs.Domain.Entity;
using mediator_app2_mediatr_and_cqrs.Repository.Interface;
using mediator_app2_mediatr_and_cqrs.Domain.Commands;
using mediator_app2_mediatr_and_cqrs.Notifications;
using mediator_app2_mediatr_and_cqrs.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace mediator_app2_mediatr_and_cqrs.Domain.Handlers;

public class ProdutoCreateCommandHandler : IRequestHandler<ProdutoCreateCommand, string>
{
    private readonly IMediator mediator;
    private readonly IRepository<Produto> repository;

    public ProdutoCreateCommandHandler(IMediator mediator, IRepository<Produto> repository)
    {
        this.mediator = mediator;
        this.repository = repository;
    }

    public async Task<string> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
    {
        var produto = new Produto { Nome = request.Nome, Preco = request.Preco };

        try
        {
            await repository.Add(produto);
            await mediator.Publish(new ProdutoCreateNotification 
            { Id = produto.Id, Nome = produto.Nome, Preco = produto.Preco });

            return await Task.FromResult("Produto criado com sucesso.");
        }
        catch (Exception ex)
        {
            await mediator.Publish(new ProdutoCreateNotification
            { Id = produto.Id, Nome = produto.Nome, Preco = produto.Preco });

            await mediator.Publish(new ErroNotification 
            { Mensagem = ex.Message, PilhaErro = ex.StackTrace });

            return await Task.FromResult("Ocorreu um erro no momento da criação.");
        }
    }
}
