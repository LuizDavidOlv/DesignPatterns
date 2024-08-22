using System;

namespace src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne
{
    class Mediator
    {
        public static void Execute()
        {
            var component1 = new Components.Component1();
            var component2 = new Components.Component2();
            _ = new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
