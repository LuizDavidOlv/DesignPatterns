using System;

namespace src.GangOfFourPatterns.StructuralPatterns.Decorator.ExampleOne
{
    public class Client
    {
        public void ClientCode(AbstractComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
