namespace Xpto.Behavioral.Mediator.Own
{
    public interface IMediator       
    {
        void Publish<TNotification>(TNotification notification)
         where TNotification : INotification;
    }
}
