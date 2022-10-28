
bool isValidAge;
int age;

do
{
    Console.Write("How old are you: ");
    string userInput = Console.ReadLine();
    isValidAge = int.TryParse(userInput, out age);

    if (!isValidAge)
    {
        Console.WriteLine("That was invalid age.");
    }

} while (!isValidAge);

Console.WriteLine($"Your age is {age}");
Console.WriteLine("End of program");


bool isDivisible = true;
while (isDivisible)
{
    Console.Write("Type a number between 1 and 21: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        isDivisible = false;
        Console.WriteLine($"Number {number} is divisible");
    }
}





//do
//{
// Run the code at least once
//} while (true);


//while (true)
//{
// Run the code ) or more times
//}