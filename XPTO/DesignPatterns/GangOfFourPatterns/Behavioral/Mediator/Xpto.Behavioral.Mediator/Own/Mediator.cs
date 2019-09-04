using System;
using Xpto.Behavioral.Mediator.Own.Interfaces;

namespace Xpto.Behavioral.Mediator.Own
{
    public class Mediator : IMediator
    {
        public void Publish<TNotification>(TNotification notification)
             where TNotification : INotification
        {
            foreach (var handler in Factory<INotificationHandler<TNotification>>.GetHandlers)
            {
                handler.Handle(notification);
            }
        }

        public void Send<TRequest>(TRequest request)
            where TRequest : IRequest

        {
            var handlers = Factory<IRequestHandler<TRequest>>.GetHandlers;

            if (handlers.Count > 1)
                throw new Exception();

            handlers[0].Handle(request);

        }

        public TResult Send<TRequest, TResult>(TRequest request)
            where TRequest : IRequest<TResult>

        {

            var handlers = Factory<IRequestHandler<TRequest, TResult>>.GetHandlers;

            if (handlers.Count > 1)
                throw new Exception();

            return handlers[0].Handle(request);

        }
    }
}

