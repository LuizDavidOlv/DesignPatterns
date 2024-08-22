using src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne.Interfaces;

namespace src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne.Components
{
    public class BaseComponent
    {
        protected IMediator _mediator;

        //public BaseComponent(IMediator mediator = null)
        //{
        //    this._mediator = mediator;
        //}

        // Expression-bodied syntax introduced in c# 6.0
        public BaseComponent(IMediator mediator = null) => this._mediator = mediator;
        public void SetMediator(IMediator mediator) => this._mediator = mediator;
    }
}
