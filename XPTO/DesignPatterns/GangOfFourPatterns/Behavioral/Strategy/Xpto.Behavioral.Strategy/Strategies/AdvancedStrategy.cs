using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;
using System;

namespace Xpto.Behavioral.Strategy.Strategies
{
    public class AdvancedStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }

        public AdvancedStrategy()
        {
            StrategyType = StrategyType.Advanced;
        }

        public void Exec(Event @event)
        {
            Console.WriteLine("Advanced Strategy");
        }
    }
}
