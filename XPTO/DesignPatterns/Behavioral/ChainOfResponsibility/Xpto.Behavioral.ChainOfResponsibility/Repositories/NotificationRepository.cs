using System.Collections.Generic;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Interfaces;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private static List<BaseNotification> _notifications;
        public NotificationRepository()
        {
            _notifications = new List<BaseNotification>();
        }

        public void DeleteAll()
        {
            _notifications.Clear();
        }

        public IEnumerable<BaseNotification> GetAll()
        {
            return _notifications;
        }

        public void Insert(BaseNotification notificationBase)
        {
            _notifications.Add(notificationBase);
        }
    }
}
