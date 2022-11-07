
/*
 Create a welcome method,
a method to ask for user's name
and another to tell taht user "Hello, <name>".
Call this methods form Program.cs
 */

using MethodsHomework;

Console.WriteLine("Welcome to the Greeting App\n");
string userInput = Greeting.GetUsersName();
Greeting.GreetTheUser(userInput);
Console.WriteLine("\nEnd of program");
