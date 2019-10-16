using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Interfaces.Notification
{
    public interface INotification
    {
        IList<object> List { get; }
        bool HasNotifications { get; }

        bool Includes(Description error);
        void Add(Description error);
    }
}
