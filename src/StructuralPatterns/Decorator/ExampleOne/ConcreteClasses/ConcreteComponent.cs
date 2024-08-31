using System.Security.Cryptography.X509Certificates;

namespace src.StructuralPatterns.Decorator.ExampleOne.ConcreteClasses
{
    public class ConcreteComponent : AbstractComponent
    {
        public override string Operation()
        {
            return "ConcreteComponenet";
        }
    }
}
