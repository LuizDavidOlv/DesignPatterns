using src.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces;
using src.CreationalPatterns.AbstractFactory.CreatorExample.Products;

namespace src.CreationalPatterns.AbstractFactory.CreatorExample.ConcreteFactories
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
