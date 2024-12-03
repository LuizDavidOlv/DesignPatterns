using src.BehavioralPatterns.Command.Example1;
using src.CreationalPatterns.Builder.ExampleOne;
using src.CreationalPatterns.Singleton.NaiveSingleton;
using src.CreationalPatterns.Singleton.ThreadSafeSingleton;
using src.DesignPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne;
using src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne;
using src.StructuralPatterns.Adapter.ExampleOne;
using src.StructuralPatterns.Decorator.ExampleOne;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPattern.Execute();
        }
    }
}
