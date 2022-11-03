using System;
namespace Methods
{
    public static class MathShortcuts
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"The sum of {x} and {y} is {x+y}");
        }

        public static void AddAll(double[] values)
        {
            double result = values.Sum();
            //double result = 0;
            //foreach (var value in values)
            //{
            //    result += value;
            //}
            Console.WriteLine($"The total is {result}");
        }
    }
}

