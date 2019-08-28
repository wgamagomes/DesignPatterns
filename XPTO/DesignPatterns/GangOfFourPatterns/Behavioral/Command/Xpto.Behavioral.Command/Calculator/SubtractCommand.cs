namespace Xpto.Behavioral.Command.Calculator
{
    public class SubtractCommand : ICommand
    {
        private Calculator _calculator;

        public SubtractCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Substract();
        }
    }
}
