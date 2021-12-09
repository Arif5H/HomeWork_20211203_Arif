using System;
using ClassLibrary1;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati*/
            int number1 = Calculator.Enter_5_DigitValue("Please enter 5-digit number: ");
            int sum = 0;
            int remainder;
            remainder = number1 % 10;
            Console.WriteLine($"Last digit {remainder}");
            number1 = number1 / 10000;
            Console.WriteLine($"Last digit {number1}");
            sum = remainder + number1;
            Console.WriteLine($"Sum of 1st and Last digits {number1} + {remainder} = {sum}");
            sum *= sum;
            Console.WriteLine($"Square of sum {sum}");
            
        }
    }
}
