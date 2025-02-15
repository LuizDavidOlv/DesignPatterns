using System;

namespace src.GangOfFourPatterns.CreationalPatterns.Singleton.NaiveSingleton
{
    public sealed class Singleton
    {
        //This constructor should always be private to prevent direct construction calls with the `new` operator
        private Singleton() { }

        // The singleton's instance is stored in a static field. There are multiple ways to initialize this field, all of them have various pros and cons. This is the simplest one, but
        // it  does not work with multithreaded programs.
        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            _instance ??= new Singleton();

            return _instance;
        }

        // Any singleton should define some business logic, which can be executed on its instance.
        public void someBusinessLogic()
        {
            // Add any very simple example here just as an example
            Console.WriteLine($"Business logic example: {_instance.GetHashCode()}");

        }
    }
}
