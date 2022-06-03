using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Calastone.App
{
    internal class Program
    {
        private static readonly ITextFilters filters = new TextFilters();
        static void Main(string[] args)
        {

            //string textInput = File.ReadAllText("./sampletext.txt");
            string textInput = ReadTextFile();
            string[] words = textInput.Split(new char[] { ' ' });
            var data = words
                .Where(word => filters.ContainsMiddleVowel(word)
                            && filters.HasLessThanThreeLetters(word)
                            && filters.ContainsLetterTee(word));


            Console.WriteLine($"\n\r Result Text:- \n\r { string.Join(", ", data)}");
            Console.WriteLine("\n\r Press any key to exit.");
            Console.ReadKey();
        }

        private static string ReadTextFile()
        {
            string value = string.Empty;

            while (!File.Exists(value))
            {
                Console.Clear();
                Console.WriteLine("Calastone TextFilter Exercise...");
                Console.Write("Enter full file path: ");
                value = Console.ReadLine();
            }

            return File.ReadAllText(value);
        }

    }
}
