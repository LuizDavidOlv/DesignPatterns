using src.CreationalPatterns.FactoryMethod.CreatorExample.Products;
using src.GangOfFourPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;

namespace src.GangOfFourPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Creators
{
    public class ConcreteCreator2 : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
