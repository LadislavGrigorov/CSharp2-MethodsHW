using System;
//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstBiggerThanItsNeighbors
{
    static int IndexFinder(int[] array)
    {
        int index = -1;       //if noone of the numbers is bigger than its neighbors index will be -1
        for (int i = 0; i < array.Length; i++)
        {
            bool isBigger = IsBiggerThanItsNeghbors(i, array);   //checking if the number on "i" position is bigger than its neigbors
            if (isBigger==true)
            {
                index = i;                            //when true record the value of "i" in index
                return index;
            }
        }
        return index;                                //the method should always return a value so if noone of the numbers is bigger than the neigbors
    }                                                //it will return -1.
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
        int[] arrayOfInts = new int[] { 1, 3, 5, 7, 1, 4, 2, 8, 9, 3, 4, 7, 5, 9, 9, 1 };
        int index = IndexFinder(arrayOfInts);
        Console.WriteLine(index);
    }
}
