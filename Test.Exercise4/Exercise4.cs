using System;

namespace Test.Exercise4
{
    public class Exercise4
    {
        public double SumBetweenAAndBArray(double[] numbers)
        {
            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {                
                sum = (numbers[i] % 2 != 0) ? sum += numbers[i] : sum;
            }

            return sum;
        }
    }
}