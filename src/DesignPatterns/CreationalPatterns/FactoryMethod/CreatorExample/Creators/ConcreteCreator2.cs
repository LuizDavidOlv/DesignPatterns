using src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;
using src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Products;

namespace src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Creators
{
    public class ConcreteCreator2 : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
