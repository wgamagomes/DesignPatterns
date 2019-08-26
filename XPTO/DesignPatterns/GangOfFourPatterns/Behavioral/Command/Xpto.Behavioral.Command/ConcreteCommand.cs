using System;
using System.Collections.Generic;
using System.Text;
using Xpto.Behavioral.Command.Base;

namespace Xpto.Behavioral.Command
{
    public class ConcreteCommand : CommandBase
    {
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
