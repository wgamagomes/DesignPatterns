using System;

namespace Xpto.Behavioral.Mediator.CSharpThreeDesignPatternsBook
{
    public class Colleague : ColleagueBase
    {
        public Colleague(Mediator mediator, string name)
            : base(mediator, name)
        {

        }

        // Does not get copies of own messages 
        public override void Receive(string message, string from)
        {
            if (!string.Equals(from, name))
                Console.WriteLine(name + " received from " + from + ": " + message);
        }
    }
}
