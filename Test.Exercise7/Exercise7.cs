using System;
using System.Linq;

namespace Test.Exercise7
{
    public class Exercise7
    {
        public int ValuedEqualPlacedInArray(int[] numbers) => numbers.ToList().Where((n, i) => n == i).Count();
    }
}