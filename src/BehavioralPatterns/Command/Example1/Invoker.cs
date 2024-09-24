using System;
using System.Windows.Input;

namespace src.BehavioralPatterns.Command.Example1
{
    public class Invoker
    {
        private Interfaces.ICommand _onStart;
        private Interfaces.ICommand _onFinish;

        public void SetOnStart(Interfaces.ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(Interfaces.ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (_onStart is Interfaces.ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (_onFinish is Interfaces.ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
