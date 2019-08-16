using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;
using System;

namespace Xpto.Behavioral.Strategy.Strategies
{
   public class BasicStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }
        public BasicStrategy()
        {
            StrategyType = StrategyType.Basic;
        }
        public void Exec(Event @event)
        {
            Console.WriteLine("Basic Strategy");
        }
    }
}
