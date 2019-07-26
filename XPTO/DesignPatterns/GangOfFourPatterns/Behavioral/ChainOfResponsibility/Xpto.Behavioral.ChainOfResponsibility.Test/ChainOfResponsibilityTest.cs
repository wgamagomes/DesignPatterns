using NUnit.Framework;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notification;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Test
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
