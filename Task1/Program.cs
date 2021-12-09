using System;
using ClassLibrary1;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //verilmish 4 reqemli ededin reqemlerinin cemini tap
             Console.WriteLine("Task:Please find the Sum of digits of 4-digit number");
             int number1 = Calculator.Enter_4_DigitValue("Please enter 4-digit number:...");
            
            int sum = Calculator.SumDigitsOfNumber(number1);
           
           
            

        }
    }
}
