namespace Xpto.Behavioral.Mediator.Own
{
    public interface  IEventHandler<TEvent>
    {
        void Handle(TEvent @event);
    }
}
