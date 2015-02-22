using System;
using System.Numerics;
//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

class Factoriel1To100
{
    static BigInteger Factoriel(int number)
    {
        BigInteger factoriel = 1;
        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }
        return factoriel;
    }
    private static void PrintFactoriel1To100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(Factoriel(i));
        }
    }
    static void Main()
    {
        PrintFactoriel1To100();
    }
}
