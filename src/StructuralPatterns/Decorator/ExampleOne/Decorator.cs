using System.ComponentModel;

namespace src.StructuralPatterns.Decorator.ExampleOne
{
    public class Decorator(AbstractComponent _component) : AbstractComponent
    {
        public void SetComponent(AbstractComponent component)
        {
            _component = component;
        }

        //The Decorator delegates all work to the wrapped component.
        public override string Operation()
        {
            if(_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
