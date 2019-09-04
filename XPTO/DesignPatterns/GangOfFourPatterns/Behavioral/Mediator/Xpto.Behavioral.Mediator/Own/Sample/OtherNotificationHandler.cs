namespace Xpto.Behavioral.Mediator.Own
{
    public class OtherNotificationHandler : INotificationHandler<WhateverNotification>
    {
        public static string ReceivedMessage { get; private set; }
        public OtherNotificationHandler() { }
        public void Handle(WhateverNotification notification)
        {
            ReceivedMessage = notification.Message;
        }
    }
}
