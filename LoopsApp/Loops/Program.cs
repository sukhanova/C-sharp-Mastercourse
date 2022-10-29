
using System;

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// WHILE LOOP:
/* The while loop continuously executes
as long as a given condition is True */

//while (condition)
//{
//    ExecutionContext block
//}

Console.WriteLine("While Loop");
int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
    index++;
}




// FOR LOOP:
//for (initialization; initialization < max; initialization++)
//{
//      execution block
//}
Console.WriteLine();
Console.WriteLine("For Loop");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// DO WHILE LOOP
/*
 The do while loop is very similar to the while loop.
The key distinction is that the do while loop runs the loop once
first before it checks the condition.
This means that even if the condition is false right from the start,
the code inside the loop will still get run once.
 
 */
//do
//{
// execution block
//} while (condition);

Console.WriteLine();
Console.WriteLine("Do While Loop");
int counter = 0;
do
{
    Console.WriteLine(numbers[counter]);
    counter++;
} while (counter < numbers.Length);