using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class PermCheck
    {
        public int Solution(int[] A)
        {
            return (Enumerable.Range(1, A.Length).Except(A).Count() == 0) ? 1 : 0;
        } 
    }
}
