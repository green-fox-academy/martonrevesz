using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
			// please cube of e's value
			e = (int)Math.Pow(e, 3);
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool isBigger = f1 > f2;
            Console.WriteLine("f1 bigger than f2: " + isBigger);
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            isBigger = 2 * g2 > g1;
            Console.WriteLine("double of g2 bigger than g1: " + isBigger);


            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)
            bool isdivisor;
            long remainder = h % 11;
            if (remainder == 0)
            {
                isdivisor = true;
            } else
            {
                isdivisor = false;
            }
            Console.WriteLine("11 is a divisor of h: " + isdivisor);


            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            isBigger = ((int)Math.Pow(i2, 2) < i1) && (i1 < (int)Math.Pow(i2, 3));

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            bool jDividable;
            if (j % 3 == 0 || j % 5 == 0)
            {
                jDividable = true;
            } 
            else
            {
                jDividable = false;
            }
            Console.WriteLine("j is dividable by 3 or 5: " + jDividable);

            string k = "Apple";
            //fill the k variable with its cotnent 4 times
            k = k + k + k + k;
            Console.WriteLine(k);
        }
    }
}
 