namespace src.GangOfFourPatterns.CreationalPatterns.Singleton.ThreadSafeSingleton
{
    //This singleton implementation is called "double check lock". it is safe in multithreaded environment and provides lazy initialization for the singleton object.
    class Singleton
    {
        private Singleton() { }
        public string Value { get; set; }
        private static Singleton _instance;

        // A new lock object that will be used to synchronize threads during first access to the singleton.
        private static readonly object _lock = new();

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new() { Value = value };
                }
            }
            return _instance;
        }
    }
}
