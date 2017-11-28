using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = {3, 4, 5, 6, 7};
            Array.Reverse(aj);
            //print aj
            foreach (int item in aj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
