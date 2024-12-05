##### Source:https://refactoring.guru/design-patterns/bridge

# Bridge

## Intent
- Bridge is a structural design pattern that lets you split a large class or a set of closely related
classes into two separate hierarchies-abstraction and implementation - which can be developed
idependently of each other.


## Applicability
- Use the Bridge pattern when you want to divide and organize a monilithic class that has several
variants of some functionality ( Example: The class can work with variaous database servers)
	* The bigger a class becomes, the harder it is to figure out how it works, and the longer it takes to make a change.
	The changes made to one of the variations of funcionality may require making changes across the whole class, which often
	results in making errors or not addressing some critial side effects.
	* The Bridge pattern lets you split the monolithic class into several class hierarchies. After this, you can change the 
	classes in each hierarchy independently of the classes in the others.This approach simplifies code maintenance and minimizes
	the risk of breaking existing code
	
- Use the pattern when you need to extend a class in several orthogonal dimensions
	* The Bridge suggests that you extract a separete class hierarchy for each of the dimensions. The original class delegastes 
	the related work to the objects belonging to those hierarchies instead of doing everthing on its own.
	
- Use it if you need to be able to switch implementations at runtime
	* Although it's optional, the Bridge pattern lets you replace the implementations object inside the abstraction. 
	It's as easy as assigning a new value to a field
	* This last item is the main reason why so many people confuse the Bridge with Strategy pattern. Remember that a pattern is 
	more than just a certain way to structure your classes. It may also communicate intent and a problem being addressed.


## How to implement
-Identify the orthogonal dimension in your classes. These independent concepts could be: abstraction/platform, domain/infrastructure,
front-end/back-end, or interface/implementation.
- See what operations the client needs and define them in the base abstraction class
- Determine the operations available on all platform. Declare the ones that the abstraction needs in the general implementation interface.
- For all platforms in your domain create concrete implementation classes, but make sure they all follow the implementation interface.
- Inside the abstraction class, add a reference field for the implementation type. The abstraction delegates most of the work to the 
implementation object that's referenced in that field
- If you have several variants of high-level logic, create refined abstractions for each variant by extending the base abstraction class.
- The client code should pass an implementation object to the abstraction's constructuor to associate one with the other. After that, the
client can forget about the implementation and work only with the abstraction object.


## Relations with other patterns
- Bridge can be used along with Abstract Factory. This pairing is useful when some abstractions defined by Drige can only work with specific
implementations. In this case, Abstract Factory can encapsulate these relations and hide the complexity from the client code.
- Bridge can be combined with Builder: the director class plays the role of the abstractions, while different builders act as implementations.