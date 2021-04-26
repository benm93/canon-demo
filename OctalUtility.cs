using System;

namespace CanonDemo
{
    class OctalUtility
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OctalToUInt("20"));
        }

        static int OctalToUInt(String octal)
        {

            //take as input an ascii string containing an octal representation of an unsigned integer and convert that string to an integer value

            //start at the right. take current, multiply it by multiplier (which is 1 iniitally) and add to total. then multiplier *= 8.

            //get last char
            int multiplier = 1;
            int total = 0;
            for (int i = octal.Length-1; i > -1; i--)
            {
                char c = octal[i];
                int num = 0;
                if ('0' == c)
                {
                    num = 0;
                } else if ('1' == c)
                {
                    num = 1;
                }
                else if ('2' == c)
                {
                    num = 2;
                }
                else if ('3' == c)
                {
                    num = 3;
                }
                else if ('4' == c)
                {
                    num = 4;
                }
                else if ('5' == c)
                {
                    num = 5;
                }
                else if ('6' == c)
                {
                    num = 6;
                }
                else if ('7' == c)
                {
                    num = 7;
                }

                int sum = multiplier * num;
                total += sum;
                multiplier *= 8;
            }



            return total;
        }

    }
}
