using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("monkey", false)]
        [InlineData("malayalam", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arange
            var word3 = new WordSmith();
            //Act
            var actual = word3.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
