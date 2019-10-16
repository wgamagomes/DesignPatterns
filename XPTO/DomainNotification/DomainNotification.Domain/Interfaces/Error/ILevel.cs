namespace DomainNotification.Domain.Interfaces.Error
{
    public interface ILevel
    {
        string Description { get; }

        string ToString();
    }
}
