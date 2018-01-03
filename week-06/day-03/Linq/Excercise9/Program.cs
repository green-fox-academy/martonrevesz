using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'v', '4' };
            string text = string.Join(string.Empty, charArray);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
