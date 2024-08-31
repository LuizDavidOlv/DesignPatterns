##### Source: https://refactoring.guru/design-patterns/decorator

# Intent
- Decorator is a structural design pattern that lets you attach new behaviors to objects by
placing these objects inside special wrapper objects that contain the behavior.

- 
# Applicacability
- Use the it when you need to be able to assign extra behaviors to objects at runtime without breaking
the code that uses these objects.
	* The Decorator lets you structure your business logic into layers, create a decorator for each
	layer an compose objects with various combinations of this logic at runtime. The client code can
	treat all these objects in the same way, since they all follows a common interface.

- Use the pattern when it's awkward or not possible to extende an object's behavior using inheritance.
	* Many programming languages have the ``final`` keyword that can be used to prevent further extension 
	of a class. For a final class, the only way to reuse the existing behavior would be to wrap the class
	with your own wrapper, using the Decorator pattern.

	
# How to implement
- Make sure your business domain can be repsented as a primrary component with multiple optional layer
over it.
- Figure out what methods are common to both the primary component and the optional layers. Create a
componenet interface and declare those methods there.
- Create a base decorator class. It should have a field for storing a reference to a wrapped object.
The field should be declared with the component interface type to allow linking to concrete components
as well as decorators. The base decorator must delegate all work to the wrapped object.
- Make sure all classes implement the component interface.
- Create concrete decorators by extending them from the base decorator. A concreate decorator must
execute its behavior before or after the call to the parent method (which always delegates to the 
wrapped object).
- The client code must be responsible for creating decorators and composing them in the ways the 
client needs.


# Pros and Cons

- Pros
	* You can extend an object's behavior without making a new subclass.
	* You can add or remove responsabilities from an object at runtime.
	* You can combine several behaviors by wrapping an object into multiple decorators.

- Cons
	* It's hard to remove a specific wrapper from the wrappers stack.
	* It's hard to implement a decorator in such a way that its behavior doesn't depend on ther order
	in the decorators stack.
	* The initial configuration code of layers might look pretty ugly.