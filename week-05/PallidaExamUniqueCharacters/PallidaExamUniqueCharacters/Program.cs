using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallidaExamUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var handleStrings = new HandleStrings();
            string text = "anagram";
            var resultList = handleStrings.UniqueCharacters(text);
            foreach (char item in resultList)
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
