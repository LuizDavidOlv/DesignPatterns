using src.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;
using src.CreationalPatterns.FactoryMethod.CreatorExample.Products;

namespace src.CreationalPatterns.FactoryMethod.CreatorExample.Creators
{
    public class ConcreteCreator1 : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
