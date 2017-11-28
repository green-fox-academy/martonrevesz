using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] colors = new string[3][];
            colors[0] = new[] { "lime", "olive", "pale green", "spring green", "asbest" };
            colors[1] = new[] { "orange red", "red", "pink" };
            colors[2] = new[] { "orchid", "violet", "hot pink" };

            PrintMultiArray(colors);
            Console.ReadLine();
        }

        private static void PrintMultiArray(string[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                foreach (string item in array[i])
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("=================");
            }
        }
    }
}
