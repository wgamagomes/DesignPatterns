using DesignPattern.GOF.Behavioral.ChainOfResponsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test
{
    [TestClass]
    public class ChainOfResponsibilityUnitTest
    {
        [TestMethod]
        public void WhenASellerRefusalEmailIsSent()
        {
            var info = new InfoValueObject("Peter", 
                "Pan", 
                "peterPan@email.com",
                "(00)0000-0000",
                Status.SellerRefusal);

            NotificationExecutor.Initialization(new EmailNotification().Notify, info);

        }

        [TestMethod]
        public void WhenASellerRefusalSMSIsSent()
        {
            var info = new InfoValueObject("Peter",
                "Pan",
                "peterPan@email.com",
                "(00)0000-0000",
                Status.SellerRefusal);

            NotificationExecutor.Initialization(new SMSNotification().Notify, info);

        }

        [TestMethod]
        public void WhenACustomerRefusalEmailIsSent()
        {
            var info = new InfoValueObject("Peter",
                "Pan",
                "peterPan@email.com",
                "(00)0000-0000",
                Status.CustomerRefusal);

            NotificationExecutor.Initialization(new EmailNotification().Notify, info);

        }

        [TestMethod]
        public void WhenACustomerRefusalSMSIsSent()
        {
            var info = new InfoValueObject("Peter",
                "Pan",
                "peterPan@email.com",
                "(00)0000-0000",
                Status.CustomerRefusal);

            NotificationExecutor.Initialization(new SMSNotification().Notify, info);

        }

        [TestMethod]
        public void WhenACustomerAcceptanceEmailIsSent()
        {
            var info = new InfoValueObject("Peter",
                "Pan",
                "peterPan@email.com",
                "(00)0000-0000",
                Status.CustomerAcceptance);

            NotificationExecutor.Initialization(new EmailNotification().Notify, info);
        }
        
        [TestMethod]
        public void WhenACustomerAcceptanceSMSIsSent()
        {
            var info = new InfoValueObject("Peter",
                "Pan",
                "peterPan@email.com",
                "(00)0000-0000",
                Status.CustomerAcceptance);

            NotificationExecutor.Initialization(new SMSNotification().Notify, info);

        }
    }
}
