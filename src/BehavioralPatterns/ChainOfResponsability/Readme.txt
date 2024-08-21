# Source: https://refactoring.guru/design-patterns/chain-of-responsibility

# Intent
    Chain of Responsability lets you pass requests along a chain of handlers. Upon receiving a request, 
    each handler decides either to process the request or to pass it to the next handler in the chain.

# Applicability
    

    1. Use it when your program is expected to process different kinds of requests in various ways, 
    but the exact types of requests and their sequences are unknown beforehand.

        1.1 The pattern lets you link several handlers into one chain and, upon receiving a request,
        "ask" each handler wheter it can process it. This way all handlers get a chance process the request.


    2. Use the pattern when it's essential to execute several handler in a particular order.  
    
        2.2 Since you can link the handler in the cahin in any order, all requests will get through the chain exactly as planned.


    3. Use CoR pattern when the set of handlers and their order are supposed to change at runtime.

        3.3 If you provide setters for a reference field inside the handler classes, you will be able to
        insert, remove or reorder handlers dynamically.


# Pros and Cons

    Pros:
        1. You can control the order of request handling.

    Cons:
        1. Some requests may end up unhandled
