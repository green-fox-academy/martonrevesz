using System;
using System.Collections.Generic;

namespace StudentCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new List<Dictionary<string, object>>();

            // Given this list of hashmaps...
            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Rezso");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Gerzson");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Aurel");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Zsombor");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "Teodor");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            double sumAge = 0;
            foreach (Dictionary<string, object> item in map)
            {
                if ( (int) item["candies"] > 3)
                {
                    Console.WriteLine(item["name"]);
                }
                if ((int)item["candies"] < 5)
                {
                    sumAge += Convert.ToDouble(item["age"]);
                }
            }
            Console.WriteLine("The sum of age of those who have less then five candies: " + sumAge);
            Console.ReadLine();
        }
    }
}
