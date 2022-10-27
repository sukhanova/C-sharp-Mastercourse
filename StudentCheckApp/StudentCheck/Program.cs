/*
 Create Console application that asks a user for their name and their age.
If their name is Bob or Sue - address them as Professor.
If the person is under 21, reccomnend wait X years to start this class
 */

Console.Write("What is your name: ");
string? userName = Console.ReadLine();

Console.Write("How old are you: ");
int userAge = Convert.ToInt32(Console.ReadLine());

if ((userName.ToLower() == "bob" || userName.ToLower() == "sue") && (userAge > 21))
{
    Console.WriteLine($"Hello and welcome, Professor {userName}");
}
else
{
    if (userAge > 21)
    {
        Console.WriteLine($"Hello,{userName}. Welcome to the program");
    }
    else
    {
        Console.WriteLine($"Hello, {userName}. Unfortunately you are younger than 21 to take this course.\n " +
            $"Please come back in {21 - userAge} years.");
    }
}


Console.WriteLine("End of program");