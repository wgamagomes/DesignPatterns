namespace Xpto.Behavioral.Command.Calculator
{
    public class AddCommand: ICommand
    {
        private Calculator _calculator;

        public AddCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Add();
        }
    }
}
