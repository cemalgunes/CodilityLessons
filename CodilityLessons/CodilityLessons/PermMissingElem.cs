using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class PermMissingElem
    { 
        public int Solution(int[] A)
        {
            if (!A.Any() || !A.Any(x => x == 1)) { return 1; }
            var size = A.Length;
            var numberTwoList = Enumerable.Range(1, size);
            var failNumber = numberTwoList.Except(A);
            if (!failNumber.Any()) { return A.Max() + 1; }
            return failNumber.FirstOrDefault();
        }
    }
}
