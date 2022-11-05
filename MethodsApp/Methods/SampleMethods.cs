using System;
namespace Methods;

public static class SampleMethods
{

    public static string GetUsersName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }


    public static void SayHello(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}");
        Console.WriteLine("Welcome to super cool app!");
    }


    public static void SayGoodbye()
    {
        Console.WriteLine("Thank you for visiting!");
    }
}

