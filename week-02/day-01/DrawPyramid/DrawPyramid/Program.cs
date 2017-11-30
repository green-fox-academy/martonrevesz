using System;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < number; i++)
            {
                for (int j = i; j < number; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
