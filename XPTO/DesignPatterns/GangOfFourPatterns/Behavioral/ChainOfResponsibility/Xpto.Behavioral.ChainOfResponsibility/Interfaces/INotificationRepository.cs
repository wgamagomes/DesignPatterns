using System.Collections.Generic;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Interfaces
{
    public interface INotificationRepository
    {
        void Insert(BaseNotification notificationBase);

        IEnumerable<BaseNotification> GetAll();

        void DeleteAll();
    }
}
