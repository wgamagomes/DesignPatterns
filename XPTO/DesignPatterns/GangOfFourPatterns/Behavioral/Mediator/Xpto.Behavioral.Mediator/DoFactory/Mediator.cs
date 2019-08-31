namespace Xpto.Behavioral.Mediator.DoFactory
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
