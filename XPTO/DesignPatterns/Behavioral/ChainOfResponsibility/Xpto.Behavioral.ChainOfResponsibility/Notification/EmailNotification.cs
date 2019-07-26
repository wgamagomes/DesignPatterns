using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification
{
    public class EmailNotification : BaseNotification
    {
        public EmailNotification()
            : base(NotificationType.Email)
        {

        }

        public override void Notify(InfoValueObject info)
        {
            //Your email Notification
        }
    }
}
