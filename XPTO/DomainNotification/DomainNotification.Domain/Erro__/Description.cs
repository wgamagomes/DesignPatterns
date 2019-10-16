using DomainNotification.Domain.Interfaces.Error;
using DomainNotification.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Erro
{
    public class Description : DescriptionBase
    {
        public ILevel Level { get; }

        public Description(string message, ILevel level, params string[] args)
            : base(message, args)
        {
            Level = level;
        }
    }
}
