using System;
using System.Collections.Generic;
using System.Linq;

namespace Xpto.Behavioral.Mediator.Own
{
    public class Mediator<TEvent> : IMediator<TEvent>
        where TEvent : IEvent
    {
        public void Publish(TEvent @event)
        {
            foreach (var handler in Factory<IEventHandler<TEvent>>.GetRequestHandlers)
            {
                handler.Handle(@event);
            }
        }
    }
}

