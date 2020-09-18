using System;
using System.Linq;

namespace Test.Exercise8
{
    public class Exercise8
    {
        public int VogalVectorCount(char[] letters) => 
                                                letters.ToList()
                                                .Where(n =>  n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')   
                                                .Count();
        
    }
}