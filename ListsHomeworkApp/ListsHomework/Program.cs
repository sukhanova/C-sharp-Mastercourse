/*
 Add students to a class roster List until there are no more students.
Then print out counts of the students to the Console
 */

//Console.WriteLine("Welcome to class.");
//Console.Write("Please type name to add to class roaster list: ");

//string userInput = Console.ReadLine();

//List<string> studentsInClass = new List<string>();
//studentsInClass.Add(userInput);

//for (int i = 0; i < studentsInClass.Count; i++)
//{
//    Console.WriteLine(studentsInClass[i]);
//}

Console.WriteLine("Welcome to class.\n");
bool addStudents = true;
List<string> classRoster = new List<string>();
do
{
    Console.Write("Please type name to add to class roaster list. Type 'quit' or 'q' to finish: ");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "quit" || userInput.ToLower() == "q")
    {
        addStudents = false;
    }
    else
    {
        classRoster.Add(userInput);
    }

} while (addStudents);

Console.WriteLine("\nStudents in class:");
Console.WriteLine("--------------------");
for (int i = 0; i < classRoster.Count; i++)
{
    Console.WriteLine(classRoster[i]);
}
Console.WriteLine($"\nThere are {classRoster.Count} students in class");
