<!-- Source: https://refactoring.guru/design-patterns/chain-of-responsibility -->

# Intent
- Chain of Responsability lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

# Applicability
    
- Use it when your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.

    * The pattern lets you link several handlers into one chain and, upon receiving a request, "ask" each handler wheter it can process it. This way all handlers get a chance process the request.


- Use the pattern when it's essential to execute several handler in a particular order.  

    * Since you can link the handler in the cahin in any order, all requests will get through the chain exactly as planned.


- Use CoR pattern when the set of handlers and their order are supposed to change at runtime.

    * If you provide setters for a reference field inside the handler classes, you will be able to insert, remove or reorder handlers dynamically.


# Pros and Cons

- Pros
    * You can control the order of request handling.

- Cons
    * Some requests may end up unhandled
