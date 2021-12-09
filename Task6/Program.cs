using System;
using ClassLibrary1;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et*/
            Console.WriteLine("verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et ");
            int number1 = Calculator.Enter_8_DigitValue("Please enter 8-digit number: ");
            int remainder;
            number1 = number1 / 10;
            number1 = number1 % 1000000 ;


            Console.WriteLine($"Result {number1}");
        }
    }
}
