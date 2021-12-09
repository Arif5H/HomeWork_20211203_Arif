using System;
using ClassLibrary1;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
               6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
                Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
                Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
                Neticenin 60 % tap.Cavabin axirina 60 artir.
                Neticeden 18 % cix.*/
            int number1 = Calculator.Enter_6_DigitValue("Please enter 1st 6-digit number... ");
            int number2 = Calculator.Enter_6_DigitValue("Please enter 2nd 6-digit number... ");
            int number3 = Calculator.Enter_6_DigitValue("Please enter 3rd 6-digit number... ");
            int number4 = Calculator.Enter_7_DigitValue("Please enter 7-digit number... ");
            Console.WriteLine("6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.");
            number1 = Calculator.NewNumberFrom6DigitNumber(number1);
            Console.WriteLine("For 1st 6-digit value new value is {0}", number1);
            number2 = Calculator.NewNumberFrom6DigitNumber(number2);
            Console.WriteLine("For 2nd 6-digit value new value is {0}", number2);
            number3 = Calculator.NewNumberFrom6DigitNumber(number3);
            Console.WriteLine("For 3rd 6-digit value new value is {0}", number3);
            number1 = number1 + number2 + number3;
            Console.WriteLine("Their Total is {0}", number1);
            Console.WriteLine(" Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel");
            int number5 = Calculator.NewNumberFromLast4Digits(number4);
            number1 += number5;
            Console.WriteLine("The result of sum is {0}", number1);
            Console.WriteLine(" Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.");
            number4 = Calculator.NewNumberFrom1st3DigitsOF7DigitNumber(number4);
            number1 -= number4;
            Console.WriteLine("The result {0}", number1);
            Console.WriteLine("Neticenin 60 % tap.Cavabin axirina 60 artir.");
            double result =number1*  0.6;
            Console.WriteLine("60% of Result {0}", result);
            result = result * 100 + 60;
            Console.WriteLine("Typed 60 in the end ofnumbe {0}", result);
            Console.WriteLine("Neticeden 18 % cix");
            result =result*(1 - 0.18);
            Console.WriteLine("FINAL RESULT {0}",result);            




        }
    }
}
