


// string firstName = "";
string firstName = string.Empty;
string lastName = string.Empty;

string filePath = string.Empty;

// to use special characters in string use \ in front of special character
// filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo";
Console.WriteLine(filePath);

Console.Write("What is your name: ");
firstName = Console.ReadLine();

Console.Write("What is your last name: ");
lastName = Console.ReadLine();

// String interpolation
string testString = $@"The file for {firstName} is at C:\SampleFiles";
Console.WriteLine(testString);
Console.WriteLine($"Hello, {firstName} {lastName}");

/* 
 NOTE: Every time you work with string and you manipulate 
 or change it some way - it makes a full copy of string.
So string something you do not want to manipulate
if you do not need to 
*/