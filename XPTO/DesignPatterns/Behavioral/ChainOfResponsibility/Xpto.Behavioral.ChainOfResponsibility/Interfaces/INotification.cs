using System;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Interfaces
{
    public interface INotification
    {
        INotification Next { get; set; }

        void Notify(Action<InfoValueObject> execute, InfoValueObject info);
    }
}
