using System;
using ClassLibrary1;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 5 reqemli eded var.
            Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/
            int number1 = Calculator.Enter_5_DigitValue("Please Enter 1st 5-digit number... ");
            int number2 = Calculator.Enter_5_DigitValue("Please Enter 2nd 5-digit number... ");
            int number3 = Calculator.Enter_5_DigitValue("Please Enter 3rd 5-digit number... ");
            Console.WriteLine(" Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet");
            number1 = Calculator.NewNumberFrom5DigitNumber(number1);
            number2 = Calculator.NewNumberFrom5DigitNumber(number2);
            number3 = Calculator.NewNumberFrom5DigitNumber(number3);
            Console.WriteLine($"{number1}, {number2}, {number3} ");
            number1 = number1 + number2 + number3;
            Console.WriteLine("Sum of Numbers is {0}", number1);
            Console.WriteLine("Yekunda alian cavabin 50%-ni hemin ededin uzerine gel");
            double result = number1 * (1 + 0.5);
            Console.WriteLine("The rsult is {0}", result);
        }
    }
}
