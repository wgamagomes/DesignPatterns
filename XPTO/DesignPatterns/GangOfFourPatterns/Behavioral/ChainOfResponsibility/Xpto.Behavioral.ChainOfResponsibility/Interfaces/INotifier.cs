using System;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Interfaces
{
    public interface INotifier
    {
        INotifier Next { get; set; }

        void Notify(Action<InfoValueObject> execute, InfoValueObject info);
    }
}
