using System;
//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class BiggerThanItsNeighbors
{
    public static bool IsBiggerThanItsNeghbors(int index, int[] array)
    {
        bool isBigger = false;
        if (index > 0 && index < array.Length - 1 && (array[index] > array[index - 1]) && (array[index] > array[index + 1]))
        {
            isBigger = true;
        }
        else if (index == 0 && (array[index] > array[index + 1]))
        {
            isBigger = true;
        }
        else if (index == array.Length - 2 && (array[index] > array[index - 1]))
        {
            isBigger = true;
        }
        return isBigger;
    }
    static void Main()
    {
        int elementPosition = int.Parse(Console.ReadLine());
        int[] arrayOfInts = new int[] { 1, 3, 5, 7, 1, 4, 2, 8, 9, 3, 4, 7, 5, 9, 9, 1 };
        Console.Write("Element [{0}] is bigger than its neighbors? ", elementPosition);
        Console.WriteLine(IsBiggerThanItsNeghbors(elementPosition, arrayOfInts));
    }
}
