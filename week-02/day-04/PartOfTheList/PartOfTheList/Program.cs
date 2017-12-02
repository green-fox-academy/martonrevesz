using System;
using System.Collections.Generic;

namespace PartOfTheList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            int[] myArray = { 723, 911, 815, 2, 68, 72377177, 32, 434243 };
            int testNumber = 23;
            result.AddRange(PartOfInt(myArray, testNumber));
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<int> PartOfInt(int[] numberList, int single)
        {
            var goodIndeces = new List<int>();
            string singleString = single.ToString();
            for (int i = 0; i < numberList.Length; i++)
            {
                string elementString = numberList[i].ToString();
                for (int j = 0; j < elementString.Length - (singleString.Length -1); j++)
                {
                    if(elementString.Substring(j, singleString.Length) == singleString & !(goodIndeces.Contains(i)))
                    {
                        goodIndeces.Add(i);
                    }
                }
            }
            return goodIndeces;
        }
    }
}
