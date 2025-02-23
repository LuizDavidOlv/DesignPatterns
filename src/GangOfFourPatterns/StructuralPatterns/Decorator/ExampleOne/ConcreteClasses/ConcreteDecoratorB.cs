﻿using src.GangOfFourPatterns.StructuralPatterns.Decorator.ExampleOne;
using System.Buffers.Text;

namespace src.GangOfFourPatterns.StructuralPatterns.Decorator.ExampleOne.ConcreteClasses
{
    public class ConcreteDecoratorB(AbstractComponent _component) : Decorator(_component)
    {
        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
