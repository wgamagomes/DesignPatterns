namespace Xpto.Creational.Factory
{
    public abstract class EnemyShip
    {
        public string Name { get; protected set; }

        public double Damage { get; protected set; }

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
