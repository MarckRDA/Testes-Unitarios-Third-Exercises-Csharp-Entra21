using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Exercise6
{
    public class Exercise6
    {
        public (double biggestNumber, int position) BiggestNumberInArray(List<double> numbers)
        {
            (double value, int position) biggestNumber = (0.0, 0);
            
            biggestNumber.value = numbers.Max();
            biggestNumber.position = numbers.IndexOf(biggestNumber.value);
            
            return (biggestNumber.value, biggestNumber.position);
        }
    }
}