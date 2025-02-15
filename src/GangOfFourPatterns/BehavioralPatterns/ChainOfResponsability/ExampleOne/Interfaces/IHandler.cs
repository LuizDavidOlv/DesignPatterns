namespace src.GangOfFourPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}
