namespace Xpto.Behavioral.Mediator.Own
{
    public class OtherNotification : INotification
    {
        public string Message { get; private set; }

        public OtherNotification(string message)
        {
            Message = message;
        }
    }
}
