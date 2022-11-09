using System;
namespace GuestBook
{
    public class GuestsData
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the Guest Book App");

            Dictionary<string, int> familyInfo = new Dictionary<string, int>();
            bool exit = false;
            int totalGuests = 0;

            while (!exit)
            {
                Console.Write("Type a family or type 'q' to exit: ");
                string familyName = Console.ReadLine();
                if (familyName.ToLower() == "q")
                {
                    exit = true;
                }
                else
                {
                    Console.Write($"Type numbers of guests from {familyName}'s family: ");
                    string attendeesInput = Console.ReadLine();
                    bool isValidInt = int.TryParse(attendeesInput, out int guestNumber);
                    familyInfo.Add(familyName, guestNumber);
                    totalGuests += guestNumber;
                }

                Console.Write("\nList of quest:");
                foreach (var family in familyInfo)
                {
                    Console.WriteLine($"{family.Key} {family.Value}");
                }

                Console.WriteLine($"\nSo far there are {totalGuests} guests");
            }

        }
    }
}

