using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallidaExamFavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "favourites.txt";
            
            if (args.Length == 0)
            {
                Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string[] currentContent = File.ReadAllLines(fileName);
                    var streamWriter = new StreamWriter(fileName, true);                   
                    var testList = currentContent.ToList();
                    if (!testList.Contains(args[i]))
                    {
                        streamWriter.WriteLine(args[i]);
                        
                    }
                    streamWriter.Close();

                }
            }
        }
    }
}
