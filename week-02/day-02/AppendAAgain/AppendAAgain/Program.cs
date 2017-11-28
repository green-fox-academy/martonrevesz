using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendAAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "kuty", "macsk", "cic" };
            AppendA(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            Console.ReadLine();
        }

        static string[] AppendA(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += "a";
            }
            return array;
        }
    }
}
