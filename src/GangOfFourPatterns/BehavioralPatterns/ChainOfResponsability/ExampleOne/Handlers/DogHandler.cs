﻿namespace src.GangOfFourPatterns.BehavioralPatterns.ChainOfResponsability.ExampleOne.Handlers
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
