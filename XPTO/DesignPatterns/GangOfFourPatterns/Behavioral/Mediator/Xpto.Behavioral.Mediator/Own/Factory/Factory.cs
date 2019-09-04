using System;
using System.Collections.Generic;
using System.Linq;

namespace Xpto.Behavioral.Mediator.Own
{
    public class Factory<THandler>
    {
        private static List<THandler> _handlers;

        public static List<THandler> GetHandlers
        {
            get
            {
                if (_handlers == null)
                {
                    _handlers = AppDomain
                        .CurrentDomain
                        .GetAssemblies()
                        .SelectMany(assembly => assembly.GetTypes().Where(type => type.IsClass && !type.IsAbstract && typeof(THandler).IsAssignableFrom(type))
                        .Select(handlerType => (THandler)Activator.CreateInstance(handlerType)))
                        .ToList();
                }

                return _handlers;
            }
        }
    }
}

