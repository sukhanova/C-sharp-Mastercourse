
/*
 Ask the user for a comma-separated list of names (no spaces).
Split the string into a string array.
Loop through the array and print "Hello <name>" to the Console
for each person.
 */

Console.Write("Type in comma separated list of names: ");
string userInput = Console.ReadLine();

List<string> names = userInput.Split(',').ToList();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello, {names[i]}");
}


/*
 Write a program to find the sum of first 10 natural numbers.
 Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55
 */
Console.WriteLine("\n Exercise #2");
int total = 0;
for (int i = 0; i <= 10; i++)
{
    total += i;
}
Console.WriteLine($"The Sum is {total}");



/*
 Write a program to display n terms of natural number and their sum.
Test Data : 7
Expected Output :
The first 7 natural number is :
1 2 3 4 5 6 7
The Sum of Natural Number upto 7 terms : 28
 */

Console.WriteLine("\n Exercise #3");
Console.Write("Type a natural number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers = 0;
for (int i = 0; i <= inputNumber; i++)
{
    Console.WriteLine($"{i}");
    sumOfNumbers += i;
}

Console.WriteLine($"\n The The Sum of Natural Number upto {inputNumber} terms : {sumOfNumbers}");