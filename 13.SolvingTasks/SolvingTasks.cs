using System;
using System.Text;
/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/
class SolvingTasks
{
    static bool IsNotEmptySequence(int sequenceLength)
    {
        bool isNotEmpty = false;
        if (sequenceLength > 1)
        {
            isNotEmpty = true;
        }
        return isNotEmpty;
    }
    static bool NumberIsPositive(decimal number)
    {
        if (number > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void AverageOfSequence(int sequenceLength)
    {
        if (IsNotEmptySequence(sequenceLength))
        {
            decimal[] sequence = new decimal[sequenceLength];
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("Sequence[{0}]=", i);
                sequence[i] = decimal.Parse(Console.ReadLine());
            }

            decimal sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            decimal averageOfSequence = sum / sequence.Length;
            Console.WriteLine("Average of the sequence is {0}", averageOfSequence);
        }
        else
        {
            Console.WriteLine("Sequence must be at least 2 numbers");
        }
    }
    static bool IsNotZero(decimal number)
    {
        if (number != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void SolveLinearEquation(decimal a, decimal b)
    {
        decimal result = 0;
        if (IsNotZero(a))
        {
            result = -b / a;
            Console.WriteLine("x={0}", result);
        }
        else
        {
            Console.WriteLine("The equation is not linear. \"a\" should not be equal to 0");
        }
    }
    static string ReverseNumberDigits(decimal number)
    {
        if (NumberIsPositive(number))
        {
            string numberToString = number.ToString();
            StringBuilder reversedNumber = new StringBuilder();
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                reversedNumber.Append(numberToString[i]);
            }
            return reversedNumber.ToString();
        }
        else
        {
            return "The number is not positive!";
        }

    }
    private static void PrintMenu()
    {
        Console.WriteLine("1. Reverse numbers digits");
        Console.WriteLine("2. Average of sequence");
        Console.WriteLine("3. Solve a*x+b=0");
        Console.WriteLine("Enter \"1\",\"2\" or \"3\"!");
    }
    private static void UserChoice()
    {
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("Enter a number");
                decimal number = decimal.Parse(Console.ReadLine());
                Console.WriteLine(ReverseNumberDigits(number));
                break;
            case "2":
                Console.WriteLine("Enter length of sequence:");
                int sequenceLength = int.Parse(Console.ReadLine());
                AverageOfSequence(sequenceLength);
                break;
            case "3":
                Console.WriteLine("Enter \"a\" and \"b\"");
                Console.Write("a=");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("b=");
                decimal b = decimal.Parse(Console.ReadLine());
                SolveLinearEquation(a, b);
                break;
            default:
                Console.WriteLine("Enter \"1\",\"2\" or \"3\"!");
                break;
        }
    }
    static void Main()
    {
        PrintMenu();
        UserChoice();
    }
}
