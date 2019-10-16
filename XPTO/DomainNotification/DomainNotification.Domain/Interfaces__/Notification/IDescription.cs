namespace DomainNotification.Domain.Interfaces.Notification
{
    public interface IDescription
    {
        string Message { get; }

        string ToString();
    }
}
