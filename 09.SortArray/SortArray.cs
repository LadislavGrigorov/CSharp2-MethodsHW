using System;
//Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

class SortArray
{
    static int ScanPortionOfArray(int startIndex, int endIndex, int[] array)
    {
        int maxValue = array[startIndex];
        int maxValuePosition = startIndex;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (maxValue <= array[i])
            {
                maxValue = array[i];
                maxValuePosition = i;
            }
        }
        return maxValuePosition;
    }
    static void SortDescending(ref int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int tempValue = array[i];
            array[i] = array[ScanPortionOfArray(i, array.Length, array)];
            array[ScanPortionOfArray(i, array.Length, array)] = tempValue;
        }
    }
    static void SortAscending(ref int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int tempValue = array[i];
            array[i] = array[ScanPortionOfArray(0, i, array)];
            array[ScanPortionOfArray(0, i, array)] = tempValue;
        }
    }
    private static void PrintArray(int[] arrayOfInts)
    {
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            Console.Write(arrayOfInts[i] + " ");
        }
    }

    private static int[] UserChoice(int[] arrayOfInts, int userChoice)
    {
        switch (userChoice)
        {
            case 1:
                SortAscending(ref arrayOfInts);
                break;
            case 2:
                SortDescending(ref arrayOfInts);
                break;
        }
        return arrayOfInts;
    }

    static void Main()
    {
        int[] arrayOfInts = new int[] { 1, 4, 3, 2, 7, 4, 9, 2, 4, 0, 7, -3, 15, 2, 19, 8 };
        Console.Write("Enter 1 for ascending sort or 2 for descending sort: ");
        int userChoice = int.Parse(Console.ReadLine());
        arrayOfInts = UserChoice(arrayOfInts, userChoice);
        PrintArray(arrayOfInts);
    }
}
