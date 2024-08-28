using src.CreationalPatterns.Singleton.NaiveSingleton;
using src.CreationalPatterns.Singleton.ThreadSafeSingleton;
using src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne;
using src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne;
using src.StructuralPatterns.Adapter.ExampleOne;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSafeSingleton.Execute();
        }
    }
}
