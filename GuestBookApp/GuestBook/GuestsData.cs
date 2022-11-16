using System;
namespace GuestBook
{
    public class GuestsData
    {

        public static void WelcomeUser()
        {
            //Console.WriteLine("Welcome to the Guest Book App");

            //Dictionary<string, int> familyInfo = new Dictionary<string, int>();
            //bool exit = false;
            //int totalGuests = 0;

            //while (!exit)
            //{
            //    Console.Write("Type a family or type 'q' to exit: ");
            //    string familyName = Console.ReadLine();
            //    if (familyName.ToLower() == "q")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        Console.Write($"Type numbers of guests from {familyName}'s family: ");
            //        string attendeesInput = Console.ReadLine();
            //        bool isValidInt = int.TryParse(attendeesInput, out int guestNumber);
            //        familyInfo.Add(familyName, guestNumber);
            //        totalGuests += guestNumber;
            //    }

            //    Console.Write("\nList of quest:");
            //    foreach (var family in familyInfo)
            //    {
            //        Console.WriteLine($"{family.Key} {family.Value}");
            //    }

            //    Console.WriteLine($"\nSo far there are {totalGuests} guests");
            //}

            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }


        public static string GetFamilyName()
        {
            Console.Write("What is your family name: ");
            string familyName = Console.ReadLine();


            return familyName;
        }


        public static int GetNumberOfAttendees()
        {
            Console.Write($"Type numbers of guests: ");
            string attendeesInput = Console.ReadLine();
            bool isValidInt = int.TryParse(attendeesInput, out int guestNumber);

            return guestNumber;
        }


        public static bool moreGuestsComing()
        {
            Console.Write("Are there are more guests coming? (yes/no or type 'q' to quit)");
            string userInput = Console.ReadLine();

            bool toContinue = true;
            if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
            {
                return toContinue;
            }
            else
            {
                toContinue = false;
                return toContinue;
            }
        }


        public static (List<string> guestList, int totalGuestsAtParty) GetAllGuestsInfo()
        {
            int totalGuestsCount = 0;
            List<string> guestList = new List<string>();

            do
            {
                guestList.Add(GetFamilyName());
                totalGuestsCount += GetNumberOfAttendees();

            } while (moreGuestsComing());

            return (guestList, totalGuestsCount);
        }


        public static void DisplayGuestList(List<string> guests)
        {
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }


        public static void DisplayTotalGuestsAtParty(int totalGuestCount)
        {
            Console.WriteLine($"The total gust count at party: {totalGuestCount}");
        }

    }
}

