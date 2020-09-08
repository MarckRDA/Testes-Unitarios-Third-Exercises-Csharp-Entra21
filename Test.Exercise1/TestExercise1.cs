using System;
using Xunit;

namespace Test.Exercise1
{
    public class TestExercise1
    {
        [Fact]
        public void Should_Return_A_Twisted_ArrayA()
        {
            //Given
            var exercise1 = new Exercise1();
            
            var arrayA = new double[]
            {
                3,4,1,34,5,7,8,1,2,3
            };

            var arrayB = new double[]
            {
                43,6,7,8,1,2,34,5,6,9
            };

            //When
            var result = exercise1.TwistedArrays(arrayA, arrayB);

            //Then
            for (int index = 0; index < arrayA.Length; index++)
            {
                Assert.Equal(arrayA[index], result.b[index]);    
            }

        }

        [Fact]
        public void Should_Return_A_Twisted_ArrayB()
        {
            //Given
            var exercise1 = new Exercise1();
            
            var arrayA = new double[]
            {
                3,4,1,34,5,7,8,1,2,3
            };

            var arrayB = new double[]
            {
                43,6,7,8,1,2,34,5,6,9
            };

            //When
            var result = exercise1.TwistedArrays(arrayA, arrayB);

            //Then
            for (int index = 0; index < arrayB.Length; index++)
            {
                Assert.Equal(arrayB[index], result.a[index]);
            }
            
        }
    }
}
