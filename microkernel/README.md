Caveats:

Deciding what belongs in the microkernel is often an art. It ought to hold the code that’s used frequently.

The plug-ins must include a fair amount of handshaking code so the microkernel is aware that the plug-in is installed and ready to work.

Modifying the microkernel can be very difficult or even impossible once a number of plug-ins depend upon it. The only solution is to modify the plug-ins too.

Choosing the right granularity for the kernel functions is difficult to do in advance but almost impossible to change later in the game.


Best for:

Tools used by a wide variety of people

Applications with a clear division between basic routines and higher order rules

Applications with a fixed set of core routines and a dynamic set of rules that must be updated frequently