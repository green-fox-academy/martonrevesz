using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            DivideTenBy(a);
            Console.ReadLine();
        }
        static void DivideTenBy(int number)
        {
            try
            {
                Console.WriteLine(10 / number);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
