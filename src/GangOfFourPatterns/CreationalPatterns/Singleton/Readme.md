<!-- Source: https://refactoring.guru/design-patterns/singleton -->

# Intent:
- Singleton is a Creational design pattern that lets you ensure that a class has only one instance, while providing a global 
access point to this instance.


# Applicability
- Use the singleton pattern when a class in your program should have just a single instance available to all clients;
 for example, a single database object shared by different parts of the program.

    * The singleton pattern disables all other means of creating objects of a class except for the special creation
    method. This method either creates a new object or returns an existing one if it has already been created.

    
    
- Use the singleton pattern when you need stricter control over global variables.

    * Unlike global variables , the singleton pattern guarantees that there's just one instance of a class. Nothing,
    except for the singleton class itself, can replace the cached instance.

    
# How to Implement
- Add a private static field to the class for storing the singleton instance.
- Declare a public static creation method for getting the singleton instance.
- Implement "lazy initialization" inside the static method. It should create a new object on its first call and 
put it into the static field. The method should always return that instance on all subsequent class.
- Make the constructor of the class private. The static method of the class will still be able to call the constructor,
but not the other objects.
- Go over the client code and replace all direct calls to the singleton's constructor with calls to its static creation
method


# Pros and Cons
- Pros:
    * You can be sure that a class has only a single instance
    * You gain a gloval access point to that instance
    * The singleton object is initialized only when it's requested for the first time

- Cons:
    * Violates The Single Responsability Principle. The pattern solves two problems at the time
    * The Singleton pattern can mask bad design, for instance, when the components or the program know too much about 
    each other.
    The pattern requires special treatment in a multithreaded environmnet so that multiple threads won't create a singleton
    object several times.
    * It may be difficult to unit test the client code of the singleton because many test frameworks rely on inheritance
    when producing mock objects. Since the constructor of the singleton class is private and overriding static methods is
    impossible in most languages, you will need to think of a creative way to mock the singleton. Or just don't write the
    tests.