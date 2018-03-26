using System;

namespace FinalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[0];
            Console.WriteLine(SelectTheBiggestOddIndexedNumber(testArray));
        }

        static int SelectTheBiggestOddIndexedNumber(int[] intArray)
        {
            int biggest = intArray.Length > 1 ? intArray[1] : throw new Exception();
            for (int i = 3; i < intArray.Length; i+=2)
            {
                if (intArray[i] > biggest)
                    biggest = intArray[i];
            }
            return biggest;
        }
    }
}
