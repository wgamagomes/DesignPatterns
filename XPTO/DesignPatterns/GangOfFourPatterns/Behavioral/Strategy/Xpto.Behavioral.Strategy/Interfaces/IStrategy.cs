using Xpto.Behavioral.Strategy.Events;

namespace Xpto.Behavioral.Strategy.Interfaces
{
    public interface IStrategy
    {
        StrategyType StrategyType { get; }
        string Exec(Event @event);
    }
}
