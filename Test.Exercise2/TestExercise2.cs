using System;
using Xunit;

namespace Test.Exercise2
{
    public class TestExercise2
    {
        [Theory]
        [InlineData(new double[] {-1, 3, 2, 4, -5, 3, -6, 7, 8, -10})]
        [InlineData(new double[] {-3, -9, 0, -8, -4, -3, 9, 12, 54, 10})]
        [InlineData(new double[] {0.98, -43, 0, 12.8, 98.64, -12, 0.98, -74.9, 0, 65.87})]
        public void Should_Return_Whether_There_Is_A_Repeted_Number_In_Array(double[] numbers)
        {
            //Given
            var exercise2 = new Exercise2();
            

            //When
            var result = exercise2.IsThereARepeatedNumberInArray(numbers);

            Assert.True(result);
        }
    }
}
