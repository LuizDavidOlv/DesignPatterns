using src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;

namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Products
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
