
// we are passing key and value pairs
Dictionary<string, string> carsInventory = new Dictionary<string, string>();

carsInventory["Chevy"] = "blue";
carsInventory["Honda"] = "white";
carsInventory["Toyota"] = "green";

Console.WriteLine($"We have {carsInventory["Toyota"]} Toyota in inventory");
Console.WriteLine();

Dictionary<int, string> employees = new Dictionary<int, string>();
employees[001] = "Lisa Krispin";
employees[002] = "George O'Reilly";
employees[003] = "Sue Geer";
employees[010] = "Sam Smith";

Console.WriteLine($"The employee with ID number 001 is {employees[001]}");

Console.WriteLine();

// to loop through dictionary we use FOREACH loop

Console.WriteLine("\n Print employee name only");
foreach (var employee in employees.Values)
{
    Console.WriteLine(employee); // prints employee name
}

Console.WriteLine("\n Print employee number only");
foreach (var employee in employees.Keys)
{
    Console.WriteLine(employee); // prints employee number
}


Console.WriteLine("\n Print employee number and name");
foreach (var emp in employees)
{
    Console.WriteLine($"{emp.Key} {emp.Value}");
}