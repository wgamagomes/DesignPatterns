namespace Xpto.Behavioral.Command.Base
{
    public abstract class CommandBase

    {
        protected Receiver receiver;

        public CommandBase(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract string Execute();
    }
}
