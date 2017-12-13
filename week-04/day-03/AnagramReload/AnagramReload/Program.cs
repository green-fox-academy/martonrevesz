using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramReload
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "gerzson";
            string string2 = "ersznog";
            Console.WriteLine(Anagram.IsAnagram(string1, string2));
            Console.ReadLine();
        }       
    }
}
