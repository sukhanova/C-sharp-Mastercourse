

string data = "Tim,Jenna,Paul,Sarah,Troy";
List<string> firstNames = data.Split(',').ToList();
firstNames.Add("Will");
firstNames.Remove(firstNames[0]);

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"{firstNames[i]} is in attendance");
}

// Works for later versions
List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(15.91M);
charges.Add(123M);
charges.Add(16.21M);

decimal total = 0;
for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"\nOur total charge is ${total}");