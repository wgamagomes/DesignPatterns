namespace Xpto.Behavioral.Mediator.Own
{
    public interface  INotificationHandler<TNotification>
    {
        void Handle(TNotification notification);
    }
}
