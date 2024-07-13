

using System;

namespace src.DesignPatterns.StructuralPatterns.Facade.C_
{
    public class Client
    {
        // The client code works with complex subsystems through a simple interface provided by the Facade.
        // When a facade manages the lifecycle of the subsytem, the client might not even know about the exixtence of the subsystem.
        // This approach lets you keep the complecity under control.

        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }

    }
}
