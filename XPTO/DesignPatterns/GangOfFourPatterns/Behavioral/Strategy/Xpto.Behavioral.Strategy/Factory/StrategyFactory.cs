using Xpto.Behavioral.Strategy.Events;
using Xpto.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xpto.Behavioral.Strategy.Factory
{
    public  class StrategyFactory
    {
        private static List<IStrategy> _strategies;
        
        public IStrategy this[StrategyType key]
        {
            get
            {
                if (_strategies == null)
                {
                    _strategies = AppDomain
                        .CurrentDomain
                        .GetAssemblies()
                        .SelectMany(assembly => assembly.GetTypes().Where(type => type.IsClass && !type.IsAbstract && typeof(IStrategy).IsAssignableFrom(type))
                        .Select(strategy => (IStrategy)Activator.CreateInstance(strategy)))
                        .ToList();
                }

                return _strategies
                  .Where(s => s.StrategyType == key)
                  .FirstOrDefault();
            }
        }
    }
}
