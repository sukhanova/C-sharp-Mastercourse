using System;
namespace MethodsHomework
{
    public static class Greeting
    {
        public static string GetUsersName()
        {
            Console.Write("What is your name: ");
            string usersInputName = Console.ReadLine();

            return usersInputName;
        }


        public static void GreetTheUser(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}

