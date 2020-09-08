using System;
using Xunit;

namespace Test.Exercise5
{
    public class TestExercise5
    {
        [Fact]
        public void Should_Return_How_Many_Positive_Numbers_There_Are_In_Array()
        {
            //Given
            var exercise5 = new Exercise5();
            var numbers = new double[]
            {
                -8, 4, -9, 12, 45, -82, -1, 3, 8, -7
            };

            //When
            var result = exercise5.CountPositivePositions(numbers);

            //Then
            Assert.Equal(5, result);
        }
    }
}
