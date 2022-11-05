/*
 Write a program to display the cube of the number
up to given an integer.
 */


//Console.Write("Type in the number: ");
//int userInput = Convert.ToInt32(Console.ReadLine());
//int i;
//for (i = 0; i <= userInput; i++)
//{
//    Console.WriteLine($"Number is {userInput} and cube of {i} is {i*i*i}");
//}


/*
 Write a program to display n terms of natural number and their sum.
 */

//Console.Write("\nType in number: ");
//int numberInput = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"The first {numberInput} natural number are:\n {numberInput}");
//int total = 0;
//for (int j = 1; j <= numberInput; j++)
//{
//    Console.WriteLine($"{j}");
//    total += j;
//}

//Console.WriteLine($"Total is {total}");


/*
 Sort array ascending
Given an array of integers, write a method that returns sorted array in asc order.
Expected input and output
SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9]
 */

// USING Array.Sort()

//int[] arrayToSort = new int[] { 9, 5, 7, 2, 1, 8 };
//Array.Sort(arrayToSort);

//// acs sort
//Console.WriteLine("\nSorted array in ascending order: ");
//foreach (var arrayItem in arrayToSort)
//{
//    Console.WriteLine(arrayItem);
//}


//// disc sort
//Console.WriteLine("\n Sorted array in descending order: ");
//Array.Reverse(arrayToSort);
//foreach (var item in arrayToSort)
//{
//    Console.WriteLine(item);
//}


// USING SINGLE for loop and new array declaration

int[] arrayToSort = new int[] { 9, 5, 7, 2, 1, 8 };

/*
 Logic:
input array:    [9, 5, 7, 2, 1, 8]
 index of elem  0   1  2  3  4  5
 */

string[] stringArray = Array.ConvertAll(arrayToSort, x => x.ToString());
Console.WriteLine(String.Join(',', stringArray));

int length = arrayToSort.Length;

for (int i = 0; i < length -1; i++)
{
    if (arrayToSort[i] > arrayToSort[i+1])
    {
        int temp = arrayToSort[i];
        arrayToSort[i] = arrayToSort[i + 1];
        arrayToSort[i + 1] = temp;

        // Reset the index value to -1
        i = -1;
    }
}
Console.WriteLine($"\n Sorted array: ");
foreach (var item in arrayToSort)
{
    Console.WriteLine(item);
}