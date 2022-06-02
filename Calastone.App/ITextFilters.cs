using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calastone.App
{
    public interface ITextFilters
    {
        bool ContainsMiddleVowel(string word);
        bool LessThanThreeLetters(string word);
        bool ContainsLetterTee(string word);
    }
}