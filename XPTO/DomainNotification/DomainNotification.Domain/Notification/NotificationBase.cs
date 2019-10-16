using DomainNotification.Domain.Interfaces.Notification;
using System.Collections.Generic;
using System.Linq;

namespace DomainNotification.Domain.Notification
{
    public abstract class NotificationBase : INotification
    {
        public IList<object> List { get; } = new List<object>();
        public bool HasNotifications => List.Any();

        public bool Includes(DescriptionBase error)
        {
            return List.Contains(error);
        }

        public void Add(DescriptionBase description)
        {
            List.Add(description);
        }
    }
}
