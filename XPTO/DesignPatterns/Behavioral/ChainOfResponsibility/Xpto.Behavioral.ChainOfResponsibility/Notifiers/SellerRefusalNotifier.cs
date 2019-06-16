using System;
using Xpto.Behavioral.ChainOfResponsibility.Enums;
using Xpto.Behavioral.ChainOfResponsibility.Interfaces;
using Xpto.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.Behavioral.ChainOfResponsibility.Notifiers
{
    public class SellerRefusalNotifier : INotifier
    {
        public INotifier Next { get; set; }

        public void Notify(Action<InfoValueObject> execute, InfoValueObject info)
        {
            if (info.Status == Status.SellerRefusal)
            {
                info.Message = $"Dear {info.Name} the seller refuses your counter-proposal.";
                execute(info);
            }
            else
            {
                Next?.Notify(execute, info);
            }
        }
    }
}
