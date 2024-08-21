High level module/classes should not depend on low level module/classes.
Both should depend upon abstractions.
Abstractions should not depend upon details.
Details should depend upon abstractions.

High level module/classes implement business rules or logic in a system
Low level module/classes deals more with detailed operations, in other words, they may write information 
to databases or pass messages to the operation system or services.

In the example below, the high level module is the `Report` class and the low level module is the `Database` class.