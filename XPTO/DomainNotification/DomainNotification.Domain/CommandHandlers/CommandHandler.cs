using DomainNotification.Domain.Core.Bus;
using DomainNotification.Domain.Core.Commands;
using DomainNotification.Domain.Interfaces.UoW;
using MediatR;
using DomainNotification.Domain.Core.Notifications;

namespace DomainNotification.Domain.CommandHandlers
{
    class CommandHandler
    {
        private IUnitOfWork _unitOfWork;
        private IMediatorHandler _bus;
        private IDomainNotificationHandler _notifications;

        public CommandHandler(IUnitOfWork unitOfWork, IMediatorHandler bus, IDomainNotificationHandler notifications)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.RaiseEvent(new Core.Notifications.DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            if (_unitOfWork.Commit()) return true;

            _bus.RaiseEvent(new Core.Notifications.DomainNotification("Commit", "Não foi possivel realizar a operação."));
            return false;
        }

    }
}
