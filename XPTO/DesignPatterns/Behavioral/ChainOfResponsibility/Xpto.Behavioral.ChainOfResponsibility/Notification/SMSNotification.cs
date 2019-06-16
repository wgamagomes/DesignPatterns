using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Notification
{
    public class SMSNotification : BaseNotification
    {
        public SMSNotification()
            : base(NotificationType.SMS)
        {

        }
        public override void Notify(InfoValueObject info)
        {
            //your SMS notification
        }
    }
}
