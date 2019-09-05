using System;
using System.Collections.Generic;
using System.Text;

namespace Xpto.Behavioral.Mediator.Own.WithEventsAndDelegates
{
    public class DoSomething 
    {
        private event EventHandler<DoSomethingEventArgs> _eventInvoked;

        public DoSomething()
        {
           
        }

        public void Subscribe(EventHandler<DoSomethingEventArgs> eventHandler)
        {
            _eventInvoked += eventHandler;
        }

        public void UnSubscribe(EventHandler<DoSomethingEventArgs> eventHandler)
        {
            _eventInvoked -= eventHandler;
        }

        public void Send(object sender)
        {
           // _eventInvoked()
        }
    }
}
