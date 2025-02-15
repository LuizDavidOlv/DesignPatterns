##### Source: https://refactoring.guru/design-patterns/adapter

# Intent

- Adapter is a structural design patterns that allows objects with incompatible interfaces to collaborate.


# Applicability

- Use the Adpater class when you want to use some existing class, but its interface ins't compatible with the rest of your code.

	- The Adapter pattern lets you create a middle-later class that  serves as a translator betweeenyour code and a legacy class, a third-party class or any other class with a weird interface.

- Use the pattern when you want to reuse several existing subclass that lack some common funcionality that can't be added to the superclass.

	- You could extende each subclass and put the missing funcionality into new shild classes. Howerver, you will need to duplicate the code across all of these new classes, which "smells really bad".

	
# How to Implement
- Make sure that you have at least two classes with imcompatible interfaces:
	* A useful service class, which you can't change (often 3rd-party, legacy or with lots of existing dependencies)
	* One or several client classes that would benefit from using the service class
- Declare the client interface and describe how clients communicate with the service
- Create the adapter class and make ir follow the client interface. Leave all the methods empty for now.
- Add a field to the adapter class to store a reference to the service object. The common practice is to initialize this field via the constructor,
but sometimes it's more convenient to pass it to the adapter when calling its methods.
- One by one, implement all methods of the client interface in the adapater class. The adapter should delegate most of the real work to the service 
object, handling only the interface or data format conversion.
- Clients should use the adapter via the client interface. This will let you change or extend the adapters without affecting the client code.