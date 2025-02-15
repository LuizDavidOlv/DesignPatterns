﻿using src.GangOfFourPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Interfaces;

namespace src.GangOfFourPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Handlers
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            // Returning a handler from here will let us link handlers in covenient way:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
