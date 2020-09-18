namespace Test.Exercise2
{
    public class Exercise2
    {
        public bool IsThereARepeatedNumberInArray(double[] vect)
        {

            var thereIsARepeatedNumber = false;

            for (int i = 0; i < vect.Length; i++)
            {
                for (int j = i; j < vect.Length; j++)
                {
                    if (i != j && vect[i] == vect[j])
                    {
                        thereIsARepeatedNumber = true;
                        break;
                    }
                }
                if (thereIsARepeatedNumber)
                {
                    break;
                }

            }

            return thereIsARepeatedNumber;
        }
    }
}