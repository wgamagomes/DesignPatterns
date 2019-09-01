using System;

namespace Xpto.Behavioral.Mediator.CSharpThreeDesignPatternsBook
{
    public class Colleague : ColleagueBase
    {
        public Colleague(Mediator mediator, string name)
            : base(mediator, name)
        {

        }
        public string ReceivedMessage { get; private set; }

        // Does not get copies of own messages 
        public override void Receive(string message, string from)
        {
            ReceivedMessage = string.Empty;
            if (!string.Equals(from, name))
            {
                ReceivedMessage = name + " received from " + from + ": " + message;
            }
        }
    }
}
