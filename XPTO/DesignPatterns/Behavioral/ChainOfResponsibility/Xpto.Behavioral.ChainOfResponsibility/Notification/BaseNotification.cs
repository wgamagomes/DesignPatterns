using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification
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
