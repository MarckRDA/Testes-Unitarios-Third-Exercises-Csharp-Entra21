using System;
using Xunit;

namespace Test.Exercise2
{
    public class TestExercise2
    {
        [Fact]
        public void Should_Return_Whether_There_Is_A_Repeted_Number_In_Array()
        {
            //Given
            var exercise2 = new Exercise2();
            var numbers = new double[]
            {
                1,3,2,4,5,3,6,7,8,10
            };

            //When
            var result = exercise2.IsThereARepeatedNumberInArray(numbers);

            Assert.True(result);
        }
    }
}
