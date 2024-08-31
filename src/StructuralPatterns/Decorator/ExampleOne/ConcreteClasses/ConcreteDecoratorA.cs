namespace src.StructuralPatterns.Decorator.ExampleOne.ConcreteClasses
{
    public class ConcreteDecoratorA(AbstractComponent _component) : Decorator(_component)
    {
        // Decorators may call parent implementation of the operations, instead of calling the
        // wrapped object directly. This approach simplifies extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreateDEcoratorA({base.Operation()})";
        }
    }
}
