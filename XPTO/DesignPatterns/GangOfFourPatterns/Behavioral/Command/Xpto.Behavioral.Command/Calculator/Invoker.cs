namespace Xpto.Behavioral.Command.Calculator
{
    public class Invoker
    {
        public int ExecuteCommand(ICommand command)
        {
            return command.Execute();
        }
    }
}
