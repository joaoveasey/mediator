using mediator_app2_mediatr_and_cqrs.Domain.Commands;
using mediator_app2_mediatr_and_cqrs.Domain.Entity;
using mediator_app2_mediatr_and_cqrs.Notifications;
using mediator_app2_mediatr_and_cqrs.Repository.Interface;

namespace mediator_app2_mediatr_and_cqrs.Domain.Handlers;

public class ProdutoDeleteCommandHandler : IRequestHandler<ProdutoDeleteCommandHandler, string>
{
    private readonly IMediator mediator;
    private readonly IRepository<Produto> repository;

    public ProdutoDeleteCommandHandler(IMediator mediator, IRepository<Produto> repository)
    {
        this.mediator = mediator;
        this.repository = repository;
    }

    public async Task<string> Handle(ProdutoDeleteCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await repository.Delete(request.Id);

            await mediator.Publish(new ProdutoDeleteNotification
            {
                Id = request.Id,
                IsConcluido = true
            });

            return await Task.FromResult("Produto excluído com sucesso.");
        }
        catch (Exception ex)
        {
            await mediator.Publish(new ProdutoUpdateNotification
            {
                Id = request.Id,
                IsConcluido = false
            });

            await mediator.Publish(new ErroNotification
            {
                Mensagem = ex.Message,
                PilhaErro = ex.StackTrace,
            });

            return await Task.FromResult("Ocorreu um erro no momento da exclusão.");
        }
    }
}
