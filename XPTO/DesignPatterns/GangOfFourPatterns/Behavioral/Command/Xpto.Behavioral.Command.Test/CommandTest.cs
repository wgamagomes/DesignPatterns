using FluentAssertions;
using NUnit.Framework;
using Xpto.Behavioral.Command;
using Xpto.Behavioral.Command.Base;
using Xpto.Behavioral.Command.Calculator;
using Xpto.Behavioral.Command.ModifyProductPrice;

namespace Xpto.GangOfFourPatterns.Behavioral.Command.Test
{
    public class CommandTest
    {   

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Should_Do_Something()
        {
            Receiver receiver = new Receiver();
            CommandBase command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand().
                Should()
                .Be("Called Receiver.Action()");

        }


        [Test]
        public void Should_Increase_Price()
        {

            ModifyPrice modifyPriceInvolker = new ModifyPrice();
            var product = new Product("Phone", 500);

            modifyPriceInvolker.AddCommand(new ProductCommand(product, PriceAction.Increase, 100));
            modifyPriceInvolker.AddCommand(new ProductCommand(product, PriceAction.Increase, 200));

            modifyPriceInvolker.Invoke();
      
            product.ToString().Should().Be("Current price for the Phone product is 800$.");
        }

        [Test]
        public void Should_Decrease_Price()
        {

            ModifyPrice modifyPriceInvolker = new ModifyPrice();
            var product = new Product("Phone", 500);

            modifyPriceInvolker.AddCommand(new ProductCommand(product, PriceAction.Decrease, 100));
            modifyPriceInvolker.AddCommand(new ProductCommand(product, PriceAction.Decrease, 200));

            modifyPriceInvolker.Invoke();

            product.ToString().Should().Be("Current price for the Phone product is 200$.");
        }


        [Test]
        public void Should_Add_Value()
        {
            CalculatorInvoker calculatorInvolker = new CalculatorInvoker();

            var calculator = new Calculator(3, 4);

            var command = new AddCommand(calculator);

           var result = calculatorInvolker.ExecuteCommand(command);

            result.Should().Be(7);
        }

        [Test]
        public void Should_Subtract_Value()
        {
            CalculatorInvoker calculatorInvolker = new CalculatorInvoker();

            var calculator = new Calculator(3, 4);

            var command = new SubtractCommand(calculator);

            var result = calculatorInvolker.ExecuteCommand(command);

            result.Should().Be(-1);
        }

    }
}
