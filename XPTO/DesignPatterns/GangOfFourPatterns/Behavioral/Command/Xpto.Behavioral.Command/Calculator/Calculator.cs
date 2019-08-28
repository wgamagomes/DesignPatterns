namespace Xpto.Behavioral.Command.Calculator
{
    public class Calculator
    {
        private int _a, _b;

        public Calculator(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public int Add()
        {
            return _a + _b;
        }

        public int Substract()
        {
            return _a - _b;
        }
    }
}
