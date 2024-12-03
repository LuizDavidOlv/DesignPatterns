##### Source: https://refactoring.guru/design-patterns/builder

# Intent
- Builder is a creational design pattern that lets you construct complext objects step by step. 
The pattern allows you to produce different types and representations of an object using the same
constructuion code

# Applicability
- Use the builder patterns to get rid of a "telescoping constructor"
	* Say you have a constructuor with ten optional parameters. Calling such a beast is very inconvenient; 
	therefore, you overload the constructuor and create several shorter versions with fewer parameters. 
	These constructors still refer to the main one, passing some default values into any omitted parameters.
	* The builder pattern lets you build objects step by step, using only those steps that you really need. 
	After implementing the pattern, you don't have to cram dozen of parameters into your constructuors anymore.
- Use it when you want your code to be able to create different representations of some product
	* It can be applied when construction of various representations of the prodct involves similar steps that differ only in the details
	* The base builder interface defines all possible construction steps, and concrete builders implement these
	steps to construct particular representations of the product. Meanshile, the director class guides the order of construction.
- User the Builder to construct Composite trees or other complex objects.
	* The patterns lets you construct products step-by-step. You could defer execution of some steps without breaking the final product. You
	can even call steps recursively, which comes in handy when you need to build an object tree.
	* A builder doesn't expose the unfinished prodct while wunning constructions steps. This prevents the client code from fectching an incomplete result

# How to implement
- Make sure that you can clearly define the common construction steps for building all available product representations. 
Otherwise, you won't be able to preceed with implementing the pattern.
- Declare these steps in the base builder interface
- Create the concrete builder class for each of the product representations and implement their construction steps.
	* Don't forget about implementing a method for fetching the result of the construction. The reason why whis method can't
	be declared inside the builder interface is that various builders may construct products that don't have a common interface.
	Therefore, you don't know what would be the return type for such a method. However, if you're dealing with products from a
	single hierarchy, the fetching method can be safely added to the base interface.
- Think about creating a director class. It may encapsulate varaious ways to construct a prodct using the same builder object.
- The client code creates both the builder and the director objects. Before construction starts, the client must pass a builder object to the director.
usually, the client does this only once, via parameters of the director's  class constructor. The director uses the builder object in all further construction. 
There's an alternative approach, where the builder is passes to a specific product construction method of the director.
- The construction result can be obtained directaly from the director only if all products follow the same interface. Otherwise, the client should fetch
the result from the builder.