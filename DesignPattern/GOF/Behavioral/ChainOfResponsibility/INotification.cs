using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public interface INotification
    {
        INotification Next { get; set; }

        void Notify(Action<InfoValueObject> execute, InfoValueObject info);
    }
}
