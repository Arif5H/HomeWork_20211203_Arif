using System;
using ClassLibrary1;

namespace Task03
{
    class Program
    {   
        static void Main(string[] args)
        {
            /*verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi*/

            int number1 = Calculator.Enter_9_DigitValue("Please enter 9-digit number: ");
            int sum = 0;
            number1 /= 1000;
            int remainder;
            Console.WriteLine($"1st 6-digits {number1}");
            while (number1 > 0)
            {
                remainder = number1 % 10;
                Console.WriteLine(remainder);
                sum += remainder;
                number1 = number1 / 10;
            }
            Console.WriteLine($"Sum of 3 numbers in the middle {sum}" );

        }
    }
}
