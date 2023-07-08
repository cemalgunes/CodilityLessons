using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A)
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
