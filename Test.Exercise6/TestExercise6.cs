using System;
using Xunit;

namespace Test.Exercise6
{
    public class TestExercise6
    {
        [Fact]
        public void Should_Return_The_Bigest_Number_In_The_List_And_What_Position_It_Is()
        {
            //Given
            var exercise6 = new Exercise6();
            var numbers = new double[]
            {
                1,4,23,5,76,8,9,1,2,0
            };

            //When
            var result = exercise6.BiggestNumberInArray(numbers);

            //Then
            Assert.Equal((76, 4), result);
        }
    }
}
