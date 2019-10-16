namespace DomainNotification.Domain.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
