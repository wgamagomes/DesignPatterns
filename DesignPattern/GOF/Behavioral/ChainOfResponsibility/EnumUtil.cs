using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.GOF.Behavioral.ChainOfResponsibility
{
    public enum NotificationType
    {
        Email,
        SMS
    }

    public enum Status
    {
        SellerRefusal,
        CustomerRefusal,
        CustomerAcceptance
    }
}
