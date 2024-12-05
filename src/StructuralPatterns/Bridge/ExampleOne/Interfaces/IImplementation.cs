namespace src.StructuralPatterns.Bridge.ExampleOne.Interfaces
{
    /*
     * The implementation defines the interface for all implementation classes. 
     * It doesn't have to match the Abstraction's interface. In fact, the two 
     * interfaces can be enrirely different. Typically the Implementation
     * interface provides only primitive operations, while the Abstraction
     * defines high-level operations bases on those primitives
     */
    public interface IImplementation
    {
        string OperationImplementation();
    }
}
