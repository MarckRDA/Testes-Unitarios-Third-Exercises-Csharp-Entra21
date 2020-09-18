using System;
using System.Linq;

namespace Test.Exercise5
{
    public class Exercise5
    {
        public int CountPositivePositions(double[] numbers) => numbers.ToList().Where(x => x > 0).Count();
    }
}