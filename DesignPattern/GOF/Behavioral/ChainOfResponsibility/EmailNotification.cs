using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public class EmailNotification : NotificationBase
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
