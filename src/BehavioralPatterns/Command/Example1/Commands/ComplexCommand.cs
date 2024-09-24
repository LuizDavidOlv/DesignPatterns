using src.BehavioralPatterns.Command.Example1.Interfaces;
using System;

namespace src.BehavioralPatterns.Command.Example1.Commands
{
    public class ComplexCommand(Receiver _receiver, string a, string b) : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(a);
            _receiver.DoSomethingElse(b);
        }
    }
}
