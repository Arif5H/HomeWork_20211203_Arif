using System;
using ClassLibrary1;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
               3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
                  Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
                   Cavabdan 7 reqemli ededin son 5 reqemini cix. 
                    Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
                   Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
                    Cavabin axirina 11 artir. 
                    Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
                    Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/

            Console.WriteLine("5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.");
            int number1 = Calculator.Enter_3_DigitValue("Please Enter 1st 3-digit value");
            int number2 = Calculator.Enter_3_DigitValue("Please Enter 2nd 3-digit value");
            int number3 = Calculator.Enter_6_DigitValue("Please Enter 1st 6-digit value");
            int number4 = Calculator.Enter_6_DigitValue("Please Enter 2nd 6-digit value");
            int number5 = Calculator.Enter_7_DigitValue("Please Enter 7-digit value");
            Console.WriteLine("3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap");
            int number =number1+ number2;
            Console.WriteLine(number);
            number %= 100;
            Console.WriteLine(number);
            number *= number;
            Console.WriteLine("Result {0}", number);
            Console.WriteLine("Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.");
            number = number + (number1 * 1000 + number2);
            Console.WriteLine($"Result = {number}");
            Console.WriteLine("Cavabdan 7 reqemli ededin son 5 reqemini cix");
            int number6 = Calculator.NewNumberFromLast5DigitsOf7DigitNumber(number5);
            number -= number6;
            Console.WriteLine("Result {0}", number);
            Console.WriteLine("Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel");
            number = number + (number3 + number4) % 1000;
            Console.WriteLine("The result {0}", number);
            Console.WriteLine("Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel");
            number1 = Calculator.SumDigitsOfNumber(number5);
            number1 = Calculator.ReverseDigits(number1);
            Console.WriteLine("Reverse value {0}", number1);
            number += number1;
            Console.WriteLine("Result of sum {0}", number);
            Console.WriteLine("Cavabin axirina 11 artir");
            number = number * 100 + 11;
            Console.WriteLine("New VALUE {0}", number);
            Console.WriteLine("Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.");

            number5 = Calculator.NewNumberFromOddPlaceDigits(number5);
            Console.WriteLine($" 7 reqemli ededin tek yerde dayan reqemleri {number5}");
            number -= number5;
            Console.WriteLine($"After Deduction {number}");
            Console.WriteLine("Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.");
            number2 = number % 10;
            number /= 10;
            number = number * 1000 + 88 * 10 + number2;
            Console.WriteLine("Final Result {0}", number);




        }
    }
}
