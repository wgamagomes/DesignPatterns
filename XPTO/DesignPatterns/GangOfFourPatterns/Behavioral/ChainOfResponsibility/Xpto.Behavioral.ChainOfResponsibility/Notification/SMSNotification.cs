using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification
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
