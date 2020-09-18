using System;
using Xunit;

namespace Test.Exercise4
{
    public class TestExercise4
    {
        [Theory]
        [InlineData(new double[]{2, 45, 3, 7, 6}, 55.00)]
        [InlineData(new double[]{-5, -6, 89.43, 83, 0, -8, 54}, 167.43)]
        [InlineData(new double []{12, 4.3, 6.5, 15.43, -94}, 26.23)]
        public void Should_Return_A_Sum_Of_Elements_What_Are_Odds(double[] numbers, double expectedResult)
        {
            //Given
            var exercise4 = new Exercise4();
            
            //When
            var result = exercise4.SumBetweenAAndBArray(numbers);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
