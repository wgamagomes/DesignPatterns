using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DomainNotification.Domain.Core.Commands;
using MediatR;

namespace DomainNotification.Domain.Core.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;


        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task RaiseEvent(Event @event)
        {
            return _mediator.Publish(@event);            
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);           
        }
    }
}
