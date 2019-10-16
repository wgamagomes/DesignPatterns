using DomainNotification.Domain.Interfaces.Error;

namespace DomainNotification.Domain.Level
{
    public class Information : ILevel
    {
        public Information(string description = "Information")
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
