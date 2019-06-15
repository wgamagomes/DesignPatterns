using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public class SMSNotification : NotificationBase
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
