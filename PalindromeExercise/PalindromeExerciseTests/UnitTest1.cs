using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("racecar", true)]
        [InlineData("rotator", true)]
        [InlineData("cow", false)]
        [InlineData("truecoders", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var pal = new WordSmith();
            var actual = pal.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
