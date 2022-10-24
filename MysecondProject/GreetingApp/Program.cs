
/* 
Requirements:
In this application we will welcome the user to our application
and then will ask for their name. Finally, we will greet them by name.

Steps:
 - Welcome User To App
- Ask for First Name
- Greet user by name
*/

//  - Welcome User To App

Console.WriteLine("Welcome to the Greeting app!");
Console.WriteLine("____________________________");
Console.WriteLine();

// Ask for First Name
Console.Write("What is your name: ");
string userName = Console.ReadLine();

// Greet user by name
Console.WriteLine($@"Hello and welcome {userName}!");
Console.WriteLine("Thank you for using application. Bye for now!");
Console.ReadLine();