
/*
 Write code to accept the height of a person in centimeter
and categorize the person according to their height.
 
 */
//Console.Write("What is your height: ");
//float userHeight = Convert.ToInt32(Console.ReadLine());

//if (userHeight < 150.0)
//{
//    Console.WriteLine("You are a dwarf");
//}
//else if (userHeight >= 150.0 && userHeight <= 165.0)
//{
//    Console.WriteLine("You have average height");
//}
//else if (userHeight >= 165.0 && userHeight <= 195.0)
//{
//    Console.WriteLine("You are tall");
//}
//else
//{
//    Console.WriteLine("Abnormal height");
//}

//Console.WriteLine("End of program");

/*
 Write a program to read temperature in centigrade
and display a suitable message according to temperature state below:
Temp < 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot
Test Data :
 */

//Console.Write("What is the temperature on thermometer: ");
//int tempInput = Convert.ToInt32(Console.ReadLine());

//if (tempInput < 0)
//{
//    Console.WriteLine("Freezing weather");
//}
//else if (tempInput <= 10)
//{
//    Console.WriteLine("Very Cold weather");
//}
//else if (tempInput <= 20)
//{
//    Console.WriteLine("Cold weather");
//}
//else if (tempInput <= 30)
//{
//    Console.WriteLine("It's Normal");
//}
//else if (tempInput <= 40)
//{
//    Console.WriteLine("It's Hot");
//}
//else if (tempInput >= 40)
//{
//    Console.WriteLine("It's very Hot");
//}

//Console.WriteLine("End of program");

//Identify if you are eligible to register for service

Console.Write("Are you male: ");
string userSex = Console.ReadLine();

Console.Write("How old are you? ");
int userAge = Convert.ToInt32(Console.ReadLine());

if ((userSex.ToLower() == "yes") && (userAge >= 18 && userAge <= 26))
{
    Console.WriteLine("You are eligible to register for service.");
}
else
{
    Console.WriteLine("Unfortunately, You are not eligible to register for service!");
}

Console.WriteLine("End of program");