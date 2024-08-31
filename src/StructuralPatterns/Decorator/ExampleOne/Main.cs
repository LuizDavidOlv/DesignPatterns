using src.StructuralPatterns.Decorator.ExampleOne.ConcreteClasses;
using System;

namespace src.StructuralPatterns.Decorator.ExampleOne
{
    public class DecoratorPattern
    {
        public static void Execute()
        {
            Client client = new();
            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // Note how decorators can wrap not only simple components by the other decorators as well.
            ConcreteDecoratorA decorator1 = new(simple);
            ConcreteDecoratorB decorator2 = new(decorator1);
            Console.WriteLine("Client: Now I have got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}
