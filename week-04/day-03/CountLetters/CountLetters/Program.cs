using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var Count = new Count();

            Dictionary<char, int> myDict = Count.CountLetters("barnabas");
            foreach (var item in myDict)
            {
                Console.WriteLine(item.Key + item.Value.ToString() + "\n");
            }
            Console.ReadLine();
        }
    }
}
