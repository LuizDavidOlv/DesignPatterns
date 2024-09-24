using src.BehavioralPatterns.Command.Example1.Interfaces;
using System;

namespace src.BehavioralPatterns.Command.Example1.Commands
{
    public class SimpleCommand(string _payload) : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
        }
    }
}
