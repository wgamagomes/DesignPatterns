using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Notification
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
