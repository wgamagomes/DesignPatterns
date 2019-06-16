using System.Collections.Generic;
using Xpto.Behavioral.ChainOfResponsibility.Notification;

namespace Xpto.Behavioral.ChainOfResponsibility.Interfaces
{
    public interface INotificationRepository
    {
        void Insert(BaseNotification notificationBase);

        IEnumerable<BaseNotification> GetAll();

        void DeleteAll();
    }
}
