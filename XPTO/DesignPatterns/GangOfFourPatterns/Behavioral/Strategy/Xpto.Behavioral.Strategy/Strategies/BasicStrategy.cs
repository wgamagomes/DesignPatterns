using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;

namespace Xpto.Behavioral.Strategy.Strategies
{
    public class BasicStrategy : IStrategy
    {
        public StrategyType StrategyType { get; }
        public BasicStrategy()
        {
            StrategyType = StrategyType.Basic;
        }
        public string Exec(Event @event)
        {
            return "Basic Strategy";
        }
    }
}
