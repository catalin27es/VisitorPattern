# VisitorPattern

Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate. This suggests that you place the new behavior into a separate class called visitor, instead of trying to integrate it into existing classes.
The Visitor pattern is built on the double dispatch principle, a mechanism that dispatches a function call to different concrete functions depending on the runtime types of two objects involved in the call.

Structure:
- Visitor : This is an interface or an abstract class used to declare the visit operations for all the types of visitable classes.
- ConcreteVisitor : For each type of visitor all the visit methods, declared in abstract visitor, must be implemented. Each Visitor will be responsible for different operations.
- Visitable (Element) : This is an interface which declares the accept operation. The 'accept' method should have one parameter declared with the type of the visitor interface.
- ConcreteVisitable (ConcreteElement) : These classes implement the Visitable interface and defines the accept operation. The visitor object is passed to this object using the accept operation.
- Client : The Client class is a consumer of the classes of the visitor design pattern. It has access to the data structure objects and can instruct them to accept a Visitor to perform the appropriate processing.
