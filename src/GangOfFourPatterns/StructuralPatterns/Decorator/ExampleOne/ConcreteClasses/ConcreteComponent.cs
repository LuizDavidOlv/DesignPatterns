using src.GangOfFourPatterns.StructuralPatterns.Decorator.ExampleOne;
using System.Security.Cryptography.X509Certificates;

namespace src.GangOfFourPatterns.StructuralPatterns.Decorator.ExampleOne.ConcreteClasses
{
    public class ConcreteComponent : AbstractComponent
    {
        public override string Operation()
        {
            return "ConcreteComponenet";
        }
    }
}
