using System;

namespace DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                //draw spaces on line i
                double spaceDouble = Math.Abs(i - (number - 1) / 2.0);
                int spaceInt = (int)Math.Floor(spaceDouble);
                for (int j = 0; j < spaceInt; j++)
                {
                    Console.Write(" ");
                }
                // draw stars on line i
                double starDouble = 
                    Math.Abs(i - (number - 1) / 2.0)* (-2) + number;
                int starInt = (int)Math.Floor(starDouble);
                for (int j = 0; j < starInt; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\r\n");
            }
            Console.ReadLine();
        }
    }
}
