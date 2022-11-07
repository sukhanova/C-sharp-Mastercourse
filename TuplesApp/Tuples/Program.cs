

using Tuples;


// Tuples will work in .Net Core and above projects only
// use tuples if you want to return more than 1 value from given method


// if you do not need one of parameters - use discard character (_) instead and comment console output
// (string firstName, _) name = ConsoleMessages.GetFullName();

(string firstName, string lastName) name = ConsoleMessages.GetFullName();

Console.WriteLine($"First Name: {name.firstName}");
Console.WriteLine($"Last Name: {name.lastName}");