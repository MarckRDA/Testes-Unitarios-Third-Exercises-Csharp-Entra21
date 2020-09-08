using System;

namespace Test.Exercise5
{
    public class Exercise5
    {
        public int CountPositivePositions(double[] numbers)
        {
            var positiveNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                positiveNumbers = (numbers[i] > 0) ? positiveNumbers += 1 : positiveNumbers;
            }
            
            return positiveNumbers;
        }
    }
}