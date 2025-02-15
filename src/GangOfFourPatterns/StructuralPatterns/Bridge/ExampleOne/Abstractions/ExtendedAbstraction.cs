using src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Abstractions
{
    public class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
    {
        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
