using System;
//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

class CountNumberInArray
{
    static int NumberCounter(int number, int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==number)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int[] arrayOfInts = new int[] { 1, 3, 5, 7, 1, 4, 2, 8, 9, 3, 4, 7, 5, 9, 9, 1};
        int numberCounter = 0;
        numberCounter = NumberCounter(inputNumber, arrayOfInts);
        Console.WriteLine(numberCounter);
    }
}
