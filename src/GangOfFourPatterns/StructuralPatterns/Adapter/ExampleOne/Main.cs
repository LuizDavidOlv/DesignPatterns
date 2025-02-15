using System;

namespace src.GangOfFourPatterns.StructuralPatterns.Adapter.ExampleOne
{
    public class AdapterPattern
    {
        public static void Execute()
        {
            Adaptee adaptee = new();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());
        }


    }
}
