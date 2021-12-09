using System;
using ClassLibrary1;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir");
            int number1 = Calculator.Enter_4_DigitValue("Please enter 4-digit number:...");
            int remainder =0;
            
            
            while (number1 > 0)
            {
                remainder = remainder*10 + number1 % 10;
                number1 = number1 / 10;               
            }
            Console.WriteLine($" New value{remainder}");
            remainder *= 80000;
            remainder = remainder * 10 + 8;
            Console.WriteLine($"Final Result is {remainder}");
        }
    }
}
