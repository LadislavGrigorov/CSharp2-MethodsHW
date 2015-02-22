using System;
using System.Text;
//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseNumbersDigits
{
    static string ReverseNumberDigits(decimal number)
    {
        string numberToString = number.ToString();
        StringBuilder reversedNumber = new StringBuilder();
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            reversedNumber.Append(numberToString[i]);
        }
        return reversedNumber.ToString();
    }
    static void Main()
    {
        decimal inputNumber = decimal.Parse(Console.ReadLine());
        string reversedNumber = ReverseNumberDigits(inputNumber);
        Console.WriteLine(reversedNumber);
    }
}
