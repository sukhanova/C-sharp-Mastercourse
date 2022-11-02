

Dictionary<string, int> books = new Dictionary<string, int>();
books.Add("Introduction to Algorithms", 1370);
books.Add("Cracking the Coding Interview", 984);
books.Add("Women Who Dared", 106);

Console.WriteLine("Here are books in your current list: ");
foreach (var item in books)
{
    Console.WriteLine($"{item.Key}, {item.Value} pages");
}
Console.Write("\n What book did you read?: ");
string bookSelection = Console.ReadLine();

// lookup if book in list
if (books.ContainsKey(bookSelection) == true)
{
    Console.WriteLine($"{bookSelection} is already in your collection");
}

else
{
    Console.Write("How many pages did you read?: ");
    int pageCount = Convert.ToInt32(Console.ReadLine());
    books.Add(bookSelection, pageCount);

    Console.WriteLine("\nHere are updated info regarding your books list: ");
    foreach (var item in books)
    {
        Console.WriteLine($"{item.Key}, {item.Value} pages");
    }
}



Console.WriteLine("End of program");