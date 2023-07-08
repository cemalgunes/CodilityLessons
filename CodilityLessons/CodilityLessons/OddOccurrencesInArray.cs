using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        { 
            int a = 0;
            for (int i = 0; i < A.Length; i++)
            {
                a ^= A[i];
            }
            return a;
        }
    }
}
