using System;
//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

class LastDigitToWord
{
    static string LastDigitOfInt(int number)
    {
        string lastDigit = "";
        number %= 10;
        switch (number)
        {
            case 1:
                lastDigit = "one";
                break;
            case 2:
                lastDigit = "two";
                break;
            case 3:
                lastDigit = "tree";
                break;
            case 4:
                lastDigit = "four";
                break;
            case 5:
                lastDigit = "five";
                break;
            case 6:
                lastDigit = "six";
                break;
            case 7:
                lastDigit = "seven";
                break;
            case 8:
                lastDigit = "eight";
                break;
            case 9:
                lastDigit = "nine";
                break;
        }
        return lastDigit;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string lastDigit = LastDigitOfInt(n);
        Console.WriteLine(lastDigit);
    }
}
