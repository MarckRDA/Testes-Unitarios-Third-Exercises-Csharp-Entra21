using System;
using Xunit;

namespace Test.Exercise1
{
    public class TestExercise1
    {
        double[] arrayA = new double[]
        {
            3, 4.12, 1, -3.4, 5.75, 7, -8, 1, 2.87, -3
        };

        double[] arrayB = new double[]
        {
            -43, 2.6, -7.21, 8, 12.12, 2.1, 34.8, 5, 6, -9.32
        };


        [Fact]
        public void Should_Return_A_Twisted_ArrayA()
        {
            //Given
            var exercise1 = new Exercise1();
                 
            //When
            var result = exercise1.TwistedArrays(arrayA, arrayB);

            //Then
            Assert.Equal(arrayA, result.b);    
        }

        [Fact]
        public void Should_Return_A_Twisted_ArrayB()
        {
            //Given
            var exercise1 = new Exercise1();
            
            //When
            var result = exercise1.TwistedArrays(arrayA, arrayB);

            //Then
            Assert.Equal(arrayB, result.a);
            
        }
    }
}
