using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;

namespace Xpto.Behavioral.Strategy.Strategies
{
    public class AdvancedStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }

        public AdvancedStrategy()
        {
            StrategyType = StrategyType.Advanced;
        }

        public string Exec(Event @event)
        {
            return "Advanced Strategy";
        }
    }
}
