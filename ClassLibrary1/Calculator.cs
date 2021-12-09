using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public static int Enter_Any_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                return anynumber;
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
        }
        public static int Enter_3_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 100 || anynumber > 999)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 3-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
                Console.WriteLine("Good! Entered Number is 3-digit number");
                return anynumber;
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
        }
        public static int Enter_4_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 1000 || anynumber > 9999)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 4-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
            Console.WriteLine("Good! Entered Number is 4-digit number");
            return anynumber;
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
        }
        public static int Enter_5_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 10000 || anynumber > 99999)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 5-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
                Console.WriteLine("Good! Entered Number is 5-digit number");
                return anynumber;
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
        }
        public static int Enter_6_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 100000 || anynumber >= 1000000)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 6-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
            Console.WriteLine("Good! Entered Number is 6-digit number");
            return anynumber;
        }
        public static int Enter_7_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 1000000 || anynumber >= 10000000)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 7-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
            Console.WriteLine("Good! Entered Number is 7-digit number");
            return anynumber;
        }
        public static int Enter_8_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 10000000 || anynumber >= 100000000)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 8-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
            Console.WriteLine("Good! Entered Number is 8-digit number");
            return anynumber;
        }
        public static int Enter_9_DigitValue(string caption)
        {
            int anynumber;
        ReadAgain:
            try
            {
                Console.WriteLine(caption);
                anynumber = Convert.ToInt32(Console.ReadLine());
                if (anynumber < 100000000 || anynumber >= 1000000000)
                {
                    Console.WriteLine("The Entered Number {0} is NOT 9-digit number.TRY AGAIN", anynumber);
                    goto ReadAgain;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You Should enter only integer values.TRY AGAIN");
                goto ReadAgain;
            }
            Console.WriteLine("Good! Entered Number is 9-digit number");
            return anynumber;
        }
        public static int SumDigitsOfNumber( int anynumber)
        {
           int sum = 0;
            int digit;
            while (anynumber > 0) 
            {
                digit = anynumber % 10;
                sum += digit;
                anynumber /= 10;
            } 
            Console.WriteLine($"Sum of digits of Number is {sum}");
            return sum;
        }
        public static int ProductDigitsOfNumber(int anynumber)
        {
            int product = 1;
            int digit;
            while (anynumber > 0)
            {
                digit = anynumber % 10;
                product *= digit;
                anynumber /= 10;
            }
            
            return product;
        }
        public static int ReverseDigits(int anynumber)
        { int remainder;
            int newvalur=0;
            while (anynumber> 0)
            {
                remainder = anynumber % 10;
                newvalur = newvalur * 10 + remainder;
                anynumber /= 10;
            }
            return newvalur;
        }
        public static int NewNumberFrom5DigitNumber(int anynumber)
        {
            int remainder;
            int[] array = new int[8];
            int i = 0;
            while (anynumber > 0)
            {
                remainder = anynumber % 10;
                Console.WriteLine(remainder);
                anynumber /= 10;

                if (i < 5)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            anynumber = (array[4] * 10) + array[0];
            return anynumber;
        }
        public static int NewNumberFrom6DigitNumber(int anynumber)
        {
            int remainder;
            int[] array = new int[8];
            int i = 0;
            while (anynumber > 0)
            {
                remainder = anynumber % 10;
                Console.WriteLine(remainder);
                anynumber /= 10;

                if (i < 6)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            anynumber = ((array[5] * 10) + array[4])*10+array[3];
            return anynumber;
        }

        public static int NewNumberFromOddPlaceDigits(int anynumber)
        {
            int ostatok;
            int novoezna4enie = 0;
            int mnojitel = 1;
            int i = 1;
            while (anynumber > 0)
            {
                if (i % 2 != 0)
                {

                    ostatok = anynumber % 10;
                    novoezna4enie = novoezna4enie + ostatok * mnojitel;
                    mnojitel *= 10;
                }

                i++;
                anynumber /= 10;
            }
            Console.WriteLine($"The result {novoezna4enie}");
            return novoezna4enie;
        }

        public static int NewNumberFromLast4Digits(int anynumber)
        {
            int remainder;
            int[] array = new int[8];
            int i = 0;
            while (anynumber > 0)
            {
                remainder = anynumber % 10;
                Console.WriteLine(remainder);
                anynumber /= 10;

                if (i < 7)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            anynumber = (((array[3] * 10) + array[2]) * 10 + array[1])*10+array[0];
            return anynumber;
        }
        public static int NewNumberFrom1st3DigitsOF7DigitNumber(int anynumber)
        {
            int remainder;
            int[] array = new int[8];
            int i = 0;
            while (anynumber > 0)
            {
                remainder = anynumber % 10;
                Console.WriteLine(remainder);
                anynumber /= 10;

                if (i < 7)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            anynumber = array[6] *array[5]*array[4];
            return anynumber;
        }
        public static int NewNumberFromLast5DigitsOf7DigitNumber(int anynumber)
        {
            int remainder;
            int[] array = new int[8];
            int i = 0;
            while (anynumber > 0)
            {
                remainder = anynumber % 10;
                Console.WriteLine(remainder);
                anynumber /= 10;

                if (i < 7)
                {
                    array[i] = remainder;
                    i++;
                }
            }

            anynumber = ((((array[4]*10+array[3]) * 10) + array[2]) * 10 + array[1]) * 10 + array[0];
            return anynumber;
        }
       


    }
}
