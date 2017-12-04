using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int a;
            try
            {
                a = int.Parse(Console.ReadLine());
                DivideTenBy(a);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
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
