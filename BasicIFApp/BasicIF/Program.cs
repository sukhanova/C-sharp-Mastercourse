

// Conditional will help to have branching logic

//bool isComplete = false;


//if (isComplete)
//{
//    Console.WriteLine("Great! Move to the next chapter");
//}
//else
//{
//    Console.WriteLine("Please complete current chapter first");
//}



// you can have multiple if statements
/*
 If statements are executed independent of one another; each one will run.
Else if statements only execute if the previous ifs fail.
 */

//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//if (firstName.ToLower() == "oliver")
//{
//    Console.WriteLine("Welcome back, Oliver!");
//}
//if (firstName.ToUpper() == "JANE")
//{
//    Console.WriteLine("Oh, hello, Jane!");
//}
//else
//{
//    Console.WriteLine($"Hello, {firstName}");
//}
//Console.WriteLine("End of program");


// Write code to accept two integers and check whether they are equal or not
//using System.ComponentModel;

//Console.WriteLine("----------");
//Console.WriteLine("Check whether two integers are equal or not");
//Console.Write("Type in first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Type in second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 == num2)
//{
//    Console.WriteLine($"{num1} and {num2} are equal");
//}
//else
//{
//    Console.WriteLine($"{num1} and {num2} are not equal");
//}

//Console.WriteLine("End of program");


/* Write code to read the age of a candidate and determine whether it is eligible for
casting his/her own vote */

Console.WriteLine("----------");
Console.WriteLine("Check if you are eligible to vote");
Console.Write("How old are you: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 21)
{
    Console.WriteLine("Congratulation! You are eligible for casting your vote.");
}
else
{
    Console.WriteLine("Unfortunately you are too young to vote.");
}

Console.WriteLine("End of program");
