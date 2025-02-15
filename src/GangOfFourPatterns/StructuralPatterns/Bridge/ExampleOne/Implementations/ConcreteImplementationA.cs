using src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Implementations
{
    //Each Concrete Implementation corresponds to a specific platform and
    //implements the Implementation interface using the plataform's API
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
