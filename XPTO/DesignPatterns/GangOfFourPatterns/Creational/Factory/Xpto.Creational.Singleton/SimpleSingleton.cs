namespace Xpto.Creational.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;
        private static readonly object _lock = new object();

        public static SimpleSingleton Instance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SimpleSingleton();
                }
            }

            return _instance;
        }
    }
}
