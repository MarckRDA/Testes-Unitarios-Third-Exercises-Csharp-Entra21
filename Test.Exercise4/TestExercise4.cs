using System;
using Xunit;

namespace Test.Exercise4
{
    public class TestExercise4
    {
        [Fact]
        public void Should_Return_A_Sum_Of_Elements_What_Are_Odds()
        {
            //Given
            var exercise4 = new Exercise4();
            var numbers = new double[]
            {
                2,45,3,7,6
            };

            //When
            var result = exercise4.SumBetweenAAndBArray(numbers);

            //Then
            Assert.Equal(55, result);
        }
    }
}
