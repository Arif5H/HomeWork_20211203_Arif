using System;
using ClassLibrary1;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 dene 5 reqemli eded daxil et. 
             I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
             Neticenin axirina I ededin en axiinci reqemini artir.*/
            int number1 = Calculator.Enter_5_DigitValue("Please Enter 1st 5-digit number... ");
            int number2 = Calculator.Enter_5_DigitValue("Please Enter 2nd 5-digit number... ");
            int sumofdigits = Calculator.SumDigitsOfNumber(number1);
           
            int product = Calculator.ProductDigitsOfNumber(number2);
            Console.WriteLine($"Product of digits of 2nd number is {product}");
            number1 %= 10;
            product = product * 10 + number1;
            Console.WriteLine($"The Result is {product}");

        }
    }
}
