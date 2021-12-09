using System;
using ClassLibrary1;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9 reqemli ededdi tek yerde dayananlardan bir eded duzlet, 
            sonra cut yerde dayanlarinda bir eded duzlet,
            sonra onlari topla*/
            Console.WriteLine("9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439");
            int number1 = Calculator.Enter_9_DigitValue("Please enter 9 digit value");
            int remainder;
            int[] array = new int[9];
            int i = 0;
            while (number1 > 0)
            {
                remainder = number1 % 10;
                Console.WriteLine($"Digits {remainder}");
                number1 /= 10;
                if (i < 9)
                {
                    array[i] = remainder;
                    i++;
                }

            }

            int oddnumber = ((((array[8] * 10) + array[6]) * 10 + array[4]) * 10 + array[2]) * 10 + array[0];
            Console.WriteLine($"Calculated Result of digits in odd place {oddnumber}");
            int evennumber = (((array[7]) * 10 + array[5]) * 10 + array[3]) * 10 + array[1];
            Console.WriteLine($"Calculated Result of digits in even place {evennumber}");
            evennumber += oddnumber;
            Console.WriteLine("Sum of last 2 numbers {0}", evennumber);
        }
    }
}
