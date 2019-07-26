using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject
{
    public class InfoValueObject
    {
        public string Name { get; }
        public string LastName { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public string FullName { get { return $"{Name} {LastName}"; } }
        public Status Status { get; }

        public InfoValueObject(string name, string lastName, string email, string phoneNumber, Status status)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Status = status;
        }

        public string Message { get; set; }
    }
}
