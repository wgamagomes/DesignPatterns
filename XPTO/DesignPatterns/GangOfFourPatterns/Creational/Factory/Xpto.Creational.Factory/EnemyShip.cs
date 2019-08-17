namespace Xpto.Creational.Factory
{
    public abstract class EnemyShip
    {
        public string Name { get; private set; }

        public double Damage { get; private set; }

        public string FollowHeroShip()
        {
            return $"{Name} is following the hero";
        }

        public string DisplayEnemyShip()
        {
            return $"{Name} is on the screen";
        }

        public string EnemyShipShoots()
        {
            return $"{Name} attacks and does { Damage} damage to hero";
        }
    }
}
