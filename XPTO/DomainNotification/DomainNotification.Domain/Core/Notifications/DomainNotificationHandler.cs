using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DomainNotification.Domain.Core.Notifications
{

    public interface IDomainNotificationHandler : INotificationHandler<DomainNotification>
    {
        bool HasNotifications();
        List<DomainNotification> GetNotifications();
    }
    public class DomainNotificationHandler : IDomainNotificationHandler
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public Task Handle(DomainNotification notification, CancellationToken cancellationToken)
        {
            _notifications.Add(notification);

            return Task.CompletedTask;
        }

        public bool HasNotifications()
        {
            return GetNotifications().Any();
        }

        public virtual List<DomainNotification> GetNotifications()
        {
            return _notifications;
        }

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }
    }
}
