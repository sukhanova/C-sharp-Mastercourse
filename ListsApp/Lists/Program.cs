using System;
using System.Collections.Generic;

// Lists are modern way to store the data

List<string> firstNames = new List<string>();

firstNames.Add("Oliver");
firstNames.Add("Jenna");
firstNames.Add("Billy");
firstNames.Add("Theo");

// print first element in list
Console.WriteLine(firstNames[0]);

// print last element in list
Console.WriteLine(firstNames[firstNames.Count -1]);



// List using Count method
Console.WriteLine(firstNames.Count);

// FOR loop
Console.WriteLine("\n Printing list using for loop");
for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine(firstNames[i]);
}


Console.WriteLine();
// FOREACH loop
Console.WriteLine("\n Printing list using foreach loop");
foreach (string item in firstNames)
{
    Console.WriteLine(item);
}


List<int> ages = new List<int>();
ages.Add(7);
ages.Add(39);

string data = "Smith,Jackson,Stall";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Baker");
lastNames.Add("Franklin");

Console.WriteLine("\n-------------------");
Console.WriteLine("Last names in list:");
for (int i = 0; i < lastNames.Count; i++)
{
    Console.WriteLine(lastNames[i]);
}