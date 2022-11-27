
/*
 Create a Console App with for loop that multiplies a number by five
and adds it to the total each time
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a max number: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= maxNum; i++)
            {
                int result  = i * 5 ;
                Console.WriteLine($"The value of i is {result}");
                total += result;
                Console.WriteLine($"And total is {total}");
                
            }
            Console.ReadLine();
        }
    }
}