using src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Abstractions
{
    public class Abstraction(IImplementation implementation)
    {
        protected IImplementation _implementation = implementation;

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
        }
    }
}
