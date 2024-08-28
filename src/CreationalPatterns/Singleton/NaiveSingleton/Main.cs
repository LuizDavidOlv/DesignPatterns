using System;

namespace src.CreationalPatterns.Singleton.NaiveSingleton
{
    public class NaiveSingleton
    {
        public static void Execute()
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            s1.someBusinessLogic();
            s2.someBusinessLogic();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
