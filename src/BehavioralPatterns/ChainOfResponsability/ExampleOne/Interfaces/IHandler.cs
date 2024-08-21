namespace src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}
