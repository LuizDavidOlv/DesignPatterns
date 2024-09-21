##### Source: https://refactoring.guru/design-patterns/factory-method

# Intent
- Factory Method, also known as virtual constructor, provides an interface for creating
objects in a superclass, but allows subclasses to alter the type of objects that will be created.


# Applicability:

- Use factory method when you do not need to know beforehand the exact types
and dependencies of the objects your code should work with.
 
	* Separates product construction code from the code that actually uses the product. 
	Therefore it is easier to extende the product construction code independently from the rest of the code.

	* Example: To add a new product type to the app, you will only need to create a
	new creator subclass and override the factory method in it.

- Use it when you want to provide user of your library or framework with a way
to extend its internal components

	* Inheritance is probably the easiest way to extend the default behavior
	of a library or framework.

- Use it when you want to save system resources by reusing existing objects instead
of rebuilding them each time.

	* This ofen happens when dealing with large, resource-intensive objects 
	such as databases connections, file systems, and network resources.


# Pros and cons

### Pros
- Avoid tight coupling between the creator and the concret products
- Single Responsability Principle: It is possible to move the product
creation code into one place in the program, making the code easier to support
- Open/Closed Principle. You can introduce new types of products into the the 
program without breaking existing client code.

### Cons
- The code may become more complicated since you need to introduce a lot of new 
subclasses to implement the pattern. The best case scenario is when you are 
introducing the pattern into an existing hierarchy of creator classes.
