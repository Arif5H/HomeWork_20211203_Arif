using System;
using ClassLibrary1;

namespace Task02
{
    class Program
    {   
        static void Main(string[] args)
        {   /*verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3*/
            int number1= Calculator.Enter_6_DigitValue("Please enter 6-digit number: ");
            int sum = 0;
            number1 /= 1000;
            int remainder;

            while (number1 > 0)
            {
                remainder = number1 % 10;
                sum += remainder;
                number1 /= 10;
            }
            Console.WriteLine($"Sum of 1st 3 digits of Number is {sum}");
        }
    }
}
