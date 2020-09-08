using System;

namespace Test.Exercise1
{
    public class Exercise1
    {

        public (double[] a, double[] b) TwistedArrays(double[] arrayA, double[] arrayB)
        {
            var arrayNumbersA = new double[arrayA.Length];
            var arrayNumbersB = new double[arrayB.Length];
            
            for (int index = 0; index < arrayNumbersA.Length; index++)
            {
                arrayNumbersA[index] = arrayB[index];
            }

            for (int index = 0; index < arrayA.Length; index++)
            {
                arrayNumbersB[index] = arrayA[index];
            }

            return (arrayNumbersA, arrayNumbersB);
        }
    }
}