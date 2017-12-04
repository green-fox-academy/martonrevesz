using System;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\lottery-data.txt";
            string destination = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\lottery-data-selected.txt";
            WriteLotteryDataInFile(source, destination);

            int[] thefinalArray = FindFiveMostCommon(FillResultsInArray(destination));
            foreach (int item in thefinalArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void WriteLotteryDataInFile(string source, string destination)
        {
            var sr = new StreamReader(source);
            var sw = new StreamWriter(destination);
            string line = "";

            try
            {
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitData = line.Split(';');
                        for (int i = 11; i < 16; i++)
                        {
                            sw.Write(splitData[i] + " ");
                        }
                        sw.Write("\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sw.Close();
            }
        }

        static int[] FillResultsInArray(string file)
        {
            int[] options = new int[90];
            var sr = new StreamReader(file);
            string line = " ";
            try
            {
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitString = line.Split(' ');
                        for (int i = 0; i < 5; i++)
                        {
                            options[(int.Parse(splitString[i])) - 1] += 1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();              
            }
            return options;
        }

        static int[] FindFiveMostCommon(int[] inputArray)
        {
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int currentMaxIndex = 0;
                for (int j = 1; j < inputArray.Length; j++)
                {
                    if (inputArray[currentMaxIndex] < inputArray[j])
                    {
                        currentMaxIndex = j;
                    }                  
                }
                result[i] = currentMaxIndex + 1;
                inputArray[currentMaxIndex] = -1;
            }
            return result;
        }
    }
}
