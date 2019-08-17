using FluentAssertions;
using NUnit.Framework;

namespace Xpto.Creational.Factory.Test
{
    public class SimpleFactoryTest
    {
        private EnemyShipSimpleFactory _simpleFactory;

        [SetUp]
        public void Setup()
        {
            _simpleFactory = new EnemyShipSimpleFactory();
        }

        [Test]
        public void Shoud_Be_Big_UFO_Enemy_Ship()
        {
            var enemyShip = _simpleFactory.MakeEnemyShip("B");
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }

        [Test]
        public void Shoud_Be_Rocket_Enemy_Ship()
        {
            var enemyShip = _simpleFactory.MakeEnemyShip("R");
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }

        [Test]
        public void Shoud_Be_UFO_Enemy_Ship()
        {
            var enemyShip = _simpleFactory.MakeEnemyShip("U");
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }
    }
}
