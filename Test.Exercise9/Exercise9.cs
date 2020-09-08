using System;

namespace Test.Exercise9
{
    public class Exercise9
    {
        public string SumStrings(string[] letters)
        {
            var biultString = "";
            
            for (int i = 0; i < letters.Length; i++)
            {
                biultString = (i % 2 == 0) ? biultString += letters[i] : biultString;
            }
            
            return biultString;
        }
    }
}