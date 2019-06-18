using NUnit.Framework;
using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.Notification;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Test
{
    public class ChainOfResponsibilityTest
    {
        [Test]
        public void Test()
        {  
            NotificationInitializer.Initialize(new EmailNotification(), new InfoValueObject("Ton", "Gomes", "tg@gmail.com", "", Status.CustomerAcceptance));
        }
    }
}
