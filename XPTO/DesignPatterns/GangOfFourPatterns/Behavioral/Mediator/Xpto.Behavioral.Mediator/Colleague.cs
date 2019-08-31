using System;

namespace Xpto.Behavioral.Mediator
{
    public class Colleague
    {
        Mediator _mediator;
        protected string name;
        public Colleague(Mediator mediator, string name)
        {
            this._mediator = mediator;
            mediator.SignOn(Receive);
            this.name = name;
        }
        public virtual void Receive(string message, string from)
        {
            Console.WriteLine(name + " received from " + from + ": " + message);
        }
        public void Send(string message)
        {
            Console.WriteLine("Send (From " + name + "): " + message);

            _mediator.Send(message, name);
        }
    }
}
