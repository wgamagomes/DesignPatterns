using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;
using System;

namespace Xpto.Behavioral.Strategy.Strategies
{
   public class IntermediateStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }
        public IntermediateStrategy()
        {
            StrategyType = StrategyType.Intermediate;
        }
        public void Exec(Event @event)
        {
            Console.WriteLine("Intermediate Strategy");
        }
    }
}
