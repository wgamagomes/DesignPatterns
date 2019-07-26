using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Interfaces;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility
{
    public static class NotificationInitializer
    {
        private static List<INotifier> _notifications;
        private static INotifier _initialNotification;
        static NotificationInitializer()
        {
            _notifications = Assembly
              .GetExecutingAssembly()
              .GetTypes()
              .Where(t => typeof(INotifier).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
              .Select(t => (INotifier)Activator.CreateInstance(t))
              .ToList();

            if (_notifications == null || _notifications.Count == 0)
                throw new Exception($"No concrete class that implements the interface {nameof(INotifier)}");

            for (int i = 0; i < _notifications.Count() - 1; i++)
            {
                _notifications[i].Next = _notifications[i + 1];
            }

            _initialNotification = _notifications[0];
        }

        public static void Initialize(BaseNotification notificationBase, InfoValueObject info)
        {
            _initialNotification.Notify(notificationBase.Notify, info);
        }
    }
}
