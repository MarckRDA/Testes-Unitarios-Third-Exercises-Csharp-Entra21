using Xunit;

namespace Test.Exercise5
{
    public class TestExercise5
    {
        [Theory]
        [InlineData(new double[]{-8, 4, -9, 12, 45, -82, -1, 3, 8, -7}, 5)]
        [InlineData(new double[]{0.43, -84.3, -83.5, 1.34, -183, 32.84, 12.43}, 4)]
        [InlineData(new double[]{75, -43.21, 45.63, 8.76, -93.4}, 3)]
        public void Should_Return_How_Many_Positive_Numbers_There_Are_In_Array(double[] numbers, int expectedResult)
        {
            //Given
            var exercise5 = new Exercise5();
            
            //When
            var result = exercise5.CountPositivePositions(numbers);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
