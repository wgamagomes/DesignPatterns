using System;
using System.Collections.Generic;
using System.Linq;

namespace Xpto.Creational.Factory
{
    public class Factory
    {
        private static List<EnemyShip> _enemyShipList;

        public EnemyShip this[string shipType]
        {
            get
            {
                if (_enemyShipList == null)
                {
                    _enemyShipList = AppDomain
                        .CurrentDomain
                        .GetAssemblies()
                        .SelectMany(assembly => assembly.GetTypes().Where(type => type.IsClass && !type.IsAbstract && typeof(EnemyShip).IsAssignableFrom(type))
                        .Select(enemyShip => (EnemyShip)Activator.CreateInstance(enemyShip)))
                        .ToList();
                }

                return _enemyShipList
                    .Where(e => e.ShipType == shipType)
                    .FirstOrDefault();
            }
        }
    }
}
