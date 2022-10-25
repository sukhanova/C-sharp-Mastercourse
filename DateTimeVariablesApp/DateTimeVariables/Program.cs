
using System.Globalization;

DateTime today = DateTime.Now;

//Console.WriteLine(today);
//Console.WriteLine(today.ToString("d")); // prints date only

// DateTime birthday = DateTime.Parse("1/1/2001");
//DateTime birthday = DateTime.ParseExact("10/11/2001", "dd/M/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(birthday.ToString());


Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));