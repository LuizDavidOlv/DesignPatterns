using src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;
using src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Products;

namespace src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
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
