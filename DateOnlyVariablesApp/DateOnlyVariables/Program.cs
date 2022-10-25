
// this only works with .NET 6 and beyond

// We use DateOnly if we want to have only date events, not time
DateOnly birthday = DateOnly.Parse("12/2/2000");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

DateTime today = DateTime.Now;


Console.WriteLine($"Today full format: {today}"); // Today full format: 10 / 25 / 2022 12:34:30 PM
Console.WriteLine($"Today just date: {today.Date}"); // Today just date: 10 / 25 / 2022 12:00:00 AM
Console.WriteLine($"Birthday full format: {birthday}"); // Birthday full format: 12 / 2 / 2000

Console.ReadLine();



