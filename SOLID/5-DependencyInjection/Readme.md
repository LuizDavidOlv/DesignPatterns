# Dependency Injection Principle - DIP

## Definition
- High level module/classes should not depend on low level module/classes. Both should depend upon abstractions.
Additionally, abstractions should not depend upon details. Details should depend upon abstractions.

# Purpose
- This principle decouples high-level and low-level components, making the system easier to refactor and test

## Notes
- High level module/classes implement business rules or logic in a system
- Low level module/classes deals more with detailed operations, in other words, they may write information 
to databases or pass messages to the operation system or services.
