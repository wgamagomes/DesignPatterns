namespace Xpto.Behavioral.Command.Calculator
{
    public class CalculatorInvoker
    {
        public int ExecuteCommand(ICommand command)
        {
            return command.Execute();
        }
    }
}
