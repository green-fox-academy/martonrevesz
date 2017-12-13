using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var extension = new Extension();
            Console.WriteLine(extension.Translate("vásár"));
            Console.ReadLine();
        }
    }
}
