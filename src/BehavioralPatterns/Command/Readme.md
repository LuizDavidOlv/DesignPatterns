<!--Source: https://refactoring.guru/design-patterns/command -->

# Intent
- Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request's execution, and support undoable operations

# Applicability
- Use the command pattern whe you want to parametrize objects with operations
    * The Command patterns can turn a specific method call into a stand-alone object. This change opens up a lot of interesting uses: you can pass commands as method arguments, store them inside other objects, switch linked commands at runtime, etc.

- Use the Command pattern when you want to queue operations, schedule their execution, or execute them remotely.
    * As with any other object, a command can be serialized, which means converting it to a string that can be easily written to a file or a database. Later, the string can be restored as the initial command object. Thus, you can delay and schedule command execution. In the same way, you can queue, log or send commands over the network.

- Use the Command pattern when you want to implement reversible operations.
    * To be able to revert operations, you need to implement the history of performed operations. The command history is a stack that constains all executed command objects along with related backups of the applications's state.
    * This method has to two drawbacks. 
        - First, it isn't that easy to sabe an application's state because some of it can be private. This problem can be mitigated with the Memento pattern.
        - Second, the state backups may consume quiet a lot of RAM. Therefore, sometimes you can resort to an alternative implementation: instead of restoring the past state, the command peforms the inverse operation. The reverse operation also has a price: it may turn out to be gard or even impossible to implement.


# How to Implement
- Declare the command interface with a single execution method
- Start extracting requests into concrete command classes that implement the command interface. Each class must have a set of field for storing the request arguments along with a reference to the actual receiver object. All the values must be initialized via the command's constructor. 
- identify classes that will act as senders. Add the fields for storing commands into these classes. Senders usually don't create command objects on their own, but rather get them from the client code.
- Change the sender so they execute the command instead of sending a request to the receiver directly.
- The client should initialize objects in the folowing order:
    * Create receivers
    * Create commands, and associate them with receivers if needed
    * Create senders, and associate them with specific commands
