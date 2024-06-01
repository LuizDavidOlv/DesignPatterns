namespace src.DesignPatterns.CreationalPatterns.AbstractFactory.CreatorExample.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
