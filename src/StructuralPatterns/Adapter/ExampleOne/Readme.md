# Source: https://refactoring.guru/design-patterns/adapter

# Intent

	## Adapter is a structural design patterns that allows objects with incompatible interfacs to collaborate.



# Applicability

	## Use the Adpater class when you want to use some existing class, but its interface ins't compatible 
	with the rest of your code.
		### The Adapter pattern lets you create a middle-later class that serves as a translator betweeen
		your code and a legacy class, a third-party class or any other class with a weird interface.

	## Use the pattern when you want to reuse several existing subclass that lack some common funcionality
	that can't be added to the superclass.
		### You could extende each subclass and put the missing funcionality into new shild classes. Howerver,
		you will need to duplicate the code aceoss all of these new classes, which "smells really bas".
		