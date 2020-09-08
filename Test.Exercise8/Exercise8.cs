using System;

namespace Test.Exercise8
{
    public class Exercise8
    {
        public int VogalVectorCount(string[] letters)
        {
            var countVogal = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == "a" || letters[i] == "e" || letters[i] == "i" || letters[i] == "o" || letters[i] == "u")
                {
                    countVogal++;
                }
            }
            
            return countVogal;
        }
    }
}