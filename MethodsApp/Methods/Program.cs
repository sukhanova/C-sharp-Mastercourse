

using Methods;

string userInputName = SampleMethods.GetUsersName();
SampleMethods.SayHello(userInputName);
SampleMethods.SayGoodbye();


double result = MathShortcuts.Add(3, 91);
Console.WriteLine($"Result is {result}");

// Console.WriteLine($"The result is {MathShortcuts.Add(3, 91)}");

double[] vals = new double[] { 18, 11, 93, 118, 457, 1003 };
MathShortcuts.AddAll(vals);
/*
 SOLID: The First 5 Principles of Object Oriented Design:

SOLID stands for:

S - Single-responsiblity Principle
O - Open-closed Principle
L - Liskov Substitution Principle
I - Interface Segregation Principle
D - Dependency Inversion Principle




1. Single-Responsibility Principle:
A class should have one and only one reason to change,
meaning that a class should have only one job


2. Open-Closed Principle:
Objects or entities should be open for extension
but closed for modification.


3. Liskov Substitution Principle:
Let q(x) be a property provable about objects of x of type T.
Then q(y) should be provable for objects y of type S
where S is a subtype of T.


4.Interface Segregation Principle
A client should never be forced to implement an interface
that it doesn’t use, or clients shouldn’t be forced to depend on methods
they do not use.


5. Dependency Inversion Principle
Entities must depend on abstractions, not on concretions.
It states that the high-level module must not depend on the low-level module,
but they should depend on abstractions.



 */