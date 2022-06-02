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
                            && filters.LessThanThreeLetters(word)
                            && filters.ContainsLetterTee(word));


            Console.WriteLine($" \n\r Result: \n\r { string.Join(", ", data)}");
            Console.ReadKey();
        }

        private static string ReadTextFile()
        {
        label:
            Console.Clear();
            Console.WriteLine("Calastone TextFile Exercise...");
            Console.Write("Enter full file path:_");
            string value = Console.ReadLine();
            if (!File.Exists(value))
            {
                goto label;
            }

            return File.ReadAllText(value);
        }

    }
}
