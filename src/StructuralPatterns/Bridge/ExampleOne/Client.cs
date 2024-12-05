using src.StructuralPatterns.Bridge.ExampleOne.Abstractions;
using System;

namespace src.StructuralPatterns.Bridge.ExampleOne
{
    public class Client
    {
        /*
         * Except for the initialization phase, where an Abstraction object gets
         * linked with a specific Implementation object, the client code should
         * only depend on the Abstraction class. This way the client code can 
         * support any abstraction-implementation combination
         */
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}
