using System;
using System.Collections.Generic;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var checkList = new List<int> { 4, 8, 12, 16 };
            bool containsAll = true;
            foreach (int item in checkList)
            {
                // or check list.IndexOf return value 
                if (!list.Contains(item))
                {
                    containsAll = false;
                }
            }
            Console.WriteLine(" 'list' contains all the elements of 'checkList': " + containsAll);
            Console.ReadLine();
        }
    }
}
