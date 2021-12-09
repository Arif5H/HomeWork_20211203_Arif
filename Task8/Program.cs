using System;
using ClassLibrary1;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  */
            Console.WriteLine("erilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap");
            int number1 = Calculator.Enter_Any_DigitValue("Please enter Any number:...");
            int result;
            result = number1 % 10;
            Console.WriteLine("Last number is {0}", result);
            number1 %= 1000;
            number1 /= 100;
            Console.WriteLine("3rd digit from end is {0}", number1);
            number1 += result;
            Console.WriteLine($"The sum of the required digits is {number1 }");

        }
    }
}
