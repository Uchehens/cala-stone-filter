using System;
using Xunit;
using Calastone.App;

namespace Calastone.Test
{
    public class TextFiltersTest
    {
        private ITextFilters _textFilters;


        [Theory]
        [InlineData("clean", true)]
        [InlineData("what", true)]
        [InlineData("currently", true)]
        [InlineData("the", false)]
        [InlineData("rather", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("a", true)]
        [InlineData("b", false)]
        [InlineData("as", true)]
        public void ContainsMiddleVowelTest(string word, bool expected)
        {
            _textFilters = new TextFilters();
            var result = _textFilters.ContainsMiddleVowel(word);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("clean", false)]
        [InlineData("what", false)]
        [InlineData("the", false)]
        [InlineData("as", true)]
        [InlineData("a", true)]
        [InlineData("           ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void LessThanThreeLettersTest(string word, bool expected)
        {
            _textFilters = new TextFilters();
            var result = _textFilters.LessThanThreeLetters(word);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("clean", false)]
        [InlineData("what", true)]
        [InlineData("WHAT", true)]
        [InlineData("the", true)]
        [InlineData("as", false)]
        [InlineData("a", false)]
        [InlineData("t", true)]
        [InlineData("T", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void ContainsLetterTee (string word, bool expected)
        {
            _textFilters = new TextFilters();
            var result = _textFilters.ContainsLetterTee(word);
            Assert.Equal(expected, result);
        }
    }
}
