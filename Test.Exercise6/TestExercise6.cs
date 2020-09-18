using System;
using System.Collections.Generic;
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
            var numbers = new List<double>()
            {
                1.09, 4.2, -23, 5, 76, 8, -9, 1, 2.43, 0
            };

            //When
            var result = exercise6.BiggestNumberInArray(numbers);

            //Then
            Assert.Equal((76, 4), result);
        }
    }
}
