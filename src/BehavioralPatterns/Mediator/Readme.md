<!-- Source: https://refactoring.guru/design-patterns/mediator -->


# Intent
- Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects.
The pattern restricts direct communications between the objects and forces them to collaborate only
via a meditor object.

# Applicability

- Use the Mediator pattern when it's hard to change some of the classes because they are tightly
coupled to a bunch of other classes.
		
	* The pattern lets you extract all the relationships between classes into a separate class,
	isolating any changes to a specific component from the rest of the componenets.


- Use the pattern when you can't reuse a component in a different program because it's too
dependent on other components.

	* After you apply the Mediator, individual components become unaware of the other components.
	They could still communicate with each other, albeit indirectly, through a mediator object. To
	Reuse a component in a different app, you need to provide it with a new mediator class.
	

- Use the Mediator when you find yourself creating tons of component subclasses just to reuse some
basic behavior in various contexts.

	* Since all relations between componenets are contained within the mediator, it's eady to
	define entirely new ways for these components to collaborate by introducing new mediator classes,
	without having to change the componenets themselves.


# Pros and Cons

- Pros:
	* You can reduce coupling between various components of a program.
	* You can reuse individual components more easily

- Cons:
	* Over time a mediator can evolve into a God Object.