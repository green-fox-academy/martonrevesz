using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostItStruct;

namespace PostItStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1;
            PostIt postIt2;
            PostIt postIt3;

            postIt1.backgroundColor = "black";
            postIt1.text = "Idea 1";
            postIt1.textColor = "orange";
            postIt2.backgroundColor = "pink";
            postIt2.text = "Awesome";
            postIt2.textColor = "black";
            postIt3.backgroundColor = "yellow";
            postIt3.text = "Superb";
            postIt3.textColor = "green";

            Console.WriteLine(postIt1.text);
            Console.WriteLine(postIt2.textColor);
            Console.WriteLine(postIt3.text);
            Console.ReadLine();
        }
    }
}
