using System;
using System.Text;
using System.Numerics;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

class SumOfDigitArrays
{
    static BigInteger ArrayToNumber(int[] array)
    {
        string numberToString = "";
        for (int i = array.Length - 1; i >= 0; i--) //starts from array.Length - 1 because the last digit is kept in [0]
        {
            numberToString += array[i];
        }
        BigInteger number = BigInteger.Parse(numberToString);
        return number;
    }
    static void Main()
    {
        int[] firstArrayOfDigits = new int[] { 3, 2, 5, 7, 4, 2, 8, 3, 9, 3, 5, 7, 9, 6, 4, 2, 4, 9 };
        int[] secondArrayOfDigits = new int[] { 4, 2, 2, 3, 4, 2, 5, 3, 9, 3, 5, 5, 4, 6, 1, 2, 4, 9, 8, 7, 5, 4, 2, 8 };
        Console.WriteLine(ArrayToNumber(firstArrayOfDigits)+ArrayToNumber(secondArrayOfDigits));
    }
}
