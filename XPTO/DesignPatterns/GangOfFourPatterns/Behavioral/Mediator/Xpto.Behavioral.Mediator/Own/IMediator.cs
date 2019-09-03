namespace Xpto.Behavioral.Mediator.Own
{
    public interface IMediator<TEvent>
        where TEvent: IEvent
    {
        void Publish(TEvent @event);
    }
}
