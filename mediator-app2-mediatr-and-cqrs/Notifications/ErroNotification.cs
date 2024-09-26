using MediatR;

namespace mediator_app2_mediatr_and_cqrs.Notifications;

public class ErroNotification : INotification
{
    public string? Mensagem { get; set; }
    public string? PilhaErro { get; set; }
}
