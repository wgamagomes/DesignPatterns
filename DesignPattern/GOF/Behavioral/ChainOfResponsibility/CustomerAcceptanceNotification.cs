using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public class CustomerAcceptanceNotification : INotification
    {
        public INotification Next { get; set; }

        public void Notify(Action<InfoValueObject> execute, InfoValueObject info)
        {
            if (info.Status == Status.CustomerAcceptance)
            {
                info.Message = "Customer Acceptance Notification";
                execute(info);
            }
            else
            {
                Next?.Notify(execute, info);
            }
        }
    }
}
