using DomainNotification.Domain.Core.Commands;
using System.Threading.Tasks;

namespace DomainNotification.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent(Event @event);
    }
}
