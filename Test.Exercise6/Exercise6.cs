using System;

namespace Test.Exercise6
{
    public class Exercise6
    {
        public (double biggestNumber, int position) BiggestNumberInArray(double[] numbers)
        {
            (double value, int position, int flag) biggestNumber = (0.0, 0, 0);
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        biggestNumber.value = numbers[i];
                        biggestNumber.position = i;
                        biggestNumber.flag++;
                    }
                }
                if (biggestNumber.flag == numbers.Length - 1)
                {
                    break;
                }
                biggestNumber.flag = 0;
            }

            return (biggestNumber.value, biggestNumber.position);
        }
    }
}