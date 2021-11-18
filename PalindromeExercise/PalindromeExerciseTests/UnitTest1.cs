using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("basketball", false)]
        [InlineData("redivider", true)]
        [InlineData("reviver", true)]
        [InlineData("Apples", false)]
        public void Test1(string s, bool expected)
        {
            // Arrange
            var test = new WordSmith();
            // Act
            var actual = test.IsPalindrome(s);

            // Assert
            Assert.Equal(actual,expected);
        }
    }
}
