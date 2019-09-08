namespace Xpto.Behavioral.Mediator.Own
{
    public class WhateverNotification : INotification
    {
        public string Message { get; private set; }

        public WhateverNotification(string message)
        {
            Message = message;
        }
    }
}
