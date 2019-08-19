namespace Xpto.Creational.Factory
{
    public class SimpleFactory
    {
        public EnemyShip MakeEnemyShip(string newShipType)
        {
            EnemyShip newShip = null;

            if (newShipType.Equals("U"))
            {
                newShip = new UFOEnemyShip();
            }
            else if (newShipType.Equals("R"))
            {
                newShip = new RocketEnemyShip();
            }
            else if (newShipType.Equals("B"))
            {
                newShip = new BigUFOEnemyShip();
            }

            return newShip;
        }
    }
}
