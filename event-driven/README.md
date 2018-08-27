Caveats:

Testing can be complex if the modules can affect each other. While individual modules can be tested independently, the interactions between them can only be tested in a fully functioning system.

Error handling can be difficult to structure, especially when several modules must handle the same events.

When modules fail, the central unit must have a backup plan.

Messaging overhead can slow down processing speed, especially when the central unit must buffer messages that arrive in bursts.

Developing a systemwide data structure for events can be complex when the events have very different needs.

Maintaining a transaction-based mechanism for consistency is difficult because the modules are so decoupled and independent.


Best for:

Asynchronous systems with asynchronous data flow

Applications where the individual data blocks interact with only a few of the many modules

User interfaces