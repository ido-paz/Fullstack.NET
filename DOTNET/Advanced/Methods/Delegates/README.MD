# Delegates

* A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.

* Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates. You create a custom method, and a class such as a windows control can call your method when a certain event occurs. 

* A delegate is a form of type-safe function pointer
used by the .NET Framework. Delegates are often used to implement
callbacks and event listeners. A delegate does not need to know
anything about classes of methods it works with.

* A delegate is a reference type. But instead of referring to an object, a delegate refers to a method.
Delegates are used in the following cases:

* Event handlers
* Callbacks
* LINQ
* Implementation of design patterns

https://ahmadnaser.com/c-delegate-in-one-word/

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/