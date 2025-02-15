namespace src.GangOfFourPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
