using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Notifications;

public class ProdutoDeleteNotification : INotification
{
    public int Id { get; set; }
    public bool IsConcluido { get; set; }
}
