using System;
using Xunit;

namespace Test.Exercise7
{
    public class TestExercise7
    {
        [Theory]
        [InlineData(new int[] {0, 2, 2, 3, 56, 7, 1, 7, 5, 9}, 5)]
        [InlineData(new int[] {5, 1, 4, 6, 9, 6, 6, 1, 8, 10}, 3)]
        [InlineData(new int[] {9, 8, 67, 9, 16, 5, 12, 7}, 2)]
        public void Should_Return_How_Many_Times_A_Number_Is_In_The_Same_Position_As_Itsself_Value(int[] numbers, int expectedResult)
        {
            //Given
            var exercise7 = new Exercise7();
            
            //When
            var result = exercise7.ValuedEqualPlacedInArray(numbers);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
