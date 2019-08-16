namespace Xpto.Behavioral.Strategy.Events
{
    public class Event
    {
        public StrategyType StrategyType { get; set; }
    }

    public enum StrategyType
    {
        Basic,
        Intermediate,
        Advanced
    }
}
