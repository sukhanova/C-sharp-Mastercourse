/*
 Write a program to display the cube of the number
up to given an integer.
 */


Console.Write("Type in the number: ");
int userInput = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 0; i <= userInput; i++)
{
    Console.WriteLine($"Number is {userInput} and cube of {i} is {i*i*i}");
}


/*
 Write a program to display n terms of natural number and their sum.
 */

Console.Write("\nType in number: ");
int numberInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The first {numberInput} natural number are:\n {numberInput}");
int total = 0;
for (int j = 1; j <= numberInput; j++)
{
    Console.WriteLine($"{j}");
    total += j;
}

Console.WriteLine($"Total is {total}");