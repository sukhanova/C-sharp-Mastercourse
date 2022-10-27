
Console.Write("Type in your grade: ");
char grade;
grade = Convert.ToChar(Console.ReadLine().ToUpper());
string result;


switch (grade)
{
    case 'E':
        result = "Excellent";
        break;
    case 'V':
        result = "Very Good";
        break;
    case 'G':
        result = "Good";
        break;
    case 'A':
        result = "Average";
        break;
    case 'F':
        result = "Fail";
        break;
    default:
        result = "Invalid imnput";
        break;
}
Console.WriteLine($"Your grade {grade} is equal to {result}");

