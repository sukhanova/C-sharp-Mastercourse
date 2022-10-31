
// Create an array of four elements, and add values later
//string[] firstNames = new string[5];

//firstNames[0] ="Oliver";
//firstNames[1] = "Kyla";
//firstNames[2] = "Tim";
//firstNames[3] = "Jane";
//firstNames[4] = "Jim";

//Console.WriteLine($"firstName array is {firstNames.Length} names long\n");

//for (int i = 0; i < firstNames.Length; i++)
//{
//    Console.WriteLine(firstNames[i]);
//}


//Console.WriteLine($"Last item in list is {firstNames[4]}");
//firstNames[4] = "Graham";
//Console.WriteLine($"Updated item in list is {firstNames[4]}");


// Create an array of four elements and add values right away 
// string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };


// Create an array of four elements without specifying the size 
string[] lastNames = new string[] { "Koo", "Smith", "Jones" };


string data = "Crosby,Julia,Abby,Mike,Stephen";
// single quote identifies a char, double quotes identifies a string
string[] students = data.Split(',');

// print array values using FOR loop:
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}



// print array values using DO..WHILE loop:
//int counter = 0;
//do
//{
//    Console.WriteLine(students[counter]);
//    counter++;
//} while (counter < students.Length);


// print array values using WHILE loop:
//int counter = 0;
//while (counter < students.Length)
//{
//    Console.WriteLine(students[counter]);
//    counter++;
//}



