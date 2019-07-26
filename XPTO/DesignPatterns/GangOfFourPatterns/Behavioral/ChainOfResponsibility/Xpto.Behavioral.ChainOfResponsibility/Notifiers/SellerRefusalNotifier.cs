using System;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Enums;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Interfaces;
using Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.ValueObject;

namespace Xpto.GangOfFourPatterns.Behavioral.ChainOfResponsibility.Notifiers
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
