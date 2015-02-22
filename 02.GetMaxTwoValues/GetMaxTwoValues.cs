using System;
//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMaxTwoValues
{
    static int GetMax(int number1, int number2)
    {
        int bigger = 0;
        if (number1>number2)
        {
            return bigger = number1;
        }
        else
        {
            return bigger = number2;
        }
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = 0;
        biggestNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}
