namespace Xpto.Creational.Singleton
{
    /// <summary>
    /// Essentially, a singleton is a class which only allows a single 
    /// instance of itself to be created, and usually gives simple access 
    /// to that instance. 
    /// https://csharpindepth.com/Articles/Singleton
    /// </summary>
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;
        private static readonly object _lock = new object();

        public static SimpleSingleton Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleSingleton();
                    }
                }
            }
                return _instance;
        }
    }
}
