# Definition

    A facace is a class that provides a simple interface to a complex subsystem which contains lots of
    moving parts. A facade might provide limited funcionality in comparision to working with the 
    subsystem sirectly. However, it includes only those features that clients really care about.

    Having a facade is handy when you need to integrate your app with a sophisticated library that
    has dozens of features, but you just need a tiny bit of its funcionality.


# Applicability

    1) Use the Facade pattern when you need to have a limited but straightfoward interface to a complex
    subsystem.
        
        1.1) Often, subsystems get more complex over time. Even applying design patterns typically leads 
        to creating more classes. A sybsystem may become more flexible and easier to reuse in various 
        contexts, but the amount of configuration and boilerplate code it demands from a clietn frows 
        ever larger. The Facade attempts to fix this problem by providing a shortcur to the most-used 
        features of the subsystem which git most client requirementes.


    2) Use the Facade when you want to structure a subsystem into layers

        2.1) Create facades to define entry points to each level of a subsystem. You can reduce coupling
        between multiple subsystems by requiring them to communicate only through facades.


# Pros and Cons

    Pros:
        1) You can isolate your code from the complexity of a subsystem.
        2) You can decouple a client from the subsystem.
        3) You can more easily reuse a subsystem in various contexts.
        4) You can reduce dependencies of a client on a subsystem.

    Cons:
        1) A facade can become a god object coupled to all classes of an app.
        2) A facade can hide a bad design of your code.
        3) Using a facade may be more work than simply accessing the subsystem directly.

    