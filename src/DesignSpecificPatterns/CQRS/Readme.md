<!-- Source: https://www.milanjovanovic.tech/blog/cqrs-pattern-with-mediatr?utm_source=LinkedIn&utm_medium=social&utm_campaign=15.07.2024 -->

# Intent
- CQRS stands for Command Query Responsibility Segregation and it is a design pattern that separates read (queries)  from write (commands) in a system. Instead of  having a single model for both operations, CQRS uses different models for hadling commands (mutations) and queries (reads), optimizing them independently.

# Applicability
- This sepations can be logical of physical and has many benefits
    * Complexity Management
    * Improved Performance
    * Scalability
    * Flexibility 
    * Secutity

- There are many flavors of CQRS
 * SQL on write side and NoSql on the read side
 * Event Sourcing on the write side and NoSql on the read side
 * Using Redis or some other distributed cache on the read side

# Logical Architecture for .net
- MediatR helps to correctly implement the CQRS pattern
- MediatR implments the mediator pattern to solver a simple problem = decoupling the in-process seding of messages from handling messages.
- You can extended MediatR's IRequest interface with a custom ICommand and IQuery abstraction. This allows you to define commands and queries in your system explicitly.
- On the write side, EF Core is recommended. Use EF Core and rich domain model to encapsulate business logic. The command flow uses EF to load an entity into memory, execdute the domain logic, and save the changes to the database.
- On the read side, it is recomended to have as litttle indericetion as possible. Using Dapper with raw SQL queries is an execellent choice. You can also create views in the database and query them. Alternatively, you could use EF Core to execute queries with projections. 
