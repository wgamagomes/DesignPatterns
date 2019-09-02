namespace Xpto.Behavioral.Mediator.DoFactory
{
    public class Colleague
    {
        protected Mediator mediator;

        protected string Name;
        protected string Message;


        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Notify(string message)
        {
            Message = Name+" Colleague1 gets message: " + message;
        }
    }
}
