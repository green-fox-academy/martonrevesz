using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramApp.Models
{
    public class AnagramChecker
    {
        public bool IsTrue { get; set; }


        public void AreAnagrams(string anagram, string anagram2)
        {
            if (anagram.Length == anagram2.Length)
            {
                List<char> sortedAnagram = anagram.ToList();
                sortedAnagram.Sort();
                List<char> sortedAnagram2 = anagram2.ToList();
                sortedAnagram2.Sort();


                for (int i = 0; i < sortedAnagram.Count; i++)
                {
                    if (sortedAnagram2[i] != sortedAnagram[i])
                    {
                        this.IsTrue = false;
                    }
                    this.IsTrue = true;
                }

            }
            this.IsTrue = false;
        }
    }
}
