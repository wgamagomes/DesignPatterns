using System;

namespace Xpto.Behavioral.Mediator.CSharpThreeDesignPatternsBook
{
    /// <summary>
    /// Registers with a Mediator by supplying a Receive method; issues Send requests to other colleagues via the Mediator 
    /// </summary>
    public abstract class ColleagueBase
    {
        Mediator _mediator;
        protected string name;
        public ColleagueBase(Mediator mediator, string name)
        {
            this._mediator = mediator;
            mediator.SignOn(Receive);
            this.name = name;
        }
        public abstract void Receive(string message, string from);

        public void Send(string message)
        {
            _mediator.Send(message, name);
        }
    }
}
