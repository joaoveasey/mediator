using mediator_app2_mediatr_and_cqrs.Notifications;
using MediatR;

namespace mediator_app2_mediatr_and_cqrs.EventsHandler;

public class LogEventHandler :
                INotificationHandler<ProdutoCreateNotification>,
                INotificationHandler<ProdutoUpdateNotification>,
                INotificationHandler<ProdutoDeleteNotification>,
                INotificationHandler<ErroNotification>
{
    public Task Handle(ProdutoCreateNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"CRIACAO: '{notification.Id} \n{notification.Nome} - {notification.Preco}'");
        });
    }

    public Task Handle(ProdutoUpdateNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"ATUALIZACAO: '{notification.Id} \n{notification.Nome} - {notification.Preco} \n{notification.IsConcluido}'");
        });
    }

    public Task Handle(ProdutoDeleteNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"EXCLUSAO: '{notification.Id} - {notification.IsConcluido}'");
        });
    }

    public Task Handle(ErroNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"ERRO: '{notification.Mensagem} \n{notification.PilhaErro}'");
        });
    }
}
