using System;
namespace ConsoleCalculationApp
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.WriteLine("Welcome to the Calculationm App!");

            Console.WriteLine($"Hello, {firstName}");
        }
    }
}

