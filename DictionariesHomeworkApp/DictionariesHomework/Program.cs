
/*
Create a Dictionary list of employee ID's and name that goes with ID.
Fill in few records. Then ask user for thei ID and return their name
 */

Console.WriteLine("Employee list app");
Dictionary<int, string> employeesList = new Dictionary<int, string>();
bool exit = false;

while (!exit)
{
    Console.Write("Type an employee name or type 'q' to exit: ");
    string employeeName = Console.ReadLine();
    if (employeeName.ToLower() == "q")
    {
        exit = true;
    }
    else
    {
        Console.Write("Type in number: ");
        int employeeNumber = Convert.ToInt32(Console.ReadLine());
        employeesList.Add(employeeNumber, employeeName);
    }
}

Console.WriteLine($"\n To look up for employee type number between 1 and {employeesList.Count}");
int lookupNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n You are looking for number {lookupNumber}");
foreach (var emp in employeesList)
{
    if (emp.Key == lookupNumber)
    {
        Console.WriteLine($"{emp.Key} {emp.Value}");
        break;
    }
}


Console.WriteLine("\n End of program");
