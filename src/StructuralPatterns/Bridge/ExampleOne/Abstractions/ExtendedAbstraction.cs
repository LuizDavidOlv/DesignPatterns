using src.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.StructuralPatterns.Bridge.ExampleOne.Abstractions
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation) { }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
