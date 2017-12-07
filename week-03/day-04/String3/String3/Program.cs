using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToAsterix("happyDayAtGreenFox"));
            Console.ReadLine();
        }
        static string ToAsterix(string text)
        {
            if (text.Length == 1)
            {
                return text;
            }
            text = text[0] + "*" + text.Substring(1);
            return text.Substring(0, 2) + ToAsterix(text.Substring(2));
        }
    }
}
