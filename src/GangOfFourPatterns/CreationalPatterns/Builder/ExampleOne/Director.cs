using System;

namespace src.GangOfFourPatterns.CreationalPatterns.Builder.ExampleOne
{
    /*
     * The Director is DateOnly responsible for executing the building steps in a particilar sequence. It is helpful when producing products acording
     * to a specific order or configuration. Strictly speaking, the Director class is optional, since the client can control builders directly 
     */
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        //The Director can constuct several product variations using the same building steps
        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }

    }
}
