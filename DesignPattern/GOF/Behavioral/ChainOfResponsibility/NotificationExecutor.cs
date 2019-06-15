using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public static class NotificationExecutor
    {
        private static List<INotification> _notifications;
        private static INotification _initialNotification;
        static NotificationExecutor()
        {
            _notifications = Assembly
              .GetExecutingAssembly()
              .GetTypes()
              .Where(t => typeof(INotification).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
              .Select(t => (INotification)Activator.CreateInstance(t))
              .ToList();

            if (_notifications == null || _notifications.Count == 0)
                throw new Exception($"No concrete class that implements the interface {nameof(INotification)}");

            for (int i = 0; i < _notifications.Count() - 1; i++)
            {
                _notifications[i].Next = _notifications[i + 1];
            }

            _initialNotification = _notifications[0];
        }

        public static void Initialization(Action<InfoValueObject> execute, InfoValueObject info)
        {
            _initialNotification.Notify(execute, info);
        }
    }
}
