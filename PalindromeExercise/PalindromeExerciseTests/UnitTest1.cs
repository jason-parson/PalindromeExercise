using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( "racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("Civic", true)]
        [InlineData("horse", false)]
        [InlineData("Radar", true)]

        public void FirstTest(string val, bool expected)
        {   //Arrange
            var wordSmith = new WordSmith();

            //Act
            bool actual = wordSmith.IsAPalindrone(val);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

  
}
