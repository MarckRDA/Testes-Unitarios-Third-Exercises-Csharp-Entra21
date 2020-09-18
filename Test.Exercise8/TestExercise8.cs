using System;
using Xunit;

namespace Test.Exercise8
{
    public class TestExercise8
    {
        [Theory]
        [InlineData(new char[]{'e', 's', 'd', 'a', 'g', 'i', 'o', 'h', 'l', 'w'}, 4)]
        [InlineData(new char[]{'q', 'f', 'u', 'i', 's', 'b', 'p', 'k', 'h', 'a'}, 3)]
        [InlineData(new char[]{'t', 'i', 's', 'i', 'g', 'i', 'e', 'u', 'g', 'a'}, 6)]
        [InlineData(new char[]{'i', 'o', 'e', 'a', 'u', 'k', 'o', 'i', 'l', 'w'}, 7)]
        public void Should_Return_How_Many_Vogals_There_Are_In_Array(char[] letters, int expectedResult)
        {
            //Given
            var exercise8 = new Exercise8();

            //When
            var result = exercise8.VogalVectorCount(letters);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
