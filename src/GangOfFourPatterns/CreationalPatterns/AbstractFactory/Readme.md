##### Source: https://refactoring.guru/design-patterns/abstract-factory

# Abstract Factory Intent
- Lets you produce families of realated objects without specifying their concrete classes.


# Applicability:

- Use it when your code needs to work with various families of related products, but you do not want it to depend on the concrete classes of those prouducts-
they might be unknown beforehand or you simply want to allow for furture extensibility
	* This patterns provides an interface for creating objects from each class of the product family. As long as your code creates objects via this interface,
	there is no chance of creating the wrong variant of a product which does not match the products already created by your app.

- Consider implementing this pattern when is needed a class with a set of Factory methods that blur its primary responsibility
	* In a well-designed program each class is responsible only for one thing. When a class deals with multiple products types, it may be worth extracting
	its factory methods into a stand-alone factory class or a full-blown Abstract Factory implementation.

# How to implement
- Map out a matrix of distinct product types versus variants fo these products
- Declare abstract product interfaces for all product types. Them make all concrete product classes implement these interfaces.
- Declare the abstract factory interface with a set of creation methods for all abstract products
- Implement a set of concrete factory classes, one for each prodct variant.
- Create factory initialization code somewhere in the app. It should instantiate one of the concrete factory classes, 
depending on the application configuration or the current environment. Pass this factory object to all classes that construct products.

# Pros and cons

- Pros	
	* You can be sure that the products you are getting from a factory are compatible with each other
	* You avoid tight coupling between concrete products and client code.
	* STP
	* OCP

- Cons
	* The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern