using System;
using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.Interfaces;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Notifiers
{
    public class BuyerAcceptanceNotifier : INotifier
    {
        public INotifier Next { get; set; }

        public void Notify(Action<InfoValueObject> execute, InfoValueObject info)
        {
            if (info.Status == Status.CustomerAcceptance)
            {
                info.Message = $"Buyer Accepted your offer.";
                execute(info);
            }
            else
            {
                Next?.Notify(execute, info);
            }
        }
    }
}
