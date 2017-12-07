using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveX("xtyxikXy"));
            Console.ReadLine();
        }

        static string RemoveX(string text)
        {
            if (text.Length == 0)
            {
                return text;
            }
            if (text[0] == 'x')
            {
                text = text.Substring(1);
            }
            return text[0] + RemoveX(text.Substring(1));
        }
    }
}
