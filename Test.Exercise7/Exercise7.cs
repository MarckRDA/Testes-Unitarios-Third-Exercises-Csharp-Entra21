using System;

namespace Test.Exercise7
{
    public class Exercise7
    {
        public int ValuedEqualPlacedInArray(double[] numbers)
        {
            var match = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                match = (numbers[i] == i) ? match += 1 : match;
            }

            return match;
        }
    }
}