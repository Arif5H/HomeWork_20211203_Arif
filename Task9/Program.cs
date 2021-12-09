using System;
using ClassLibrary1;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First_Version
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
            Console.WriteLine($"Result {array[8]}{array[6]}{array[4]}{array[2]}{array[0]}");
            Console.ReadKey();
            //OR
            
            int anynumber = ((((array[8]*10)+array[6])*10+array[4])*10 +array[2])*10+array[0];
            Console.WriteLine($"Calculated Result {anynumber}");

            #endregion

            #region Second_Version

            Console.WriteLine("9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439");
            int number2 = Calculator.Enter_9_DigitValue("Please enter 9 digit value");
            int ostatok;
            int novoezna4enie = 0;
            int mnojitel=1;
            i = 1;
            while (number2 > 0)
            {
                if (i % 2 != 0)
                {

                    ostatok = number2 % 10;
                    novoezna4enie = novoezna4enie  + ostatok*mnojitel;
                    mnojitel *= 10;
                }

                    i++;
                number2 /= 10;
            }
            Console.WriteLine($"The result {novoezna4enie}");
            #endregion

        }
    }
}
