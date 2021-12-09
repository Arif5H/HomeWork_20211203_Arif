using System;
using ClassLibrary1;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.*/
            Console.WriteLine("verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at");
            int number1 = Calculator.Enter_6_DigitValue("Please enter 6-digit number: ");
            
            int remainder;
                remainder = number1 / 100000;
                number1 = number1*10 + remainder;
                
            Console.WriteLine($"Result {number1}");

            
            
               
            


        }
    }
}
