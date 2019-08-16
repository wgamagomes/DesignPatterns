using FluentAssertions;
using NUnit.Framework;
using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Factory;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Test
{
    public class StrategyTest
    {
        private StrategyFactory _strategyFactory;

        [SetUp]
        public void Setup()
        {
            _strategyFactory = new StrategyFactory();
        }

        [Test]
        public void Shoud_Be_Basic_Strategy()
        {
            var @event = new Event { StrategyType = StrategyType.Basic };

            var strategy = _strategyFactory[@event.StrategyType];            

            strategy.Exec(@event).Should().Be("Basic Strategy");
        }

        [Test]
        public void Shoud_Be_Intermediate_Strategy()
        {
            var @event = new Event { StrategyType = StrategyType.Intermediate };

            var strategy = _strategyFactory[@event.StrategyType];           

            strategy.Exec(@event).Should().Be("Intermediate Strategy");
        }

        [Test]
        public void Shoud_Be_Advanced_Strategy()
        {
            var @event = new Event { StrategyType = StrategyType.Advanced };

            var strategy = _strategyFactory[@event.StrategyType];           

            strategy.Exec(@event).Should().Be("Advanced Strategy");
        }
    }
}
