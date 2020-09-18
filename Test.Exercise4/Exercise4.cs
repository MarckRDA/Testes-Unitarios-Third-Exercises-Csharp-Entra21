using System;
using System.Linq;

namespace Test.Exercise4
{
    public class Exercise4
    {
        public double SumBetweenAAndBArray(double[] numbers) => Math.Round(numbers.ToList().Where(x => x % 2 != 0).Sum(), 2);
        
    }
}