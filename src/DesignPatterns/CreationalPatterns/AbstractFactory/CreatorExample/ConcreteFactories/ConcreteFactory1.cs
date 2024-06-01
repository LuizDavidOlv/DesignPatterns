using src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;
using src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Products;

namespace src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
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
