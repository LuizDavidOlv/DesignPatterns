using System;

namespace src.GangOfFourPatterns.BehavioralPatterns.Mediator.ExampleOne.Components
{
    public class Component1 : BaseComponent
    {
        //The word "this" refers to the current instance of the class where the method is defined.
        // It is used to pass a reference to the current object to the "_mediator.Notify" method.
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");
            _mediator.Notify(this, "B");
        }
    }
}
