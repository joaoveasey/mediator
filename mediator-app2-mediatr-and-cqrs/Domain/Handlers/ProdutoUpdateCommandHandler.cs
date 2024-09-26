using mediator_app2_mediatr_and_cqrs.Domain.Commands;
using mediator_app2_mediatr_and_cqrs.Domain.Entity;
using mediator_app2_mediatr_and_cqrs.Notifications;
using mediator_app2_mediatr_and_cqrs.Repository.Interface;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace mediator_app2_mediatr_and_cqrs.Domain.Handlers;


public class ProdutoUpdateCommandHandler : IRequestHandler<ProdutoUpdateCommand, string>
{
    private readonly IMediator mediator;
    private readonly IRepository<Produto> repository;

    public ProdutoUpdateCommandHandler(IMediator mediator, IRepository<Produto> repository)
    {
        this.mediator = mediator;
        this.repository = repository;
    }

    public async Task<string> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
    {
        var produto = new Produto 
        { 
            Id = request.Id, 
            Nome = request.Nome, 
            Preco = request.Preco 
        };

        try
        {
            await repository.Edit(produto);

            await mediator.Publish(new ProdutoUpdateNotification
            {
                Id = request.Id, 
                Nome= request.Nome, 
                Preco= request.Preco
            });

            return await Task.FromResult("Produto alterado com sucesso.");
        }
        catch (Exception ex)
        {
            await mediator.Publish(new ProdutoUpdateNotification
            {
                Id = request.Id,
                Nome = request.Nome,
                Preco = request.Preco
            });

            await mediator.Publish(new ErroNotification
            {
                Mensagem = ex.Message,
                PilhaErro= ex.StackTrace,
            });

            return await Task.FromResult("Ocorreu um erro no momento da alteração.");
        }
    }
}
