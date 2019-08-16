using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;

namespace Xpto.Behavioral.Strategy.Strategies
{
    public class IntermediateStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }
        public IntermediateStrategy()
        {
            StrategyType = StrategyType.Intermediate;
        }
        public string Exec(Event @event)
        {
            return "Intermediate Strategy";
        }
    }
}
