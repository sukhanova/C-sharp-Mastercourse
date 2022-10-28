
/*
 Create a Console App that asks the user for their name.
Welcome Tim as a professor or anyone else as student.
Do this until the user types "exit"
 */

bool wantToExit = false;

while (!wantToExit)
{
    Console.Write("What is your name: ");
    string inputName = Console.ReadLine();
    string greeting;
    if (inputName.ToLower() == "tim")
    {
        greeting = $"Professor Tim";
        Console.WriteLine("Hello, {0}", greeting);
    }
    else if(inputName.ToLower() != "exit")
    {
        greeting = $"student {inputName}";
        Console.WriteLine("Hello, {0}", greeting);
    }
    else
    {
        wantToExit = true;
    }
}

Console.WriteLine("End of program.");