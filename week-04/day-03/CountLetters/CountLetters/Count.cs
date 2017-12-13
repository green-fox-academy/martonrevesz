using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class Count
    {
        public Dictionary<char, int> CountLetters(string text)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (char item in text)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }
            return dictionary;
        }
    }
}
