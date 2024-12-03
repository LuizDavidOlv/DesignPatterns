# Open/Closed Principle - OCP

## Defition
- A class should be open for extension and closed for modification.

# Purpose
- The goal is to design modules that allow behavior to be added or modified without altering the existing code.
This minimizes the risk of introducing bugs in previously working code.

## Notes
- "Open for extension" means we must design our module/class so that new functionality can be added only when new requirements
are generated. "Closed for modification" means we have already developed a class, and it has gone through unit testing. We should
not alter it until we find bugs.