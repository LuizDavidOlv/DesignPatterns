using src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Interfaces;

namespace src.GangOfFourPatterns.StructuralPatterns.Bridge.ExampleOne.Implementations
{
    //Each Concrete Implementation corresponds to a specific platform and
    //implements the Implementation interface using the plataform's API
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}
