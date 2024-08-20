namespace src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.C_.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}
