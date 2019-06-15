using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public class CustomerRefusalNotification : INotification
    {
        public INotification Next { get; set; }
           
        public void Notify(Action<InfoValueObject> execute, InfoValueObject info)
        {
            if (info.Status == Status.CustomerRefusal)
            {
                info.Message = "Customer Refusal Notification";
                execute(info);
            }
            else
            {
                Next?.Notify(execute, info);
            }
        }
    }
}
