using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public class SellerRefusalNotification : INotification
    {
        public INotification Next { get; set; }
        
        public void Notify(Action<InfoValueObject> execute, InfoValueObject info)
        {
            if (info.Status == Status.SellerRefusal)
            {
                info.Message = "Seller Refusal Notification";
                execute(info);
            }
            else
            {
                Next?.Notify(execute, info);
            }
        }
    }
}
