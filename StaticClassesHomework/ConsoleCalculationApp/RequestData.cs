using System;
namespace ConsoleCalculationApp
{
    public class RequestData
    {
        public static string GetAName(string name)
        {
            Console.Write(name);
            string nameOutput = Console.ReadLine();
            return nameOutput;
        }

    }
}

