using src.CreationalPatterns.AbstractFactory.CreatorExample.Products;
using src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;

namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
