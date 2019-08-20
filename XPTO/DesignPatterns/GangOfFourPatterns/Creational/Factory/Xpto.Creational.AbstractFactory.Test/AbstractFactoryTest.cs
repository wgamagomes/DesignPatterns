using FluentAssertions;
using NUnit.Framework;

namespace Xpto.Creational.AbstractFactory.Test
{
    public class AbstractFactoryTest
    {
        private IFactory _factory1;
        private IFactory _factory2;
        private Client _client;


        [SetUp]
        public void Setup()
        {
            _factory1 = new Factory1();
            _factory2 = new Factory2();

        }

        [Test]
        public void Should_Be_Created_Related_Objects_1()
        {
            _client = new Client(_factory1);
            _client.Run().Should().Be("ProductB1 interacts with ProductA1");
        }

        [Test]
        public void Should_Be_Created_Related_Objects_2()
        {
            _client = new Client(_factory2);
            _client.Run().Should().Be("ProductB2 interacts with ProductA2");
        }
    }
}
