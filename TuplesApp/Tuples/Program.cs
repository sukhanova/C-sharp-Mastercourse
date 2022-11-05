

using Tuples;


// Tuples will work in .Net Core and above projects only
// use tuples if you want to return more than 1 value from given method


(string, string) fullName = ConsoleMessages.GetFullName();

Console.WriteLine($"First Name: {fullName.Item1}");
Console.WriteLine($"Last Name: {fullName.Item2}");