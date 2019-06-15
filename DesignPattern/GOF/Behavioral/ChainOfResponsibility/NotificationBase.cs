using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public  abstract class NotificationBase
    {
        public NotificationBase(NotificationType notificationType)
        {
            NotificationType = notificationType;
        }

        public NotificationType NotificationType { get; }

        public abstract void Notify(InfoValueObject info);

    }
}
