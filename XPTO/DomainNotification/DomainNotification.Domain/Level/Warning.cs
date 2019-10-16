using DomainNotification.Domain.Interfaces.Error;

namespace DomainNotification.Domain.Level
{
    public class Warning : ILevel
    {
        public Warning(string description = "Warning")
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
