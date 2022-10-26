/*
Capture user's age from Console and then identify
how old they will be in 25 years, as well as
how old they were 25 years ago.

Print that information in a Console in a natural language
 */
Console.Write("How old are you? ");
string? userInput = Console.ReadLine();
bool isInputValid = int.TryParse(userInput, out int age);

Console.WriteLine($"Ok, in 25 years you will be {age +25} years old!");

Console.WriteLine($"And 25 years ago you were {age - 25} years old!");