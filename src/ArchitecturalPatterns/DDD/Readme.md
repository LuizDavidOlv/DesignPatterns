<!-- Source: https://en.wikipedia.org/wiki/Domain-driven_design#:~:text=Domain%2Ddriven%20design%20(DDD),which%20have%20their%20own%20model. -->

# Domain Driven Design

## Intent
- Domain-Driven Design is a software development approach focused on modeling software to 
accurately reflect the underlying business domain. It leverages insights from domain experts 
to create a rich, expressive model that drives both the design and implementation of the software.

## Applicability
- DDD is especially beneficial in complex domains where business rules, interactions, and processes 
are intricate. Its primary goal is to decompose a large system into manageable parts, known as 
bounded contexts, each with its own distinct model. Under DDD, the structure and language of the 
code (including class names, methods, and variables) should mirror the business domain.
    * Example: If software processes loan applications, it might have classes like "loan application", "customers", and method such as "accept offer" and "withdraw"
- DDD is most useful in complex domains where business rules, interactions, and processes are not straightfoward.

## Design Types

## Strategic Design
#### Strategic Design is concerned with aligning the software model with the broader business strategy. It provides guidance on how to partition the domain and establish clear boundaries to avoid ambiguity.

#### Bounded Context
- Definition: A bounded context defines the boundary within which a particular model is defined and valid. 
It helps avoid ambiguity in large systems by keeping the meaning of concepts consistent within the boundary.
    * Example: In a baking system, "Account" might mean different things in the context of a savings account system versus a loans system. Each would be in its own bounded context.

#### Ubiquitous Language
- DDD promotes a shared language called ubiquitous language that both developers and domain experts use to communicate. 
This language is consistent across the codebase, documentation, and discussions. It ensured that the software reflects the business domain and helps avoid misunderstanding.

#### Context Mapping
- Involves identifying and documenting the relationships and interactions berween different bounded contexts. 
This mapping helps menage dependencies and integrations across the system

#### Subdomains
- Subdomains are the distinct parts of the business domain that can be modeled separately. 
They are often categorized as core, supporting, or generic, helping teams prioritize which areas are most critical to the business.


## Tactical Design
#### Tactical Design provides the concrete building blocks for implementing the domain model within each bounded context. It includes several patterns and practices that help build a robust, maintainable system.

#### Entity
- Definition: An entity is an object that has a distinct identity, meaning it can be differentiated from other objects bases on an identifier, 
usually a unique key or ID. Entities have a lifecycle and can change their properties over time, but their identity remains the same.
    * Example: In an e-commerce system, a Customer class clould be an entity because each customer has a unique identifier, and their details(adresss, email) may change over time.

#### Value Object
- Definition: A value object is an object that doesn't have a unique identity and is define entirely by its attributes. Value objects are immutable, meaning once created, they cannot be modified.

#### Aggregate and Aggregate Root
- Definition: An aggregate is a cluster of entities and value objects that are treated as a single unit. 
The aggregate root is the entity within the aggregate that serves as the entry point. 
Operations outside the aggregate should only refer to the aggregate root.
    * Example: In a order system, and Order entity might be the aggregate root, and the OrderItem entities are part of the aggregate 
    but cannot be modified or accessed directly from outside the order.
    
#### Factories
- Definition: A factory is responsible for creating complex objects, especially aggregates, and ensuring they are constructured in a valid state. 
The use of factories abstracts the construction process, hiding complex creation logic.


#### Anti-Corruption Layer
- Definition an ACL is protective layer that translates between systems with different models, ensuring that external models do not corrupt the domain model within a bounded context.
    * Example: When integrating with a third-party API that handles customer data differently, and ACL could translate between the third-party model and the internal customer model.




