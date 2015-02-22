using System;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

class MinMaxAverageSumProduct
{
    static bool IsSequence(int number)
    {
        if (number>1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void MinNumberInSequence(params decimal[] sequence)
    {
        if (IsSequence(sequence.Length))
        {
            decimal minNumber = sequence[0];
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i]<minNumber)
                {
                    minNumber = sequence[i];
                }
            }
            Console.WriteLine("Min value = {0}", minNumber);
        }
        else
        {
            Console.WriteLine("Sequence must be at least 2 numbers!");
        }
    }
    static void MaxNumberInSequence(params decimal[] sequence)
    {
        if (IsSequence(sequence.Length))
        {
            decimal maxNumber = sequence[0];
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > maxNumber)
                {
                    maxNumber = sequence[i];
                }
            }
            Console.WriteLine("Max value = {0}", maxNumber);
        }
    }
    static void AverageOfSequence(params decimal[] sequence)
    {
        if (IsSequence(sequence.Length))
        {
            decimal sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            decimal average = sum / sequence.Length;
            Console.WriteLine("Average of sequence = {0}", average);
        }
    }
    static void SumOfSequence(params decimal[] sequence)
    {
        if (IsSequence(sequence.Length))
        {
            decimal sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine("Sum of sequence = {0}", sum);
        }
    }
    static void ProductOfSequence(params decimal[] sequence)
    {
        if (IsSequence(sequence.Length))
        {
            decimal product = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                product *= sequence[i];
            }
            Console.WriteLine("Product of sequence = {0}", product);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter length of sequence");
        int n = int.Parse(Console.ReadLine());
        decimal[] sequence = new decimal[n];
        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("Sequence[{0}]=",i);
            sequence[i] = decimal.Parse(Console.ReadLine());
        }
        MinNumberInSequence(sequence);
        MaxNumberInSequence(sequence);
        AverageOfSequence(sequence);
        SumOfSequence(sequence);
        ProductOfSequence(sequence);
    }
}
