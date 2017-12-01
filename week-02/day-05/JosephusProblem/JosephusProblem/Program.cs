using System;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            Console.WriteLine(FindJosephus(number));
            Console.ReadLine();
        }

        static int FindJosephus (int number)
        {
            int i = 0;
            int goodExponent = 0;
            while (Math.Pow(2,i) <= number)
            {
                i++;
            }
            i--;

            int remainder = number % (int) (Math.Pow(2,i));
            int goodPlace = remainder * 2 + 1;
            return goodPlace ;
        }
    }
}
