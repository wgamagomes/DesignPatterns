using DomainNotification.Domain.CommandHandlers;
using DomainNotification.Domain.Core.Bus;
using DomainNotification.Domain.Core.Notifications;
using DomainNotification.Domain.Interfaces.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DomainNotification.Domain.SongBoundedContext.CommandHandlers
{
    public class SongCommandHandler: CommandHandler, IRequestHandler<NewSongCommnad>, IRequestHandler<DeleteSongCommnad>
    {
        public SongCommandHandler(IMediatorHandler bus, IDomainNotificationHandler notifications)
            :base(bus, notifications)
        {

        }

        public Task<Unit> Handle(NewSongCommnad request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);

                return Unit.Task;
            }

            //Add entity in repository

            return Unit.Task;
        }

        public Task<Unit> Handle(DeleteSongCommnad request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);

                return Unit.Task;
            }

            //Del entity in repository

            return Unit.Task;
        }
    }
}
