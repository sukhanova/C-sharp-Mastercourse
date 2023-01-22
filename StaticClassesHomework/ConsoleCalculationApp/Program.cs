namespace ConsoleCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstName = RequestData.GetAName("What is your name: ");

            UserMessages.ApplicationStartMessage(userFirstName);
            Console.WriteLine();
        }
    }
}