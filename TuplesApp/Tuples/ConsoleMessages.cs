using System;
namespace Tuples
{
    public static class ConsoleMessages
    {
        public static void SayHello(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}");
            Console.WriteLine("Welcome to super cool app!");
        }


        public static string GetUsersName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }


        // Tuple
        public static (string, string) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }


        public static void SayGoodbye()
        {
            Console.WriteLine("Thank you for visiting!");
        }
    }
}

