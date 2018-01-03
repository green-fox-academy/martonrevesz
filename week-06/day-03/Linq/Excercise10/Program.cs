using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxList = new List<Fox>()
            {
                new Fox("foxy", "asbest", "green"),
                new Fox("vuk", "badcat", "green"),
                new Fox("ravasz", "please", "purple"),
                new Fox("fox", "asbest", "green"),
                new Fox("foxter", "asbest", "red")
            };

            foxList.Where(f => f.Color == "green")
                .ToList()
                .ForEach(f => Console.WriteLine(f.Name));

            Console.WriteLine("***");

            foxList.Where(f => f.Color == "green" && f.Type == "asbest")
                .ToList()
                .ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();
        }
    }
}
