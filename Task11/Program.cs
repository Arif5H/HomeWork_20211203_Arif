using System;
using ClassLibrary1;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8 reqemli ededin reqemlerini iki -iki qruplashdir. 
             Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
             Sonra cavabin ozunden onun 18% ni cix.*/
            int number1 = Calculator.Enter_8_DigitValue("Please enter 8-digit number... ");
            int remainder = 0;
            int[] array = new int[8];
            int i = 0;
            while (number1 > 0)
            {
                remainder = number1 % 10;
                Console.WriteLine(remainder);
                number1 /= 10;

                if (i < 8)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            int number2 = (array[7] * 10) + array[6];
            int number3 = (array[5] * 10) + array[4];
            int number4 = (array[3] * 10) + array[2];
            int number5 = (array[1] * 10) + array[0];
            Console.WriteLine($"Pairs {number2}, {number3}, {number4}, {number5}");
            number2 = number2 + number3 + number4 + number5;
            Console.WriteLine("Sum of pairs {0}", number2);
            number2 = number2 * 100 + 99;
            Console.WriteLine("TYPED 99 TO THE END {0}", number2);
            double result= number2*(1.0- 0.18);
            Console.WriteLine("DEDUCTed 18% of the result from the result to get new result {0}",result);

            
        }
    }
}
