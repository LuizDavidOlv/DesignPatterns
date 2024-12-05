using src.StructuralPatterns.Bridge.ExampleOne.Abstractions;
using src.StructuralPatterns.Bridge.ExampleOne.Implementations;
using System;

namespace src.StructuralPatterns.Bridge.ExampleOne
{
    public class BridgePattern
    {
        public static void Execute()
        {
            Client client = new();
            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
