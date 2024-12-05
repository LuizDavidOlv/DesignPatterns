using src.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.StructuralPatterns.Bridge.ExampleOne.Abstractions
{
    public class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
    {
        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
