using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Notification
{
    public  abstract class BaseNotification
    {
        public BaseNotification(NotificationType notificationType)
        {
            NotificationType = notificationType;
        }

        public NotificationType NotificationType { get; }

        public abstract void Notify(InfoValueObject info);

    }
}
