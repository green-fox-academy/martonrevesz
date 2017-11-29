using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "My todo: \n");
            todoText = todoText.Insert(todoText.Length, " - Download games \n");
            todoText = todoText.Insert(todoText.Length, "\t - Diablo");

            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
