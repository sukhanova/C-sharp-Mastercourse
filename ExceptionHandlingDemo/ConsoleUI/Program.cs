
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void BadCall()
        {

            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex);
                    throw;
                }
            }

            Console.ReadLine();
        }
    }
}