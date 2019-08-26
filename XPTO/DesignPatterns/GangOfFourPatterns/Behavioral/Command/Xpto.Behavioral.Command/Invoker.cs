using Xpto.Behavioral.Command.Base;

namespace Xpto.Behavioral.Command
{
    public class Invoker
    {
        private CommandBase _command;

        public void SetCommand(CommandBase command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
