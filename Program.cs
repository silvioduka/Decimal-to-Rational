/*
Decimal to Rational from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-28 

Write a program that transforms a decimal number into a fraction in lowest terms. 
For example: 
0.75 => 3 / 4 
0.9054054 => 4527027 / 5000000 
0.518518 => 259259 / 500000 

Note, that while rational numbers can be converted to decimal representation, some of them need an infinite number of digits to be represented exactly in decimal form. Namely, repeating decimals such as 1/3 = 0.333... 
Because of this, the following fractions cannot be obtained (reliably) unless the language has some way of representing repeating decimals. 
For example: 
67 / 74 = 0.9(054) = 0.9054054... 
14 / 27 = 0.(518) = 0.518518... 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToRationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 0.9054054; // Insert a decimal number to convert it into a fraction

            int a = 0;
            int b = 0;

            int i = 1;

            while (true)
            {
                if ((double)(input * (double)i) == (int)(input * i)) break;

                i *= 10;
            }

            a = (int)(input * i);
            b = i;

            int hcf = HCF(a, b);

            a = a / hcf;
            b = b / hcf;

            Console.WriteLine($"{input} => {a}/{b}");
        }

        static int HCF(int number1, int number2)
        {
            int number = (number1 < number2) ? number1 : number2;

            for (int i = number; i > 0; i--)
            {
                int t = number1 % i + number2 % i;

                if (t == 0) return i;
            }

            return 0;
        }
    }
}
