using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };
            //swap the first and the third element
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            //print the elements to the console
            foreach (string item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
