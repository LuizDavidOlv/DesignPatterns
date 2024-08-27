﻿using src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne.Components;
using src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne.Interfaces;
using System;

namespace src.DesignPatterns.BehavioralPatterns.Mediator.ExampleOne
{
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if(ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                _component2.DoC();
            }
            if(ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                _component1.DoB();
                _component2.DoC();
            }
        }
    }
}