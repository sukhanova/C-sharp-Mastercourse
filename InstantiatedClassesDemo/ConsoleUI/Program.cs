using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            // Class instantiation from blueprint
            //PersonModel studentOne = new PersonModel();
            //studentOne.firstName = "Tom";
            //Console.WriteLine(studentOne.firstName);

            //// Create list of students and start adding students to the list (using PersonModel class)
            //List<PersonModel> students = new List<PersonModel>();

            //// Variable holds the student info
            //PersonModel student = new PersonModel();
            //student.firstName = "Connie";
            //students.Add(student);

            //student = new PersonModel();
            //student.firstName = "John";
            //students.Add(student);



            //foreach (PersonModel individual_student in students)
            //{
            //    Console.WriteLine(individual_student.firstName);
            //}

            Console.WriteLine("Welcome to App!");

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
          
            do
            {
                
                Console.WriteLine("What is your first name (or type exit/q to stop): ");
                firstName = Console.ReadLine();

                Console.WriteLine("What is your last name: ");
                string lastName = Console.ReadLine();


                if (firstName.ToLower() != "q")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }

            } while (firstName.ToLower() != "q");


            foreach (PersonModel p in people)
            {
                //Console.WriteLine(p.FirstName);
                Console.WriteLine($"{p.FirstName} {p.LastName}");
            }

            Console.ReadLine();

        }
    }
}