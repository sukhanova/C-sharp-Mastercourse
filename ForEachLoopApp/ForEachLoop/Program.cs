
string data = "Tory,Oliver,Mike,Paul,Sam";
List<string> firstNames = data.Split(',').ToList();

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}



/*
 Ask user for the first name.
Continue asking for first name until are no more.
Then loop through each name using foreach loop.
Tell each person hello in Console.
 */

bool toExit = false;
List<string> names = new List<string>();
do
{
    Console.Write("Type in name or 'q' to exit: ");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() != "q")
    {
        names.Add(userInput);
    }
    else
    {
        toExit = true;
    }

} while (!toExit);

Console.WriteLine();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}");
}
Console.WriteLine("\n End of program");