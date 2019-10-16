using DomainNotification.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Interfaces.Notification
{
    public interface INotification
    {
        IList<object> List { get; }
        bool HasNotifications { get; }

        bool Includes(DescriptionBase error);
        void Add(DescriptionBase error);
    }
}
