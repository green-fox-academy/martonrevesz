using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayFirst.Models
{
    public class MyArray
    {
        public string What { get; set; }
        public int[] Numbers { get; set; } = new int[4];

        public override string ToString()
        {
            string result = What;
            result += "[";
            for (int i = 0; i < Numbers.Length; i++)
            {
                result += Numbers[i] + ", ";
            }
            result += "]";
            return result ;
        }
    }
}
