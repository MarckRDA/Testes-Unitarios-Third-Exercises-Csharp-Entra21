using System;
using Xunit;

namespace Test.Exercise9
{
    public class TestExercise9
    {
        [Theory]
        [InlineData(new string[]{"e", "s", "d", "a", "g", "i", "o", "h", "l", "w"}, "edgol")]
        [InlineData(new string[]{"q", "f", "u", "i", "a", "b", "p", "k", "h", "a"}, "quaph")]
        [InlineData(new string[]{"t", "i", "s", "i", "g", "i", "e", "d", "g", "s"}, "tsgeg")]
        [InlineData(new string[]{"i", "o", "e", "a", "u", "k", "o", "i", "l", "w"}, "ieuol")]
        public void Should_Return_A_Word_Composed_With_Letters_In_Even_Position_In_Array(string[] letters, string expectedResult)
        {
            //Given
            var exercise9 = new Exercise9();

            //When
            var result = exercise9.SumStrings(letters);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
