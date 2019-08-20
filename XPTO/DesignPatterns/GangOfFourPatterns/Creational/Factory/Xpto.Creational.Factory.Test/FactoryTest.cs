using FluentAssertions;
using NUnit.Framework;

namespace Xpto.Creational.Factory.Test
{
    public class FactoryTest
    {
        private Factory _simpleFactory;

        [SetUp]
        public void Setup()
        {
            _simpleFactory = new Factory();
        }

        [Test]
        public void Should_Be_Big_UFO_Enemy_Ship()
        {
            var enemyShip = _simpleFactory["B"];
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }

        [Test]
        public void Should_Be_Rocket_Enemy_Ship()
        {
            var enemyShip = _simpleFactory["R"];
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }

        [Test]
        public void Should_Be_UFO_Enemy_Ship()
        {
            var enemyShip = _simpleFactory["U"];
            enemyShip.FollowHeroShip().Should().Be($"{enemyShip.Name} is following the hero");
            enemyShip.DisplayEnemyShip().Should().Be($"{enemyShip.Name} is on the screen");
            enemyShip.EnemyShipShoots().Should().Be($"{enemyShip.Name} attacks and does {enemyShip.Damage} damage to hero");
        }
    }
}
