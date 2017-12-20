using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallidaExamUniqueCharacters
{
    public class HandleStrings
    {
        public List<char> UniqueCharacters(string text)
        {
            var uniqueList = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                string testString = text.Substring(0, i) + text.Substring(i + 1);
                if (!testString.Contains(text[i]))
                    uniqueList.Add(text[i]);
            }
            return uniqueList;
        }
    }
}
