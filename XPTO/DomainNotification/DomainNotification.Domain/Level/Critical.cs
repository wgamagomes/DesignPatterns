using DomainNotification.Domain.Interfaces.Error;

namespace DomainNotification.Domain.Level
{
    public class Critical : ILevel
    {
        public Critical(string description = "Critical")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString()
        {
            return Description;
        }
    }
}
