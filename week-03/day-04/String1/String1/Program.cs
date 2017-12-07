using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceXToY("xgxXw yda"));
            Console.ReadLine();
        }
        static string ReplaceXToY(string text)
        {
            if (text.Length == 0)
            {
                return text;
            }
            if (text[0] == 'x')
            {
                text = "y" + text.Substring(1);
            }
            return text[0] + ReplaceXToY(text.Substring(1));
        }
    }
}
