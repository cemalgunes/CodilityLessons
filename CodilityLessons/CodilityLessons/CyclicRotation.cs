using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        { 
            if (A == null) throw new ArgumentNullException(nameof(A));
            if (K < 0) throw new ArgumentOutOfRangeException(nameof(K));
            if (A.Length == 0) return new int[0];

            var size = sizeof(int);
            var result = new int[A.Length];
            int diff = K % A.Length;
            Buffer.BlockCopy(A, 0, result, diff * size, (A.Length - diff) * size);
            Buffer.BlockCopy(A, (A.Length - diff) * size, result, 0, diff * size);
            return result;
        }
    }
}
