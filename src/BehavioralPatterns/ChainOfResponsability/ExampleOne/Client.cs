using src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Handlers;
using System;
using System.Collections.Generic;

namespace src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne
{
    public class Client
    {
        // The client code is usually suited to work with a single handler.
        // In most cases, it is not even aware that the handler is part of chain
        public static void ClientCode(AbstractHandler handler)
        {
            List<string> foodList = ["Nut", "Banana", "Cup of coffee"];
            foreach (var food in foodList)
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if(result != null)
                {
                    Console.WriteLine($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
