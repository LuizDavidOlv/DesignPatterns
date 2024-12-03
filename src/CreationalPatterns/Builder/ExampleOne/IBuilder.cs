namespace src.CreationalPatterns.Builder.ExampleOne
{
    // The builder interface specifies method for creating the different parts of the product objects
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
