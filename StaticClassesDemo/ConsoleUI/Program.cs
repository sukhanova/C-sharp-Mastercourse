namespace ConsoleUI
{
    class Program
    {
        // static means you get one copy for entire application
        // it means if we store data - it will store across entire application
        static void Main(string[] args)
        {
            CalculateData.userAge = 39;

            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculateData.Add(x,y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");

            Console.WriteLine();
        }
        
    }
}