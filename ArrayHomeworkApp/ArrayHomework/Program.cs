

/*
Create an array of 3 names.
Ask the user which number to select
When user gives you a number, return that name.
Make sure to check for invalid numbers
 */

using System.Threading.Tasks;

string[] names = new string[] { "Kate Warne", "Annette Kellerman", "Marie Curie"};

Console.Write("Choose number between 1 and 3 to reveal the name: ");
int userInput = Convert.ToInt32(Console.ReadLine());
if (1 <= userInput && userInput <= 3)
{
    switch (userInput)
    {
        case 1:
            Console.WriteLine(names[0]);
            break;
        case 2:
            Console.WriteLine(names[1]);
            break;
        case 3:
            Console.WriteLine(names[2]);
            break;
    }
}
else
{
    Console.WriteLine("Invalid selection");
}

Console.WriteLine("End of program.");