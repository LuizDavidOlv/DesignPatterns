using src.CreationalPatterns.AbstractFactory.CreatorExample.Products;
using src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;

namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
