using src.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;

namespace src.CreationalPatterns.AbstractFactory.CreatorExample.Products
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
