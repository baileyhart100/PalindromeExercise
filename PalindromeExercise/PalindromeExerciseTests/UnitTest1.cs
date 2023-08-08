using System;
using Xunit;
using PalindromeExercise;

namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("radar", true)]
        [InlineData("Racecar", true)]

        public void MyTest(string word, bool expected)
        {
        //Arange
        var tester = new WordSmith();

        //Act
        var actual = tester.IsAPalindrome(word);

        //Assert
        Assert.Equal(expected, actual);

        }
    }
}
