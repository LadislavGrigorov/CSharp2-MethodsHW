using System;
/*Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
Extend the program to support also subtraction and multiplication of polynomials.
*/
class Polynomials
{
    static void PrintSuperScript(int number)
    {
        string numberToString = number.ToString();
        string superscriptIndex = "";
        for (int i = 0; i < numberToString.Length; i++)
        {
            switch (numberToString[i])
            {
                case '0':
                    superscriptIndex += "\u2070";                    //superscript symbols in unicode
                    break;
                case '1':
                    superscriptIndex += "\u00b9";
                    break;
                case '2':
                    superscriptIndex += "\u00B2";
                    break;
                case '3':
                    superscriptIndex += "\u00B3";
                    break;
                case '4':
                    superscriptIndex += "\u2074";
                    break;
                case '5':
                    superscriptIndex += "\u2075";
                    break;
                case '6':
                    superscriptIndex += "\u2076";
                    break;
                case '7':
                    superscriptIndex += "\u2077";
                    break;
                case '8':
                    superscriptIndex += "\u2078";
                    break;
                case '9':
                    superscriptIndex += "\u2079";
                    break;
            }
        }
        Console.Write(superscriptIndex);
    }
    static void SumOfPolynomials(int[] firstPolynomial, int[] secondPolynomial, int[] result)
    {
        bool firstIsBigger = true;
        if (firstPolynomial.Length>=secondPolynomial.Length)
        {
            firstIsBigger = true;
        }
        else
        {
            firstIsBigger = false;
        }
        int minLength = Math.Min(firstPolynomial.Length, secondPolynomial.Length);
        for (int i = 0; i < minLength; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }
        if (firstIsBigger)
        {
            for (int i = minLength; i < result.Length; i++)
            {
                result[i] = firstPolynomial[i];
            }
        }
        else
        {
            for (int i = minLength; i < result.Length; i++)
            {
                result[i] = secondPolynomial[i];
            }
        }
        
    }
    static void SubstractionOfPolynomials(int[] firstPolynomial, int[] secondPolynomial, int[] result)
    {
        bool firstIsBigger = true;
        if (firstPolynomial.Length >= secondPolynomial.Length)
        {
            firstIsBigger = true;
        }
        else
        {
            firstIsBigger = false;
        }
        int minLength = Math.Min(firstPolynomial.Length, secondPolynomial.Length);
        for (int i = 0; i < minLength; i++)
        {
            result[i] = firstPolynomial[i] - secondPolynomial[i];
        }
        if (firstIsBigger)
        {
            for (int i = minLength; i < result.Length; i++)
            {
                result[i] = firstPolynomial[i];
            }
        }
        else
        {
            for (int i = minLength; i < result.Length; i++)
            {
                result[i] -= secondPolynomial[i];
            }
        }

    }
    static void MultiplyOfPolynomials(int[] firstPolynomial, int[] secondPolynomial, ref int[] result)
    {
        result = new int[firstPolynomial.Length + secondPolynomial.Length];
        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            for (int j = 0; j < firstPolynomial.Length; j++)
            {
                result[i + j] += secondPolynomial[i] * firstPolynomial[j];
            }
        }
    }
    static void PrintPolynomial(int[] array)                    //print the polynomial
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            if (array[i] != 0)
            {
                if (i != 0)
                {
                    if (i != array.Length - 1)
                    {
                        Console.Write("{0:+#;-#}x", array[i]);
                        PrintSuperScript(i);                  //prints the power of X with superscript

                    }
                    else
                    {
                        Console.Write("{0:0;-#}x", array[i]);
                        PrintSuperScript(i);
                    }
                }
                else
                {
                    Console.Write("{0:+#;-#}x", array[i]);
                    PrintSuperScript(i);
                }
            }
        }
        if (array[0] != 0)
        {
            Console.Write("{0:+#;-#}", array[0]);
        }
        Console.WriteLine();
    }
    private static int[] UserChoice(int[] firstPolynomial, int[] secondPolynomial, int[] result)   //choose operation
    {
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                SumOfPolynomials(firstPolynomial, secondPolynomial, result);
                break;
            case "2":
                SubstractionOfPolynomials(firstPolynomial, secondPolynomial, result);
                break;
            case "3":
                MultiplyOfPolynomials(firstPolynomial, secondPolynomial, ref result);
                break;
            default:
                Console.WriteLine("Enter 1, 2 or 3!");
                break;
        }
        return result;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] firstPolynomial = { 5, 0, 1 };  //first polynomial
        PrintPolynomial(firstPolynomial);
        int[] secondPolynomial = { 3, 0, 4, 2 };   //second polynomial
        PrintPolynomial(secondPolynomial);
        int maxLength = Math.Max(firstPolynomial.Length, secondPolynomial.Length); //find the bigger polynomial length
        int[] result = new int[maxLength];                                         //create result array length for sum and substract
        Console.WriteLine("Enter \"1\" for sum, \"2\" for substract or \"3\" for multiply");
        result = UserChoice(firstPolynomial, secondPolynomial, result);            //choose operation
        PrintPolynomial(result);
    }
}
