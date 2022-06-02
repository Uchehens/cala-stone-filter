using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calastone.App
{
    public class TextFilters : ITextFilters
    {

       
        public bool ContainsMiddleVowel(string word)
        {
            bool result = false;
            string vowels = "aeiou";
            if (!string.IsNullOrEmpty(word))
            { 
                word = word.Trim();
                if (word.Length % 2 == 0)
                {
                    var middleLetters = word.Substring(((word.Length/2) - 1), 2);
                    foreach(var letter in middleLetters)
                    {
                        if (vowels.Contains(letter))
                        {
                            result = true;
                            break;
                        }
                    }
                }
                else
                {
                    var middleLetters = word.Substring((word.Length / 2), 1);
                    result = vowels.Contains(middleLetters);
                }
            }

            return result;
        }

        public bool LessThanThreeLetters(string word)
        {
            return !string.IsNullOrWhiteSpace(word) && word.Trim().Length < 3;
        }
        public bool ContainsLetterTee(string word)
        {
            return !string.IsNullOrEmpty(word) && word.ToLower().Contains("t");
        }

    }
}
