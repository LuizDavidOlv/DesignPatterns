##### Source: https://refactoring.guru/design-patterns/facade

# Facade

## Definition
- Facede is a strucutal design pattern that provides a simplified interface to a library, a framework
, or any other complex set of classes.It might provide limited funcionality in comparision to working with the 
subsystem sirectly.

- Having a facade is handy when you need to integrate your app with a sophisticated library that
has dozens of features, but you just need a tiny bit of its funcionality.


## Applicability
- Use the Facade pattern when you need to have a limited but straightfoward interface to a complex
subsystem.       
    * Often, subsystems get more complex over time. Even applying design patterns typically leads 
    to creating more classes. A subsystem may become more flexible and easier to reuse in various 
    contexts, but the amount of configuration and boilerplate code it demands from a client grows 
    ever larger. The Facade attempts to fix this problem by providing a shortcur to the most-used 
    features of the subsystem which git most client requirementes.


- Use the Facade when you want to structure a subsystem into layers
    * Create facades to define entry points to each level of a subsystem. You can reduce coupling
    between multiple subsystems by requiring them to communicate only through facades.

## Hot to implement
- Check whether it's possible to provide a simpler interface than what an existing sybsystem already provides.
You are on the right track if this interface makes the client code independent from many of the sybsystem's classes.
- Declare and implement this interface in a new facade class. The facade should redirect the calls from the client code 
to appropriate objects of the subsystem. The facade should be responsible for initializing the subsystem and managing its
further life cycle unless the client code already does this.
- If the facade becomes too big, consider extracting part of its behavior to a new, refined facade class.


## Pros and Cons
- Pros:
    * You can isolate your code from the complexity of a subsystem.
    * You can decouple a client from the subsystem.
    * You can more easily reuse a subsystem in various contexts.
    * You can reduce dependencies of a client on a subsystem.

- Cons:
    * A facade can become a god object coupled to all classes of an app.
    * A facade can hide a bad design of your code.
    * Using a facade may be more work than simply accessing the subsystem directly.

    