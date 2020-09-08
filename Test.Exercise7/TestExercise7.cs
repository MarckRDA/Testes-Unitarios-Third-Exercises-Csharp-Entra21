using System;
using Xunit;

namespace Test.Exercise7
{
    public class TestExercise7
    {
        [Fact]
        public void Should_Return_How_Many_Times_A_Number_Is_In_The_Same_Position_As_Itsself_Value()
        {
            //Given
            var exercise7 = new Exercise7();
            var numbers = new double[]
            {
                0, 2, 2, 3, 56, 7, 1, 7, 5, 9
            };

            //When
            var result = exercise7.ValuedEqualPlacedInArray(numbers);

            //Then
            Assert.Equal(5, result);
        }
    }
}
