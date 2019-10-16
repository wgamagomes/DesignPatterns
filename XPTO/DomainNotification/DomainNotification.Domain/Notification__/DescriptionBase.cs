using DomainNotification.Domain.Interfaces.Notification;

namespace DomainNotification.Domain.Notification
{
    public abstract class DescriptionBase : IDescription
    {
        public string Message { get; }

        protected DescriptionBase(string message, params string[] args)
        {
            Message = message;

            for (var i = 0; i < args.Length; i++)
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }
        }

        public override string ToString() => Message;
    }
}
