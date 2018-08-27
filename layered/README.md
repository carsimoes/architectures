Caveats:

Source code can turn into a “big ball of mud” if it is unorganized and the modules don’t have clear roles or relationships.

Code can end up slow thanks to what some developers call the “sinkhole anti-pattern.” Much of the code can be devoted to passing data through layers without using any logic.

Layer isolation, which is an important goal for the architecture, can also make it hard to understand the architecture without understanding every module.

Coders can skip past layers to create tight coupling and produce a logical mess full of complex interdependencies.

Monolithic deployment is often unavoidable, which means small changes can require a complete redeployment of the application.


Best for:

New applications that need to be built quickly

Enterprise or business applications that need to mirror traditional IT departments and processes

Teams with inexperienced developers who don’t understand other architectures yet

Applications requiring strict maintainability and testability standards