

Console.Write("Type a number between 1 and 10: ");

string? userInput = Console.ReadLine();

// if we try to convert wrong type ("ten" for exple) - app will crash
// int number = int.Parse(userInput);

bool isValidInt = int.TryParse(userInput, out int number);

Console.WriteLine($"This is valid: {isValidInt}. The number was {number}");

Console.WriteLine(number);
Console.WriteLine(number + 10);


double testDouble = number;

// casting
decimal testDecimal = (decimal)testDouble;

