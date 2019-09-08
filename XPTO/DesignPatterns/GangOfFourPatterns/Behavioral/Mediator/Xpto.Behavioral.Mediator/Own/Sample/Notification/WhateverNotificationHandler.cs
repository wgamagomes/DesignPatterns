namespace Xpto.Behavioral.Mediator.Own
{
    public class WhateverNotificationHandler : INotificationHandler<WhateverNotification>
    {
        public static string ReceivedMessage { get; private set; }
        public WhateverNotificationHandler() { }
        public void Handle(WhateverNotification notification)
        {
            ReceivedMessage = notification.Message;
        }
    }
}
