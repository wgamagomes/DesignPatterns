using DomainNotification.Domain.Core.Events;
using MediatR;

namespace DomainNotification.Domain.Core
{
    public class Event : Message, INotification
    {
    }
}
