using src.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;
using src.CreationalPatterns.AbstractFactory.CreatorExample.Products;

namespace src.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
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
